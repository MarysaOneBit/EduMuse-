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
    public partial class AutoForm : Form
    {
        public AutoForm()
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
<<<<<<< HEAD
        }g
=======
        }
>>>>>>> AddFormAndAuto

        /// <summary>
        /// Обработчик нажатия кнопки "Войти".
        /// Проверяет введенные данные и выполняет вход.
        /// </summary>
        private void guna2Button_Login_Click(object sender, EventArgs e)
        {
            // Здесь должна быть реальная логика авторизации, например,
            // обращение к базе данных или API.
            // В этом примере используется простая проверка для демонстрации.
            string username = guna2TextBox_Username.Text;
            string password = guna2TextBox_Password.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Вход успешен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Создаем и показываем основную форму (Form1)
                AutoForm mainForm = new AutoForm();
                mainForm.Show();
                this.Hide(); // Скрываем форму авторизации
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль. Попробуйте еще раз.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

