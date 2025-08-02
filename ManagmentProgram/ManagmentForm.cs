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
    public partial class ManagmentForm : Form
    {
        // Строка подключения к базе данных
        // ОБЯЗАТЕЛЬНО замените "YourServerName" на имя вашего SQL Server
        string connectionString = "Data Source=PcMar\\TEST1;Initial Catalog=MuseumEduDB;Integrated Security=True";

        public ManagmentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // При загрузке формы загружаем все данные
            LoadPrograms();
            LoadStaff();

            // Устанавливаем форматирование для DataGridView
            dgvPrograms.Columns["ProgramID"].Visible = false;
        }



        // Метод для загрузки списка программ в DataGridView с русскими названиями колонок
        private void LoadPrograms()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT
                            p.ProgramID,
                            p.ProgramName AS 'Название программы',
                            p.Description AS 'Описание',
                            p.TargetAudience AS 'Целевая аудитория',
                            p.DurationMinutes AS 'Длительность (мин)',
                            p.PricePerParticipant AS 'Стоимость',
                            p.MinAge AS 'Мин. возраст',
                            p.MaxAge AS 'Макс. возраст',
                            p.MaxParticipants AS 'Макс. участников',
                            s.FirstName + ' ' + s.LastName AS 'Ответственный сотрудник'
                        FROM Programs p
                        LEFT JOIN Staff s ON p.ResponsibleStaffID = s.StaffID;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPrograms.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке программ: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для загрузки списка сотрудников в ComboBox
        private void LoadStaff()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT StaffID, FirstName + ' ' + LastName AS FullName FROM Staff WHERE IsActive = 1;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    guna2ComboBox_Staff.DataSource = dt;
                    guna2ComboBox_Staff.DisplayMember = "FullName";
                    guna2ComboBox_Staff.ValueMember = "StaffID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке сотрудников: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик нажатия на кнопку "Добавить"
        private void guna2Button_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO Programs (ProgramName, Description, TargetAudience, DurationMinutes, PricePerParticipant, MinAge, MaxAge, MaxParticipants, ResponsibleStaffID)
                        VALUES (@ProgramName, @Description, @TargetAudience, @DurationMinutes, @PricePerParticipant, @MinAge, @MaxAge, @MaxParticipants, @ResponsibleStaffID);";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProgramName", guna2TextBox_ProgramName.Text);
                    command.Parameters.AddWithValue("@Description", guna2TextBox_Description.Text);
                    command.Parameters.AddWithValue("@TargetAudience", guna2TextBox_TargetAudience.Text);
                    command.Parameters.AddWithValue("@DurationMinutes", guna2NumericUpDown_Duration.Value);
                    command.Parameters.AddWithValue("@PricePerParticipant", guna2NumericUpDown_Price.Value);
                    command.Parameters.AddWithValue("@MinAge", guna2NumericUpDown_MinAge.Value);
                    command.Parameters.AddWithValue("@MaxAge", guna2NumericUpDown_MaxAge.Value);
                    command.Parameters.AddWithValue("@MaxParticipants", guna2NumericUpDown_MaxParticipants.Value);
                    command.Parameters.AddWithValue("@ResponsibleStaffID", guna2ComboBox_Staff.SelectedValue);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Программа успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    LoadPrograms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении программы: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик нажатия на кнопку "Обновить"
        private void guna2Button_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox_ProgramID.Text))
            {
                MessageBox.Show("Пожалуйста, выберите программу для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm())
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        UPDATE Programs SET
                            ProgramName = @ProgramName,
                            Description = @Description,
                            TargetAudience = @TargetAudience,
                            DurationMinutes = @DurationMinutes,
                            PricePerParticipant = @PricePerParticipant,
                            MinAge = @MinAge,
                            MaxAge = @MaxAge,
                            MaxParticipants = @MaxParticipants,
                            ResponsibleStaffID = @ResponsibleStaffID,
                            LastModified = GETDATE()
                        WHERE ProgramID = @ProgramID;";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProgramID", int.Parse(guna2TextBox_ProgramID.Text));
                    command.Parameters.AddWithValue("@ProgramName", guna2TextBox_ProgramName.Text);
                    command.Parameters.AddWithValue("@Description", guna2TextBox_Description.Text);
                    command.Parameters.AddWithValue("@TargetAudience", guna2TextBox_TargetAudience.Text);
                    command.Parameters.AddWithValue("@DurationMinutes", guna2NumericUpDown_Duration.Value);
                    command.Parameters.AddWithValue("@PricePerParticipant", guna2NumericUpDown_Price.Value);
                    command.Parameters.AddWithValue("@MinAge", guna2NumericUpDown_MinAge.Value);
                    command.Parameters.AddWithValue("@MaxAge", guna2NumericUpDown_MaxAge.Value);
                    command.Parameters.AddWithValue("@MaxParticipants", guna2NumericUpDown_MaxParticipants.Value);
                    command.Parameters.AddWithValue("@ResponsibleStaffID", guna2ComboBox_Staff.SelectedValue);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Программа успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    LoadPrograms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении программы: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик нажатия на кнопку "Удалить"
        private void guna2Button_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox_ProgramID.Text))
            {
                MessageBox.Show("Пожалуйста, выберите программу для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Запрашиваем подтверждение у пользователя
            DialogResult dialogResult = MessageBox.Show(
                "Вы уверены, что хотите удалить эту программу? Это действие необратимо.",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Programs WHERE ProgramID = @ProgramID;";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ProgramID", int.Parse(guna2TextBox_ProgramID.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Программа успешно удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        LoadPrograms();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении программы: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обработчик клика по ячейке в DataGridView
        private void dgvPrograms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPrograms.Rows[e.RowIndex];

                // Заполняем поля формы данными из выбранной строки
                guna2TextBox_ProgramID.Text = row.Cells["ProgramID"].Value.ToString();
                guna2TextBox_ProgramName.Text = row.Cells["Название программы"].Value.ToString();
                guna2TextBox_Description.Text = row.Cells["Описание"].Value.ToString();
                guna2TextBox_TargetAudience.Text = row.Cells["Целевая аудитория"].Value.ToString();
                guna2NumericUpDown_Duration.Value = Convert.ToDecimal(row.Cells["Длительность (мин)"].Value);
                guna2NumericUpDown_Price.Value = Convert.ToDecimal(row.Cells["Стоимость"].Value);
                guna2NumericUpDown_MinAge.Value = Convert.ToDecimal(row.Cells["Мин. возраст"].Value);
                guna2NumericUpDown_MaxAge.Value = Convert.ToDecimal(row.Cells["Макс. возраст"].Value);
                guna2NumericUpDown_MaxParticipants.Value = Convert.ToDecimal(row.Cells["Макс. участников"].Value);

                // Выбираем сотрудника в ComboBox
                string staffName = row.Cells["Ответственный сотрудник"].Value?.ToString();
                if (!string.IsNullOrEmpty(staffName))
                {
                    guna2ComboBox_Staff.Text = staffName;
                }
                else
                {
                    guna2ComboBox_Staff.SelectedIndex = -1;
                }
            }
        }

        // Валидация полей формы
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox_ProgramName.Text))
            {
                MessageBox.Show("Пожалуйста, введите название программы.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (guna2ComboBox_Staff.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите ответственного сотрудника.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Очистка формы
        private void ClearForm()
        {
            guna2TextBox_ProgramID.Clear();
            guna2TextBox_ProgramName.Clear();
            guna2TextBox_Description.Clear();
            guna2TextBox_TargetAudience.Clear();
            guna2NumericUpDown_Duration.Value = 0;
            guna2NumericUpDown_Price.Value = 0;
            guna2NumericUpDown_MinAge.Value = 0;
            guna2NumericUpDown_MaxAge.Value = 0;
            guna2NumericUpDown_MaxParticipants.Value = 0;
            guna2ComboBox_Staff.SelectedIndex = -1; // Сброс выбранного элемента
        }

        private void guna2Button_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}