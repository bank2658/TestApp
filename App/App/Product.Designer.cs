﻿namespace App
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
            this.SuspendLayout();
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(113, 51);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(238, 177);
            this.btnBank.TabIndex = 0;
            this.btnBank.Text = "bank";
            this.btnBank.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.btnTan);
            this.Name = "Product";
            this.Text = "Product";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTan;

        private System.Windows.Forms.Button btnBank;
    }
}