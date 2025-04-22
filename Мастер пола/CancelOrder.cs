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
    public partial class CancelOrder : Form
    {
        public CancelOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastpoint = new Point();
        private void CancelOrder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void CancelOrder_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Mail = txtMail.Text;

            if (string.IsNullOrWhiteSpace(Mail))
            {
                MessageBox.Show("Укажите почту");
                return;
            }
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT Тип_заявки, Наименование_продукции, Стоимость, Статус FROM Заявка WHERE Почта_партнера = @mail", connection))
                    {
                        command.Parameters.AddWithValue("@mail", Mail); // Привязка параметра

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                            // Очищаем старые колонки, если они есть
                            dataGridView1.Columns.Clear();

                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Type", HeaderText = "Тип заявки", DataPropertyName = "Тип_заявки" });
                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameprod", HeaderText = "Наименование продукции", DataPropertyName = "Наименование_продукции" });
                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Price", HeaderText = "Стоимость", DataPropertyName = "Стоимость" });
                            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "Статус", DataPropertyName = "Статус" });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    string Tyri = dataGridView1.Rows[selectedRowIndex].Cells["Type"].Value?.ToString();

                    if (string.IsNullOrEmpty(Tyri))
                    {
                        MessageBox.Show("Тип не может быть пустым.");
                        return;
                    }

                    string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola";

                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "DELETE FROM Заявка WHERE Тип_заявки = @type";
                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@type", Tyri);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Запись успешно удалена");
                                dataGridView1.Rows.RemoveAt(selectedRowIndex);
                            }
                            else
                            {
                                MessageBox.Show("Запись не найдена");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления");
            }
        }
    }
}

