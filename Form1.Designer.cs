﻿
namespace All_In_One_Practice_Program
{
    partial class Form1
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
            this.buttonReplaceWordText = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonReplaceWordText
            // 
            this.buttonReplaceWordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplaceWordText.Location = new System.Drawing.Point(60, 104);
            this.buttonReplaceWordText.Name = "buttonReplaceWordText";
            this.buttonReplaceWordText.Size = new System.Drawing.Size(169, 63);
            this.buttonReplaceWordText.TabIndex = 0;
            this.buttonReplaceWordText.Text = "Replace Word text";
            this.buttonReplaceWordText.UseVisualStyleBackColor = true;
            this.buttonReplaceWordText.Click += new System.EventHandler(this.buttonReplaceWordText_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReplaceWordText);
            this.Name = "Form1";
            this.Text = "Various Utilities Practice Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReplaceWordText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

