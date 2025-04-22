namespace Мастер_пола
{
    partial class Mainwin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поступлениеЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местоХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поступлениеМатериалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продукцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наименованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.sklad = new System.Windows.Forms.DataGridView();
            this.btnClosedata = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sklad)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.складToolStripMenuItem,
            this.продукцияToolStripMenuItem,
            this.материалыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(471, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.складаToolStripMenuItem,
            this.поступлениеЗаказаToolStripMenuItem,
            this.местоХраненияToolStripMenuItem,
            this.материалToolStripMenuItem,
            this.поступлениеМатериалаToolStripMenuItem});
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.складToolStripMenuItem.Text = "Склад";
            // 
            // складаToolStripMenuItem
            // 
            this.складаToolStripMenuItem.Name = "складаToolStripMenuItem";
            this.складаToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.складаToolStripMenuItem.Text = "№ ";
            this.складаToolStripMenuItem.Click += new System.EventHandler(this.складаToolStripMenuItem_Click);
            // 
            // поступлениеЗаказаToolStripMenuItem
            // 
            this.поступлениеЗаказаToolStripMenuItem.Name = "поступлениеЗаказаToolStripMenuItem";
            this.поступлениеЗаказаToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.поступлениеЗаказаToolStripMenuItem.Text = "Поступление продукции";
            this.поступлениеЗаказаToolStripMenuItem.Click += new System.EventHandler(this.поступлениеЗаказаToolStripMenuItem_Click);
            // 
            // местоХраненияToolStripMenuItem
            // 
            this.местоХраненияToolStripMenuItem.Name = "местоХраненияToolStripMenuItem";
            this.местоХраненияToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.местоХраненияToolStripMenuItem.Text = "Товар";
            this.местоХраненияToolStripMenuItem.Click += new System.EventHandler(this.местоХраненияToolStripMenuItem_Click);
            // 
            // материалToolStripMenuItem
            // 
            this.материалToolStripMenuItem.Name = "материалToolStripMenuItem";
            this.материалToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.материалToolStripMenuItem.Text = "Материал";
            // 
            // поступлениеМатериалаToolStripMenuItem
            // 
            this.поступлениеМатериалаToolStripMenuItem.Name = "поступлениеМатериалаToolStripMenuItem";
            this.поступлениеМатериалаToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.поступлениеМатериалаToolStripMenuItem.Text = "Поступление материала";
            // 
            // продукцияToolStripMenuItem
            // 
            this.продукцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наименованиеToolStripMenuItem});
            this.продукцияToolStripMenuItem.Name = "продукцияToolStripMenuItem";
            this.продукцияToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.продукцияToolStripMenuItem.Text = "Продукция";
            // 
            // наименованиеToolStripMenuItem
            // 
            this.наименованиеToolStripMenuItem.Name = "наименованиеToolStripMenuItem";
            this.наименованиеToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.наименованиеToolStripMenuItem.Text = "Наименование";
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоToolStripMenuItem});
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.материалыToolStripMenuItem.Text = "Материалы";
            // 
            // количествоToolStripMenuItem
            // 
            this.количествоToolStripMenuItem.Name = "количествоToolStripMenuItem";
            this.количествоToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.количествоToolStripMenuItem.Text = "Остаток";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(449, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sklad
            // 
            this.sklad.AllowUserToDeleteRows = false;
            this.sklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sklad.Location = new System.Drawing.Point(0, 31);
            this.sklad.Name = "sklad";
            this.sklad.ReadOnly = true;
            this.sklad.RowHeadersWidth = 51;
            this.sklad.RowTemplate.Height = 24;
            this.sklad.Size = new System.Drawing.Size(349, 150);
            this.sklad.TabIndex = 4;
            this.sklad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnClosedata
            // 
            this.btnClosedata.Location = new System.Drawing.Point(0, 362);
            this.btnClosedata.Name = "btnClosedata";
            this.btnClosedata.Size = new System.Drawing.Size(109, 52);
            this.btnClosedata.TabIndex = 5;
            this.btnClosedata.Text = "Закрыть";
            this.btnClosedata.UseVisualStyleBackColor = true;
            // 
            // Mainwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(471, 416);
            this.Controls.Add(this.btnClosedata);
            this.Controls.Add(this.sklad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainwin";
            this.Text = "Mainwin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sklad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поступлениеЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местоХраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поступлениеМатериалаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продукцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наименованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView sklad;
        private System.Windows.Forms.Button btnClosedata;
    }
}