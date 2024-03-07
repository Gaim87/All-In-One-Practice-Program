
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTextToBeReplaced = new System.Windows.Forms.TextBox();
            this.textBoxReplacementText = new System.Windows.Forms.TextBox();
            this.buttonReplaceText = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFindPrevious = new System.Windows.Forms.Button();
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
            this.buttonReplaceText.Location = new System.Drawing.Point(215, 367);
            this.buttonReplaceText.Name = "buttonReplaceText";
            this.buttonReplaceText.Size = new System.Drawing.Size(137, 49);
            this.buttonReplaceText.TabIndex = 4;
            this.buttonReplaceText.Text = "Replace";
            this.buttonReplaceText.UseVisualStyleBackColor = true;
            this.buttonReplaceText.Click += new System.EventHandler(this.buttonReplaceText_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(649, 367);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(112, 49);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(394, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Replace All";
            this.button1.UseVisualStyleBackColor = true;
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
            // TextReplaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.buttonFindPrevious);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFindNext);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonReplaceText);
            this.Controls.Add(this.textBoxReplacementText);
            this.Controls.Add(this.textBoxTextToBeReplaced);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TextReplaceWindow";
            this.Text = "Replace Word Text";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTextToBeReplaced;
        private System.Windows.Forms.TextBox textBoxReplacementText;
        private System.Windows.Forms.Button buttonReplaceText;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFindPrevious;
    }
}