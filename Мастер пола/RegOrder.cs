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

namespace Мастер_пола
{
    public partial class RegOrder : Form
    {
        public RegOrder()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string Type_product = txtType.Text;
            string Name_product = txtNameProduct.Text;
            int Price = Convert.ToInt32(txtPrice.Text);
            string Pricestring = Price.ToString();
            DateTime Date = DateTime.Parse(txtDataproduct.Text);
            string Dateproduct = Date.ToString("день-месяц-год");

            if (string.IsNullOrWhiteSpace(Type_product) || string.IsNullOrWhiteSpace(Name_product) || string.IsNullOrWhiteSpace(Dateproduct) || string.IsNullOrWhiteSpace(Pricestring))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();
                    string query = "INSERT INTO Заявка(Тип_заявки, Название_продукции, Стоимость, Сроки_изготовления) VALUES (@Type_product, @Name_product, @Pricestring, @Dateproduct)";
                    using (var command = new NpgsqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Type_product", Type_product);
                        command.Parameters.AddWithValue("@Name_product", Name_product);
                        command.Parameters.AddWithValue("Pricestring", Pricestring);
                        command.Parameters.AddWithValue("@Dateproduct", Dateproduct);
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
    }
}
