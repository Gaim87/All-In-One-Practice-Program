﻿
namespace All_In_One_Practice_Program
{
    partial class TextReplaceWindow
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTextToBeReplaced = new System.Windows.Forms.TextBox();
            this.textBoxReplacementText = new System.Windows.Forms.TextBox();
            this.buttonReplaceText = new System.Windows.Forms.Button();
            this.buttonQuitThis = new System.Windows.Forms.Button();
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.buttonFindPrevious = new System.Windows.Forms.Button();
            this.buttonQuitBoth = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replace:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "With:";
            // 
            // textBoxTextToBeReplaced
            // 
            this.textBoxTextToBeReplaced.Location = new System.Drawing.Point(215, 79);
            this.textBoxTextToBeReplaced.Name = "textBoxTextToBeReplaced";
            this.textBoxTextToBeReplaced.Size = new System.Drawing.Size(546, 22);
            this.textBoxTextToBeReplaced.TabIndex = 2;
            this.textBoxTextToBeReplaced.TextChanged += new System.EventHandler(this.textBoxTextToBeReplaced_TextChanged);
            this.textBoxTextToBeReplaced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTextToBeReplaced_KeyPress);
            // 
            // textBoxReplacementText
            // 
            this.textBoxReplacementText.Location = new System.Drawing.Point(215, 240);
            this.textBoxReplacementText.Name = "textBoxReplacementText";
            this.textBoxReplacementText.Size = new System.Drawing.Size(546, 22);
            this.textBoxReplacementText.TabIndex = 3;
            // 
            // buttonReplaceText
            // 
            this.buttonReplaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplaceText.Location = new System.Drawing.Point(90, 358);
            this.buttonReplaceText.Name = "buttonReplaceText";
            this.buttonReplaceText.Size = new System.Drawing.Size(137, 49);
            this.buttonReplaceText.TabIndex = 4;
            this.buttonReplaceText.Text = "Replace";
            this.buttonReplaceText.UseVisualStyleBackColor = true;
            this.buttonReplaceText.Click += new System.EventHandler(this.buttonReplaceText_Click);
            // 
            // buttonQuitThis
            // 
            this.buttonQuitThis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuitThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitThis.Location = new System.Drawing.Point(499, 342);
            this.buttonQuitThis.Name = "buttonQuitThis";
            this.buttonQuitThis.Size = new System.Drawing.Size(192, 80);
            this.buttonQuitThis.TabIndex = 5;
            this.buttonQuitThis.Text = "Quit This Program";
            this.buttonQuitThis.UseVisualStyleBackColor = true;
            // 
            // buttonFindNext
            // 
            this.buttonFindNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindNext.Location = new System.Drawing.Point(215, 118);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(117, 45);
            this.buttonFindNext.TabIndex = 6;
            this.buttonFindNext.Text = "Find Next";
            this.buttonFindNext.UseVisualStyleBackColor = true;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNextWord_Click);
            // 
            // buttonReplaceAll
            // 
            this.buttonReplaceAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplaceAll.Location = new System.Drawing.Point(269, 358);
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.Size = new System.Drawing.Size(197, 49);
            this.buttonReplaceAll.TabIndex = 7;
            this.buttonReplaceAll.Text = "Replace All";
            this.buttonReplaceAll.UseVisualStyleBackColor = true;
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            // 
            // buttonFindPrevious
            // 
            this.buttonFindPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindPrevious.Location = new System.Drawing.Point(373, 118);
            this.buttonFindPrevious.Name = "buttonFindPrevious";
            this.buttonFindPrevious.Size = new System.Drawing.Size(167, 45);
            this.buttonFindPrevious.TabIndex = 8;
            this.buttonFindPrevious.Text = "Find Previous";
            this.buttonFindPrevious.UseVisualStyleBackColor = true;
            this.buttonFindPrevious.Click += new System.EventHandler(this.buttonFindPrevious_Click);
            // 
            // buttonQuitBoth
            // 
            this.buttonQuitBoth.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuitBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.buttonQuitBoth.Location = new System.Drawing.Point(720, 342);
            this.buttonQuitBoth.Name = "buttonQuitBoth";
            this.buttonQuitBoth.Size = new System.Drawing.Size(192, 80);
            this.buttonQuitBoth.TabIndex = 9;
            this.buttonQuitBoth.Text = "Quit Both Programs";
            this.buttonQuitBoth.UseVisualStyleBackColor = true;
            this.buttonQuitBoth.Click += new System.EventHandler(this.buttonQuitBoth_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::All_In_One_Practice_Program.Properties.Resources.check_mark;
            this.pictureBox1.Location = new System.Drawing.Point(428, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // TextReplaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonQuitBoth);
            this.Controls.Add(this.buttonFindPrevious);
            this.Controls.Add(this.buttonReplaceAll);
            this.Controls.Add(this.buttonFindNext);
            this.Controls.Add(this.buttonQuitThis);
            this.Controls.Add(this.buttonReplaceText);
            this.Controls.Add(this.textBoxReplacementText);
            this.Controls.Add(this.textBoxTextToBeReplaced);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TextReplaceWindow";
            this.Text = "Replace Word Text";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTextToBeReplaced;
        private System.Windows.Forms.TextBox textBoxReplacementText;
        private System.Windows.Forms.Button buttonReplaceText;
        private System.Windows.Forms.Button buttonQuitThis;
        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.Button buttonReplaceAll;
        private System.Windows.Forms.Button buttonFindPrevious;
        private System.Windows.Forms.Button buttonQuitBoth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}