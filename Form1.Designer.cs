
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
            this.buttonRenameFiles = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonFindDuplicateFiles = new System.Windows.Forms.Button();
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
            // buttonRenameFiles
            // 
            this.buttonRenameFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRenameFiles.Location = new System.Drawing.Point(266, 105);
            this.buttonRenameFiles.Name = "buttonRenameFiles";
            this.buttonRenameFiles.Size = new System.Drawing.Size(169, 62);
            this.buttonRenameFiles.TabIndex = 1;
            this.buttonRenameFiles.Text = "Rename files";
            this.buttonRenameFiles.UseVisualStyleBackColor = true;
            this.buttonRenameFiles.Click += new System.EventHandler(this.buttonRenameFiles_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(570, 366);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(178, 53);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonFindDuplicateFiles
            // 
            this.buttonFindDuplicateFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindDuplicateFiles.Location = new System.Drawing.Point(472, 104);
            this.buttonFindDuplicateFiles.Name = "buttonFindDuplicateFiles";
            this.buttonFindDuplicateFiles.Size = new System.Drawing.Size(169, 62);
            this.buttonFindDuplicateFiles.TabIndex = 3;
            this.buttonFindDuplicateFiles.Text = "Find duplicate files";
            this.buttonFindDuplicateFiles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFindDuplicateFiles);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonRenameFiles);
            this.Controls.Add(this.buttonReplaceWordText);
            this.Name = "Form1";
            this.Text = "Various Utilities Practice Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReplaceWordText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRenameFiles;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonFindDuplicateFiles;
    }
}

