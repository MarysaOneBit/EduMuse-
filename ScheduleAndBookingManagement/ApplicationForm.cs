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
    public partial class ApplicationForm : Form
    {
        string connectionString = "Data Source=PcMar\\TEST1;Initial Catalog=MuseumEduDB;Integrated Security=True";

        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            // Загрузка списка доступных программ в ComboBox
            LoadProgramsIntoComboBox();
        }

        /// <summary>
        /// Загружает названия программ из базы данных в ComboBox.
        /// Отображаются только те программы, у которых есть доступные экземпляры в будущем.
        /// </summary>
        private void LoadProgramsIntoComboBox()
        {
            // Запрос, который выбирает ProgramID и ProgramName только для тех программ, у которых есть будущие экземпляры
            // с доступными местами.
            string query = @"
                SELECT DISTINCT P.ProgramID, P.ProgramName
                FROM Programs P
                JOIN ProgramInstances PI ON P.ProgramID = PI.ProgramID
                WHERE P.IsActive = 1 AND PI.ScheduledDateTime > GETDATE() AND (PI.CurrentParticipants < P.MaxParticipants)
                ORDER BY P.ProgramName";

            DataTable programs = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    connection.Open();
                    adapter.Fill(programs);
                }

                if (programs.Rows.Count > 0)
                {
                    // Привязываем DataTable к ComboBox
                    comboBox_Programs.DataSource = programs;
                    comboBox_Programs.DisplayMember = "ProgramName";
                    comboBox_Programs.ValueMember = "ProgramID";
                }
                else
                {
                    MessageBox.Show("В данный момент нет доступных программ для бронирования.", "Нет программ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox_Programs.DataSource = null; // Очищаем ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка программ: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик кнопки "Отправить". Сохраняет заявку в базе данных.
        /// </summary>
        private void guna2Button_Submit_Click(object sender, EventArgs e)
        {
            // Простая валидация полей
            if (comboBox_Programs.SelectedValue == null || string.IsNullOrWhiteSpace(guna2TextBox_Name.Text) || string.IsNullOrWhiteSpace(guna2TextBox_Phone.Text) || string.IsNullOrWhiteSpace(guna2TextBox_Email.Text) || numericUpDown_Participants.Value <= 0)
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Находим ProgramInstanceID, который соответствует выбранной программе и будущей дате
            int programId = Convert.ToInt32(comboBox_Programs.SelectedValue);
            int participantsRequested = (int)numericUpDown_Participants.Value;
            int instanceId = GetAvailableProgramInstanceId(programId, participantsRequested);

            if (instanceId == 0)
            {
                MessageBox.Show("Извините, на эту программу пока нет доступных мест. Пожалуйста, выберите другую программу.", "Нет доступных мест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Вычисляем общую стоимость
            decimal pricePerParticipant = GetPricePerParticipant(programId);
            decimal totalAmount = pricePerParticipant * participantsRequested;

            string query = @"
                INSERT INTO Bookings (InstanceID, ContactName, ContactPhone, ContactEmail, NumberOfParticipants, BookingStatus, TotalAmount)
                VALUES (@InstanceID, @ContactName, @ContactPhone, @ContactEmail, @NumberOfParticipants, 'В ожидании', @TotalAmount)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@InstanceID", instanceId);
                    command.Parameters.AddWithValue("@ContactName", guna2TextBox_Name.Text);
                    command.Parameters.AddWithValue("@ContactPhone", guna2TextBox_Phone.Text);
                    command.Parameters.AddWithValue("@ContactEmail", guna2TextBox_Email.Text);
                    command.Parameters.AddWithValue("@NumberOfParticipants", participantsRequested);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Ваша заявка успешно отправлена! Мы свяжемся с вами в ближайшее время.", "Заявка отправлена", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Очищаем форму после успешной отправки
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отправке заявки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Возвращает ProgramInstanceID для первого доступного экземпляра программы.
        /// </summary>
        private int GetAvailableProgramInstanceId(int programId, int participantsRequested)
        {
            // Запрос, который использует JOIN для более эффективного поиска доступных мест.
            string query = @"
                SELECT TOP 1 pi.InstanceID
                FROM ProgramInstances pi
                JOIN Programs p ON pi.ProgramID = p.ProgramID
                WHERE pi.ProgramID = @ProgramID
                AND pi.ScheduledDateTime > GETDATE()
                AND (pi.CurrentParticipants + @ParticipantsRequested) <= p.MaxParticipants
                ORDER BY pi.ScheduledDateTime";

            int instanceId = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProgramID", programId);
                    command.Parameters.AddWithValue("@ParticipantsRequested", participantsRequested);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        instanceId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске доступного экземпляра программы: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return instanceId;
        }

        /// <summary>
        /// Возвращает стоимость за одного участника для выбранной программы.
        /// </summary>
        private decimal GetPricePerParticipant(int programId)
        {
            string query = "SELECT PricePerParticipant FROM Programs WHERE ProgramID = @ProgramID";
            decimal price = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProgramID", programId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        price = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении цены программы: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return price;
        }

        /// <summary>
        /// Очищает поля формы.
        /// </summary>
        private void ClearForm()
        {
            guna2TextBox_Name.Clear();
            guna2TextBox_Phone.Clear();
            guna2TextBox_Email.Clear();
            numericUpDown_Participants.Value = 1;
            comboBox_Programs.SelectedIndex = -1; // Сброс выбора
        }

        private void guna2Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

