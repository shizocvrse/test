namespace Мастер_пола
{
    partial class PartWins
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
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.каталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьКатологToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отказатьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(778, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каталогToolStripMenuItem,
            this.заявкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // каталогToolStripMenuItem
            // 
            this.каталогToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьКатологToolStripMenuItem});
            this.каталогToolStripMenuItem.Name = "каталогToolStripMenuItem";
            this.каталогToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.каталогToolStripMenuItem.Text = "Каталог";
            // 
            // посмотретьКатологToolStripMenuItem
            // 
            this.посмотретьКатологToolStripMenuItem.Name = "посмотретьКатологToolStripMenuItem";
            this.посмотретьКатологToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.посмотретьКатологToolStripMenuItem.Text = "Посмотреть католог";
            // 
            // заявкаToolStripMenuItem
            // 
            this.заявкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оформитьToolStripMenuItem,
            this.отказатьсяToolStripMenuItem});
            this.заявкаToolStripMenuItem.Name = "заявкаToolStripMenuItem";
            this.заявкаToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.заявкаToolStripMenuItem.Text = "Заявка";
            this.заявкаToolStripMenuItem.Click += new System.EventHandler(this.заявкаToolStripMenuItem_Click);
            // 
            // оформитьToolStripMenuItem
            // 
            this.оформитьToolStripMenuItem.Name = "оформитьToolStripMenuItem";
            this.оформитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оформитьToolStripMenuItem.Text = "Оформить";
            this.оформитьToolStripMenuItem.Click += new System.EventHandler(this.оформитьToolStripMenuItem_Click);
            // 
            // отказатьсяToolStripMenuItem
            // 
            this.отказатьсяToolStripMenuItem.Name = "отказатьсяToolStripMenuItem";
            this.отказатьсяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отказатьсяToolStripMenuItem.Text = "Отказаться";
            this.отказатьсяToolStripMenuItem.Click += new System.EventHandler(this.отказатьсяToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 406);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PartWins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PartWins";
            this.Text = "PartWins";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartWins_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PartWins_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem каталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьКатологToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отказатьсяToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}