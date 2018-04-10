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
            this.btnTan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(205, 312);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(130, 69);
            this.btnTan.TabIndex = 0;
            this.btnTan.Text = "TAN";
            this.btnTan.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 473);
            this.Controls.Add(this.btnTan);
            this.Name = "Product";
            this.Text = "Product";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTan;
    }
}