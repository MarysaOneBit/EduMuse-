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

namespace EduMuse
{
    public partial class PersonalForm : Form
    {      // ВНИМАНИЕ: Замените эту строку на реальную строку подключения к вашей БД "MuseumEduDB"
        string connectionString = "Data Source=PcMar\\TEST1;Initial Catalog=MuseumEduDB;Integrated Security=True";

        public PersonalForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_4_Load(object sender, EventArgs e)
        {
            // Загрузка данных при загрузке формы
            LoadStaff();
            LoadProgramsIntoComboBox();
            LoadStaffForAssignment();
        }

        // --- Управление формой: свернуть/закрыть ---
        private void guna2ControlBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ControlBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Учет сотрудников ---
        /// <summary>
        /// Загружает данные о сотрудниках в DataGridView.
        /// </summary>
        private void LoadStaff()
        {
            string query = "SELECT StaffID as '№', FirstName as 'Имя', LastName as 'Фамилия', Position as 'Должность'  FROM Staff WHERE IsActive = 1 ORDER BY LastName";
            DataTable staffTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(staffTable);
                }
                guna2DataGridView_Staff.DataSource = staffTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка сотрудников: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик кнопки "Добавить сотрудника".
        /// </summary>
        private void guna2Button_AddStaff_Click(object sender, EventArgs e)
        {
            // Простая валидация
            if (string.IsNullOrWhiteSpace(guna2TextBox_FirstName.Text) || string.IsNullOrWhiteSpace(guna2TextBox_LastName.Text) || string.IsNullOrWhiteSpace(guna2TextBox_Position.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Staff (FirstName, LastName, Position, IsActive) VALUES (@FirstName, @LastName, @Position, 1)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", guna2TextBox_FirstName.Text);
                    command.Parameters.AddWithValue("@LastName", guna2TextBox_LastName.Text);
                    command.Parameters.AddWithValue("@Position", guna2TextBox_Position.Text);
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Сотрудник успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновляем списки
                    ClearStaffForm();
                    LoadStaff();
                    LoadStaffForAssignment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении сотрудника: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Очищает поля для добавления нового сотрудника.
        /// </summary>
        private void ClearStaffForm()
        {
            guna2TextBox_FirstName.Clear();
            guna2TextBox_LastName.Clear();
            guna2TextBox_Position.Clear();
        }

        // --- Назначение программ и отслеживание нагрузки ---
        /// <summary>
        /// Загружает список программ в ComboBox для назначения.
        /// </summary>
        private void LoadProgramsIntoComboBox()
        {
            string query = "SELECT ProgramID, ProgramName FROM Programs WHERE IsActive = 1 ORDER BY ProgramName";
            DataTable programs = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(programs);
                }

                guna2ComboBox_Programs.DataSource = programs;
                guna2ComboBox_Programs.DisplayMember = "ProgramName";
                guna2ComboBox_Programs.ValueMember = "ProgramID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка программ: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Загружает сотрудников в ComboBox для назначения программ.
        /// </summary>
        private void LoadStaffForAssignment()
        {
            string query = "SELECT StaffID, FirstName + ' ' + LastName AS FullName FROM Staff WHERE IsActive = 1 ORDER BY LastName";
            DataTable staff = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(staff);
                }

                guna2ComboBox_AssignStaff.DataSource = staff;
                guna2ComboBox_AssignStaff.DisplayMember = "FullName";
                guna2ComboBox_AssignStaff.ValueMember = "StaffID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка сотрудников для назначения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Загружает экземпляры программ для выбранной программы.
        /// </summary>
        private void guna2ComboBox_Programs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox_Programs.SelectedValue != null && guna2ComboBox_Programs.SelectedValue is int programId)
            {
                LoadProgramInstances(programId);
            }
        }

        /// <summary>
        /// Загружает экземпляры программ для выбранной программы в ComboBox.
        /// </summary>
        private void LoadProgramInstances(int programId)
        {
            string query = "SELECT InstanceID, ScheduledDateTime FROM ProgramInstances WHERE ProgramID = @ProgramID AND ScheduledDateTime > GETDATE() ORDER BY ScheduledDateTime";
            DataTable instances = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProgramID", programId);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(instances);
                }

                guna2ComboBox_Instances.DataSource = instances;
                guna2ComboBox_Instances.DisplayMember = "ScheduledDateTime";
                guna2ComboBox_Instances.ValueMember = "InstanceID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке экземпляров программ: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Отображает нагрузку выбранного сотрудника.
        /// </summary>
        private void guna2ComboBox_AssignStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox_AssignStaff.SelectedValue != null && guna2ComboBox_AssignStaff.SelectedValue is int staffId)
            {
                LoadWorkload(staffId);
            }
        }

        /// <summary>
        /// Загружает список программ, назначенных сотруднику, в DataGridView.
        /// </summary>
        private void LoadWorkload(int staffId)
        {
            string query = @"
                SELECT P.ProgramName as 'Программа', PI.ScheduledDateTime as 'Дата'
                FROM ProgramInstances PI
                JOIN Programs P ON PI.ProgramID = P.ProgramID
                WHERE PI.StaffID = @StaffID AND PI.ScheduledDateTime > GETDATE()
                ORDER BY PI.ScheduledDateTime";

            DataTable workload = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StaffID", staffId);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(workload);
                }
                guna2DataGridView_Workload.DataSource = workload;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке нагрузки сотрудника: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик кнопки "Назначить".
        /// </summary>
        private void guna2Button_Assign_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox_Instances.SelectedValue == null || guna2ComboBox_AssignStaff.SelectedValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите программу и сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int instanceId = Convert.ToInt32(guna2ComboBox_Instances.SelectedValue);
            int staffId = Convert.ToInt32(guna2ComboBox_AssignStaff.SelectedValue);

            string query = "UPDATE ProgramInstances SET StaffID = @StaffID WHERE InstanceID = @InstanceID";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StaffID", staffId);
                    command.Parameters.AddWithValue("@InstanceID", instanceId);
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Сотрудник успешно назначен на программу.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновляем нагрузку, чтобы отобразить изменения
                    LoadWorkload(staffId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при назначении сотрудника: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2HtmlLabel_Program_Click(object sender, EventArgs e)
        {

        }
    }
}
