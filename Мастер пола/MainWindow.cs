using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мастер_пола
{

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            sklad.Visible = false;
            btnClosedatagrid.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Point lastpoint;
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from Поставщики", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Тип", DataPropertyName = "Тип" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "CompanyName", HeaderText = "Наименование компании поставщика", DataPropertyName = "Наименование_компании_поставщика" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "INN", HeaderText = "ИНН", DataPropertyName = "ИНН" });

                            // Присваиваем DataTable как источник данных
                            sklad.DataSource = dataTable;

                            // Проверяем количество строк в DataTable
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

        }

        private void зарегистрироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void складаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void наименованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            sklad.Visible = false;
            btnClosedatagrid.Visible = false;
        }

        private void зарегистрироватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddUsers adusrs = new AddUsers();
            adusrs.Show();
            this.Hide();


        }

        private void поступлениеЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void местоХраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void аопраоиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUsers log = new LoginUsers();
            log.Show();
            this.Hide();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Место хранения материала", DataPropertyName = "Место_хранения_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Списание материалов со склада", DataPropertyName = "Списание_материалов_со_склада" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Поступление материала", DataPropertyName = "Поступление_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Место хранения материала", DataPropertyName = "Место_хранения_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Поступление продукции", DataPropertyName = "Поступление_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Вывоз продукции", DataPropertyName = "Вывоз_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Номер склада", DataPropertyName = "Номер_склада" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Название материала", DataPropertyName = "Название_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Название продукции", DataPropertyName = "Название_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Место хранения продукции", DataPropertyName = "Место_хранения_продукции" });
                            sklad.DataSource = dataTable;
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void материалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void типToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegOrder reg = new RegOrder();
            reg.Show();
            this.Hide();
        }

        private void поступлениеМатериалаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void складToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void списокToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void продукцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from Продукция", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

<<<<<<< HEAD
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name_product", HeaderText = "Название", DataPropertyName = "Наименование_продукции" });
=======
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Наименование продукции", DataPropertyName = "Наименование_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Стоимость", DataPropertyName = "Стоимость(рубль)" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Вес", DataPropertyName = "Вес(кг)" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Длина", DataPropertyName = "Длина(см)" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Ширина", DataPropertyName = "Ширина(см)" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Высота", DataPropertyName = "Высота(мм)" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Время_изготовления", DataPropertyName = "Время_изготовления(дни)" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Себестоимость", DataPropertyName = "Себестоимость(рубль)" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Сертификат_качества", DataPropertyName = "Сертификат_качества" });
                            sklad.DataSource = dataTable;
>>>>>>> 1000121212
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from Сотрудники", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

<<<<<<< HEAD
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Spisok", HeaderText = "Фаммилия", DataPropertyName = "Фамилия" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Spisok", HeaderText = "Имя", DataPropertyName = "Имя" });
=======
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Фамилия", DataPropertyName = "Фамилия" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Имя", DataPropertyName = "Имя" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Отчество", DataPropertyName = "Отчество" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Серия_паспорта", DataPropertyName = "Серия_паспорта" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Номер_паспорта", DataPropertyName = "Номер_паспорта" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Дата рождения", DataPropertyName = "Дата_рождения" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Номер_телефона", DataPropertyName = "Номер_телефона" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Почта", DataPropertyName = "Почта" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Пароль", DataPropertyName = "Пароль" });
                            sklad.DataSource = dataTable;
>>>>>>> 1000121212
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void партнерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from Партнеры", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();
<<<<<<< HEAD
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "dolgn", HeaderText = "Должность", DataPropertyName = "Наименование_должности" });
=======

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Наименование компаниия", DataPropertyName = "Наименование_компании" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Юридический адрес", DataPropertyName = "Юридический_адрес" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "ИНН", DataPropertyName = "ИНН" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Фамилия директора", DataPropertyName = "Фамилия_директора" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Имя_директора", DataPropertyName = "Имя_директора" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Отчество_директора", DataPropertyName = "Отчество_директора" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Номер_телефона", DataPropertyName = "Номер_телефона" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Почта", DataPropertyName = "Почта" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Пароль", DataPropertyName = "Пароль" });
                            sklad.DataSource = dataTable;
>>>>>>> 1000121212
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           
            sklad.Visible = false;
            btnClosedatagrid.Visible = false;
=======
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;

            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from Материалы", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Проверяем, есть ли данные
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                                return; // Выходим из метода, так как нет данных
                            }

                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            // Добавляем колонки
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Тип_материала", HeaderText = "Тип материала", DataPropertyName = "Тип_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование_материала", HeaderText = "Наименование материала", DataPropertyName = "Наименование_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Стоимость", HeaderText = "Стоимость", DataPropertyName = "Стоимость" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Поставщик", HeaderText = "Поставщик", DataPropertyName = "Поставщик" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Количество_на_складе", HeaderText = "Количество на складе", DataPropertyName = "Количество_на_складе" });

                            // Присваиваем DataTable как источник данных
                            sklad.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
>>>>>>> 1000121212
        }

        private void заявкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            AddUsers adusrs = new AddUsers();
            adusrs.Show();
            this.Hide();


        }

        private void поступлениеЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
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
            btnClosedatagrid.Visible = true;
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

        private void аопраоиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUsers log = new LoginUsers();
            log.Show();
            this.Hide();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void материалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Название_материала, Место_хранения_материала, Поступление_материала from Склад", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Наименование материала", DataPropertyName = "Название_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Место хранения материала", DataPropertyName = "Место_хранения_материала" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Datepost", HeaderText = "Дата поступления материала", DataPropertyName = "Поступление_материала" });
                            sklad.DataSource = dataTable;
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void типToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegOrder reg = new RegOrder();
            reg.Show();
            this.Hide();
        }

        private void поступлениеМатериалаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void складToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void списокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Наименование_компании from Партнеры", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Компании", DataPropertyName = "Наименование_компании" });
                            sklad.DataSource = dataTable;
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void списокToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select Тип_заявки, Наименование_продукции, Стоимость, Статус from Заявка", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Тип заявки", DataPropertyName = "Тип_заявки" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Наименование продукции", DataPropertyName = "Наименование_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Стоимость", DataPropertyName = "Стоимость" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Nameproduct", HeaderText = "Статус", DataPropertyName = "Статус" });
                            sklad.DataSource = dataTable;
                            sklad.DataSource = dataTable;
                            if (sklad.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
=======
            btnClosedatagrid.Visible = true;
            sklad.Visible = true;

            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=Glushak228;Database=Masterpola"))
                {
                    connect.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("select * from Заявка", connect))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Проверяем наличие данных
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("Заказы не найдены для данного клиента.");
                                return; // Выходим из метода, так как нет данных
                            }

                            sklad.AutoGenerateColumns = false;
                            sklad.Columns.Clear();

                            // Убедитесь, что имена колонок уникальны и соответствуют данным
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "PartnerEmail", HeaderText = "Почта партнера", DataPropertyName = "Почта_партнера" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "RequestType", HeaderText = "Тип заявки", DataPropertyName = "Тип_заявки" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ProductName", HeaderText = "Наименование продукции", DataPropertyName = "Наименование_продукции" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Cost", HeaderText = "Стоимость", DataPropertyName = "Стоимость" });
                            sklad.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "Статус", DataPropertyName = "Статус" });

                            // Присваиваем DataTable как источник данных
                            sklad.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
>>>>>>> 1000121212
    }
}
