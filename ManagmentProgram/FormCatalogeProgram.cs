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

namespace EduMuse.ManagmentProgram
{
    public partial class FormCatalogeProgram : Form
    {
        private DataTable programsDataTable;

        public FormCatalogeProgram()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события загрузки формы.
        /// Загружает данные программ из базы данных в таблицу.
        /// </summary>
        private void Form4_Load(object sender, EventArgs e)
        {
            programsDataTable = LoadProgramsFromDatabase();
            if (programsDataTable != null)
            {
                guna2DataGridView_Programs.DataSource = programsDataTable;
            }
        }

        /// <summary>
        /// Загружает данные программ из базы данных.
        /// </summary>
        /// <returns>DataTable с данными программ или null в случае ошибки.</returns>
        private DataTable LoadProgramsFromDatabase()
        {
            // Укажите строку подключения к вашей базе данных
            // !!! ВНИМАНИЕ: Замените эту строку на реальную строку подключения !!!
            string connectionString = "Data Source=PcMar\\TEST1;Initial Catalog=MuseumEduDB;Integrated Security=True";

            string query = "SELECT [ProgramName] as 'Название', [Description] as 'Описание', [MinAge] as 'Возраст', [DurationMinutes] as 'Продолжительность' FROM Programs";

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
                MessageBox.Show("Ошибка при загрузке данных из базы данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return dataTable;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Закрыть".
        /// Закрывает текущую форму.
        /// </summary>
        private void guna2Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Свернуть".
        /// Сворачивает текущую форму в панель задач.
        /// </summary>
        private void guna2Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Назад".
        /// Открывает предыдущую форму (меню) и скрывает текущую.
        /// </summary>
        private void guna2Button_Back_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Применить фильтр".
        /// Фильтрует данные в DataGridView на основе введенного текста и выбранного критерия.
        /// </summary>
        private void guna2Button_ApplyFilter_Click(object sender, EventArgs e)
        {
            if (programsDataTable == null)
            {
                return;
            }

            string searchText = guna2TextBox_Search.Text.ToLower().Trim();
            string filterCriteria = guna2ComboBox_Filter.SelectedItem?.ToString();
            string filterExpression = "";

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                if (filterCriteria == "По теме")
                {
                    filterExpression = $"Название LIKE '%{searchText}%'";
                }
                else if (filterCriteria == "По возрасту")
                {
                    // Явно преобразуем числовой столбец "Age" в строку для операции LIKE
                    filterExpression = $"CONVERT(Возраст, 'System.String') LIKE '%{searchText}%'";
                }
                else // "Без фильтра" или любой другой критерий
                {
                    // Явно преобразуем числовой столбец "Age" в строку для операции LIKE
                    filterExpression = $"Название LIKE '%{searchText}%' OR Описание LIKE '%{searchText}%' OR CONVERT(Возраст, 'System.String') LIKE '%{searchText}%'";
                }
            }

            // Применяем фильтр к DefaultView таблицы данных
            programsDataTable.DefaultView.RowFilter = filterExpression;
        }
    }
}

