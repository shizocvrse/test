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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мастер_пола
{
    public partial class AddUsers : Form
    {
        
        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            LoginUsers logform = new LoginUsers();
            logform.Show();
            this.Close();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            string Company = txtNameCompany.Text;
            string Adress = txtadress.Text;
            int INN;
            string Surname = txtSurname.Text;
            string Name = txtName.Text;
            string Secondname = txtSecondname.Text;
            string Phone = txtNumberPhone.Text;
            string Mail = txtMail.Text;
            string Password = txtPass.Text;

            
            if (string.IsNullOrWhiteSpace(Surname) ||
                string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Mail) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(Phone) ||
                string.IsNullOrWhiteSpace(Adress) ||
                string.IsNullOrWhiteSpace(Company) ||
                string.IsNullOrWhiteSpace(txtINN.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (!int.TryParse(txtINN.Text, out INN))
            {
                MessageBox.Show("Введите корректный ИНН");
                return;
            }
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();
                    string query = "INSERT INTO Партнеры (Наименование_компании, Юридический_адрес,ИНН,Фамилия_директора,Имя_директора,Отчество_директора,Номер_телефона,Почта,Пароль) VALUES (@Company,@Adress,@INN,@Surname,@Name,@Secondname,@Phone,@Mail,@Password)";
                    using (var command = new NpgsqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Company", Company);
                        command.Parameters.AddWithValue("@Adress", Adress);
                        command.Parameters.AddWithValue("@INN", INN);
                        command.Parameters.AddWithValue("@Surname", Surname);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Secondname", Secondname);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Mail", Mail);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Регистрация прошла успешно");
                        MainWindow mainwin = new MainWindow();
                        mainwin.Show();
                        this.Show();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message); // Показываем сообщение об ошибке
            }
        }
        Point lastpoint = new Point();
        private void AddUsers_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void AddUsers_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X,e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top -= e.Y - lastpoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
