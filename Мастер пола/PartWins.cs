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
    public partial class PartWins : Form
    {
        public PartWins()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void заявкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оформитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegOrder reg = new RegOrder();
            reg.Show();
            this.Close();
        }

        
        Point lastpoint = new Point();
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

        private void PartWins_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void PartWins_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void отказатьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder galyaotmena = new CancelOrder();
            galyaotmena.Show();
            
        }
    }
}
