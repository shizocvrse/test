namespace Мастер_пола
{
    partial class RegOrder
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
            this.btnCLose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDataproduct = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCLose
            // 
            this.btnCLose.FlatAppearance.BorderSize = 0;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.ForeColor = System.Drawing.Color.Red;
            this.btnCLose.Location = new System.Drawing.Point(646, 1);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(22, 23);
            this.btnCLose.TabIndex = 0;
            this.btnCLose.Text = "X";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(262, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заявка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название продукции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 55);
            this.label5.TabIndex = 6;
            this.label5.Text = "Сроки изготовления";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.LightGray;
            this.txtType.Location = new System.Drawing.Point(159, 122);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(244, 22);
            this.txtType.TabIndex = 7;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BackColor = System.Drawing.Color.LightGray;
            this.txtNameProduct.Location = new System.Drawing.Point(254, 177);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(244, 22);
            this.txtNameProduct.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.LightGray;
            this.txtPrice.Location = new System.Drawing.Point(168, 244);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(244, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // txtDataproduct
            // 
            this.txtDataproduct.BackColor = System.Drawing.Color.LightGray;
            this.txtDataproduct.Location = new System.Drawing.Point(254, 314);
            this.txtDataproduct.Name = "txtDataproduct";
            this.txtDataproduct.Size = new System.Drawing.Size(244, 22);
            this.txtDataproduct.TabIndex = 10;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(249, 505);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(154, 52);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "Оформить";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // RegOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(669, 569);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtDataproduct);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCLose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegOrder";
            this.Text = "RegOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDataproduct;
        private System.Windows.Forms.Button btnReg;
    }
}