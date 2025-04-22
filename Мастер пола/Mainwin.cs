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
    public partial class Mainwin : Form
    {
        public Mainwin()
        {
            InitializeComponent();
            btnClosedata.Visible = false;
        }

        private void складаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedata.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Номер_склада from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Number", HeaderText = "Номер", DataPropertyName = "Номер_склада" });
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void поступлениеЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedata.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Название_продукции, Поступление_продукции from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Название продукции", DataPropertyName = "Название_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datapost", HeaderText = "Дата поступления", DataPropertyName = "Поступление_продукции" });
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void местоХраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedata.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Название_продукции, Место_хранения_продукции from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Название продукции", DataPropertyName = "Название_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datapost", HeaderText = "Место хранения продукции", DataPropertyName = "Место_хранения_продукции" });
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
