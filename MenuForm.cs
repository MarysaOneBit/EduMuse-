using EduMuse.ManagmentProgram;
using EduMuse.ScheduleAndBookingManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduMuse
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
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
        /// Обработчик нажатия кнопки "Программы".
        /// Открывает основную форму (Form1) и скрывает текущую.
        /// </summary>
        private void guna2Button_Programs_Click(object sender, EventArgs e)
        {
            ManagmentForm mainForm = new ManagmentForm();
            mainForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сотрудники".
        /// Здесь должна быть логика для открытия формы "Сотрудники".
        /// </summary>
        private void guna2Button_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalForm personalForm = new PersonalForm();
            personalForm.Show();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Экспонаты".
        /// Здесь должна быть логика для открытия формы "Экспонаты".
        /// </summary>
        private void guna2Button_Exhibits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет открыта форма для управления экспонатами.");
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Отчеты".
        /// Здесь должна быть логика для открытия формы "Отчеты".
        /// </summary>
        private void guna2Button_Reports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет открыта форма для генерации отчетов.");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingManagment bookingManagment = new BookingManagment();
            bookingManagment.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationForm bookingManagment = new ApplicationForm();
            bookingManagment.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCatalogeProgram formCatalogeProgram = new FormCatalogeProgram();
            formCatalogeProgram.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}
