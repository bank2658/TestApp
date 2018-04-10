namespace App
{
    partial class Product
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
            this.btnBank = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.cbmTAN = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTAN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(160, 21);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(238, 177);
            this.btnBank.TabIndex = 0;
            this.btnBank.Text = "bank";
            this.btnBank.UseVisualStyleBackColor = true;
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(202, 314);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(130, 69);
            this.btnTan.TabIndex = 0;
            this.btnTan.Text = "TAN";
            this.btnTan.UseVisualStyleBackColor = true;
            // 
            // cbmTAN
            // 
            this.cbmTAN.FormattingEnabled = true;
            this.cbmTAN.Location = new System.Drawing.Point(28, 422);
            this.cbmTAN.Name = "cbmTAN";
            this.cbmTAN.Size = new System.Drawing.Size(121, 21);
            this.cbmTAN.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblTAN
            // 
            this.lblTAN.AutoSize = true;
            this.lblTAN.Location = new System.Drawing.Point(41, 237);
            this.lblTAN.Name = "lblTAN";
            this.lblTAN.Size = new System.Drawing.Size(35, 13);
            this.lblTAN.TabIndex = 2;
            this.lblTAN.Text = "label1";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 473);
            this.Controls.Add(this.lblTAN);
            this.Controls.Add(this.cbmTAN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.btnTan);
            this.Name = "Product";
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTan;

        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbmTAN;
        private System.Windows.Forms.Label lblTAN;
    }
}