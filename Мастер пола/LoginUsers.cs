using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мастер_пола
{
    public partial class LoginUsers : Form
    {
        public LoginUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            string Login = txtLogin.Text;
            string Pass = txtPass.Text;

            if (string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Pass))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            try
            {
                bool boolfound = false;

                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();
<<<<<<< HEAD
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Партнеры WHERE AND Почта = @Login AND Пароль = @Pass", connect))
=======
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Партнеры WHERE Почта = @Login AND Пароль = @Pass", connect))
>>>>>>> 1000121212
                    {
                        command.Parameters.AddWithValue("@Login", Login);
                        command.Parameters.AddWithValue("@Pass", Pass);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                boolfound = true;
                                Mainwin win = new Mainwin();
                                win.Show();
                                this.Hide();
                                MessageBox.Show("Добро пожаловать");
                            }
                        }
                    }
                    if (!boolfound)
                    {
<<<<<<< HEAD
                        using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Сотрудники WHERE Роль = 'админ' AND Почта = @Login AND Пароль = @Pass", connect))
=======
                        using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Сотрудники WHERE Почта = @Login AND Пароль = @Pass", connect))
>>>>>>> 1000121212
                        {
                            command.Parameters.AddWithValue("@Login", Login);
                            command.Parameters.AddWithValue("@Pass", Pass);

                            using (NpgsqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    boolfound = true;
                                    MainWindow win = new MainWindow();
                                    win.Show();
                                    this.Hide();
                                    MessageBox.Show("Добро пожаловать");
                                }
                            }
                        }
                    }

                    if (!boolfound)
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        Point last_point = new Point();
        private void LoginUsers_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }

        }

        private void LoginUsers_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

        }
    }
}