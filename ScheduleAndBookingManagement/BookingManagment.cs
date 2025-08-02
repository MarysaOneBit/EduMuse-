using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduMuse.ScheduleAndBookingManagement
{
    public partial class BookingManagment : Form
    {
        private DataTable programsDataTable;
        string connectionString = "Data Source=PcMar\\TEST1;Initial Catalog=MuseumEduDB;Integrated Security=True";

        public BookingManagment()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Загрузка расписания на текущий день
            LoadScheduleData(guna2DateTimePicker_Schedule.Value);
            // Загрузка всех бронирований для обработки
            LoadBookingsData();

            // Привязываем обработчик события ValueChanged к DateTimePicker
            guna2DateTimePicker_Schedule.ValueChanged += guna2DateTimePicker_Schedule_ValueChanged;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Закрыть".
        /// </summary>
        private void guna2Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Свернуть".
        /// </summary>
        private void guna2Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Назад".
        /// Возвращает пользователя в главное меню.
        /// </summary>
        private void guna2Button_Back_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Загружает расписание программ на выбранную дату из базы данных.
        /// </summary>
        private void LoadScheduleData(DateTime date)
        {
            // Запрос изменен для использования LIKE по строковому представлению даты.
            // Этот подход менее оптимален, чем прямое сравнение дат.
            string s = date.ToString("yyyy-MM-dd");
            string query = @"
                SELECT 
                    pi.InstanceID,
                    p.ProgramName AS Программа,
                    pi.ScheduledDateTime AS 'Начало',
                    pi.EndTime AS 'Конец',
                    (p.MaxParticipants - pi.CurrentParticipants) AS 'Свободных мест',
                    p.MaxParticipants AS 'Всего мест',
                    s.FirstName + ' ' + s.LastName AS Сотрудник
                FROM ProgramInstances pi
                INNER JOIN Programs p ON pi.ProgramID = p.ProgramID
                LEFT JOIN Staff s ON pi.StaffID = s.StaffID
                WHERE CONVERT(VARCHAR(10), pi.ScheduledDateTime, 120) LIKE '%"+s+"%' "+
                "ORDER BY pi.ScheduledDateTime";
             
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    // Передаем дату как строку в формате 'yyyy-MM-dd' для корректной работы LIKE
                   
                    connection.Open();
                    
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке расписания из базы данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            guna2DataGridView_Schedule.DataSource = dataTable;
            // Скрываем столбец InstanceID, который нужен для внутренних операций
            guna2DataGridView_Schedule.Columns["InstanceID"].Visible = false;

            // Здесь можно добавить логику для выявления конфликтов расписания,
            // например, если один сотрудник назначен на две программы одновременно.
            // Для этого можно выполнить дополнительный SQL-запрос, группируя по сотруднику.
        }

        /// <summary>
        /// Загружает список бронирований из базы данных.
        /// </summary>
        private void LoadBookingsData()
        {
            string query = @"
                SELECT 
                    b.BookingID,
                    p.ProgramName AS Программа,
                    pi.ScheduledDateTime AS Дата,
                    b.ContactName AS Клиент,
                    b.BookingStatus AS Статус,
                    b.NumberOfParticipants AS 'Количество участников'
                FROM Bookings b
                INNER JOIN ProgramInstances pi ON b.InstanceID = pi.InstanceID
                INNER JOIN Programs p ON pi.ProgramID = p.ProgramID
                WHERE b.BookingStatus = 'В ожидании'
                ORDER BY pi.ScheduledDateTime";

            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке бронирований из базы данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            guna2DataGridView_Bookings.DataSource = dataTable;
            // Скрываем столбец BookingID, который нужен для внутренних операций
            guna2DataGridView_Bookings.Columns["BookingID"].Visible = false;
        }

        /// <summary>
        /// Обработчик выбора вкладки.
        /// </summary>
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedTab == tabPage_Schedule)
            {
                LoadScheduleData(guna2DateTimePicker_Schedule.Value);
            }
            else if (guna2TabControl1.SelectedTab == tabPage_Bookings)
            {
                LoadBookingsData();
            }
        }

        /// <summary>
        /// Обработчик изменения даты в DatePicker.
        /// Обновляет расписание на новую выбранную дату.
        /// </summary>
        private void guna2DateTimePicker_Schedule_ValueChanged(object sender, EventArgs e)
        {
            LoadScheduleData(guna2DateTimePicker_Schedule.Value);
        }

        /// <summary>
        /// Обновляет статус бронирования в базе данных.
        /// </summary>
        private void UpdateBookingStatus(int bookingId, string newStatus)
        {
            string query = "UPDATE Bookings SET BookingStatus = @Status WHERE BookingID = @BookingID";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@BookingID", bookingId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении статуса бронирования: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик кнопки "Подтвердить" для бронирования.
        /// </summary>
        private void guna2Button_Confirm_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView_Bookings.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(guna2DataGridView_Bookings.SelectedRows[0].Cells["BookingID"].Value);
                UpdateBookingStatus(bookingId, "Подтверждено");
                MessageBox.Show("Бронирование успешно подтверждено.");
                LoadBookingsData(); // Перезагружаем данные для обновления таблицы
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите бронирование для подтверждения.");
            }
        }

        /// <summary>
        /// Обработчик кнопки "Отклонить" для бронирования.
        /// </summary>
        private void guna2Button_Reject_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView_Bookings.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(guna2DataGridView_Bookings.SelectedRows[0].Cells["BookingID"].Value);
                UpdateBookingStatus(bookingId, "Отклонено");
                MessageBox.Show("Бронирование успешно отклонено.");
                LoadBookingsData(); // Перезагружаем данные для обновления таблицы
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите бронирование для отклонения.");
            }
        }
    }
}
