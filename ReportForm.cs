using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace EduMuse
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        // ВНИМАНИЕ: Замените эту строку на реальную строку подключения к вашей БД "MuseumEduDB"
        string connectionString = "Data Source=PcMar\\TEST1;Initial Catalog=MuseumEduDB;Integrated Security=True";

        /// <summary>
        /// Загружает отчет по посещаемости в указанный DataGridView.
        /// Отчет включает количество участников, сгруппированных по программам, месяцам и возрастным группам.
        /// </summary>
        /// <param name="dataGridView">Контрол DataGridView для отображения отчета.</param>
        public void LoadAttendanceReportToDataGridView(DataGridView dataGridView)
        {
            // SQL-запрос для отчета по посещаемости
            // Колонки отчета названы на русском языке для удобства отображения в DataGridView
            string query = @"
                SELECT
                    FORMAT(pi.ScheduledDateTime, 'yyyy-MM') AS Месяц,
                    p.ProgramName AS Программа,
                    CASE
                        WHEN pa.Age BETWEEN 0 AND 12 THEN 'Дети (0-12 лет)'
                        WHEN pa.Age BETWEEN 13 AND 25 THEN 'Молодежь (13-25 лет)'
                        WHEN pa.Age BETWEEN 26 AND 60 THEN 'Взрослые (26-60 лет)'
                        ELSE 'Пожилые (60+ лет)'
                    END AS Возрастная_группа,
                    COUNT(pa.ParticipantID) AS Количество_участников
                FROM
                    Participants AS pa
                INNER JOIN
                    Bookings AS b ON pa.BookingID = b.BookingID
                INNER JOIN
                    ProgramInstances AS pi ON b.InstanceID = pi.InstanceID
                INNER JOIN
                    Programs AS p ON pi.ProgramID = p.ProgramID
                WHERE
                    b.BookingStatus = 'Подтверждено'
                GROUP BY
                    FORMAT(pi.ScheduledDateTime, 'yyyy-MM'),
                    p.ProgramName,
                    CASE
                        WHEN pa.Age BETWEEN 0 AND 12 THEN 'Дети (0-12 лет)'
                        WHEN pa.Age BETWEEN 13 AND 25 THEN 'Молодежь (13-25 лет)'
                        WHEN pa.Age BETWEEN 26 AND 60 THEN 'Взрослые (26-60 лет)'
                        ELSE 'Пожилые (60+ лет)'
                    END
                ORDER BY
                    Месяц,
                    Программа,
                    Возрастная_группа;";

            DataTable reportData = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        connection.Open();
                        adapter.Fill(reportData);
                    }
                }

                // Устанавливаем DataSource для DataGridView
                dataGridView.DataSource = reportData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadProgramPopularityReportToDataGridView(DataGridView dataGridView)
        {
            // SQL-запрос для отчета по популярности программ
            string query = @"
                SELECT
                    FORMAT(pi.ScheduledDateTime, 'yyyy-MM') AS Месяц,
                    p.ProgramName AS Программа,
                    COUNT(pa.ParticipantID) AS Количество_участников
                FROM
                    Participants AS pa
                INNER JOIN
                    Bookings AS b ON pa.BookingID = b.BookingID
                INNER JOIN
                    ProgramInstances AS pi ON b.InstanceID = pi.InstanceID
                INNER JOIN
                    Programs AS p ON pi.ProgramID = p.ProgramID
                WHERE
                    b.BookingStatus = 'Подтверждено'
                GROUP BY
                    FORMAT(pi.ScheduledDateTime, 'yyyy-MM'),
                    p.ProgramName
                ORDER BY
                    Месяц,
                    Программа;";

            DataTable reportData = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        connection.Open();
                        adapter.Fill(reportData);
                    }
                }

                // Устанавливаем DataSource для DataGridView
                dataGridView.DataSource = reportData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadStaffPerformanceReportToDataGridView(DataGridView dataGridView)
        {
            // SQL-запрос для отчета по эффективности и загрузке сотрудников
            string query = @"
                SELECT
                    s.LastName AS Фамилия,
                    s.FirstName AS Имя,
                    s.Position AS Должность,
                    COUNT(pi.InstanceID) AS Количество_программ,
                    SUM(b.NumberOfParticipants) AS Общее_количество_участников
                FROM
                    Staff AS s
                INNER JOIN
                    ProgramInstances AS pi ON s.StaffID = pi.StaffID
                INNER JOIN
                    Bookings AS b ON pi.InstanceID = b.InstanceID
                WHERE
                    -- Учитываем только подтвержденные бронирования для измерения реальной загрузки
                    b.BookingStatus = 'Подтверждено'
                GROUP BY
                    s.LastName,
                    s.FirstName,
                    s.Position
                ORDER BY
                    Количество_программ DESC,
                    Общее_количество_участников DESC;";

            DataTable reportData = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        connection.Open();
                        adapter.Fill(reportData);
                    }
                }

                dataGridView.DataSource = reportData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке отчета по сотрудникам: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportDataGridViewToExcel(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Excel.Application excelApp = null;
            Excel.Workbook excelWorkbook = null;
            Excel.Worksheet excelWorksheet = null;

            try
            {
                // Создание диалога для сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                saveFileDialog.Title = "Сохранить отчет в Excel";
                saveFileDialog.FileName = "Отчет_" + DateTime.Now.ToString("yyyyMMdd_HHmm");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelApp = new Excel.Application();
                    excelApp.Visible = false; // Скрываем Excel на время работы

                    excelWorkbook = excelApp.Workbooks.Add(Missing.Value);
                    excelWorksheet = (Excel.Worksheet)excelWorkbook.ActiveSheet;

                    // Добавляем заголовок отчета
                    excelWorksheet.Cells[1, 1].Value = "Отчет для библиотеки";
                    Excel.Range headerRange = excelWorksheet.Range[excelWorksheet.Cells[1, 1], excelWorksheet.Cells[1, dataGridView.Columns.Count]];
                    headerRange.Merge();
                    headerRange.Font.Bold = true;
                    headerRange.Font.Size = 14;
                    headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // Заполняем заголовки колонок DataGridView
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        excelWorksheet.Cells[3, i + 1] = dataGridView.Columns[i].HeaderText;
                    }
                    Excel.Range columnHeadersRange = excelWorksheet.Range[excelWorksheet.Cells[3, 1], excelWorksheet.Cells[3, dataGridView.Columns.Count]];
                    columnHeadersRange.Font.Bold = true;
                    columnHeadersRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // Заполняем данными из DataGridView
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            if (dataGridView.Rows[i].Cells[j].Value != null)
                            {
                                excelWorksheet.Cells[i + 4, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    // Автоподбор ширины колонок
                    Microsoft.Office.Interop.Excel.Range dataRange = excelWorksheet.Range[excelWorksheet.Cells[3, 1], excelWorksheet.Cells[dataGridView.Rows.Count + 3, dataGridView.Columns.Count]];
                    dataRange.Columns.AutoFit();
                    dataRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                    // Добавляем подпись и дату
                    int signatureRow = dataGridView.Rows.Count + 6;
                    excelWorksheet.Cells[signatureRow, 1].Value = "Отчет распечатал: [ФИО Пользователя]";
                    excelWorksheet.Cells[signatureRow + 1, 1].Value = "Дата распечатки: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                    excelWorksheet.Cells[signatureRow + 3, 1].Value = "Подпись: ______________________";

                    // Сохраняем и открываем файл
                    excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при экспорте в Excel: " + ex.Message, "Ошибка экспорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Очистка COM-объектов
                if (excelWorksheet != null) Marshal.ReleaseComObject(excelWorksheet);
                if (excelWorkbook != null) Marshal.ReleaseComObject(excelWorkbook);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);
            }
        }
        private void guna2Button_ApplyFilter_Click(object sender, EventArgs e)
        {
            LoadAttendanceReportToDataGridView(guna2DataGridView_Programs);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadProgramPopularityReportToDataGridView(guna2DataGridView_Programs);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadStaffPerformanceReportToDataGridView(guna2DataGridView_Programs);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(guna2DataGridView_Programs);
        }
    }
}
