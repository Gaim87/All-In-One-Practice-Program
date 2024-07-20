
namespace All_In_One_Practice_Program
{
    partial class FindDuplicateFiles
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
            this.buttonFindDuplicates = new System.Windows.Forms.Button();
            this.buttonChooseFiles = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFindDuplicates
            // 
            this.buttonFindDuplicates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindDuplicates.Location = new System.Drawing.Point(347, 48);
            this.buttonFindDuplicates.Name = "buttonFindDuplicates";
            this.buttonFindDuplicates.Size = new System.Drawing.Size(225, 92);
            this.buttonFindDuplicates.TabIndex = 0;
            this.buttonFindDuplicates.Text = "Find duplicate files";
            this.buttonFindDuplicates.UseVisualStyleBackColor = true;
            // 
            // buttonChooseFiles
            // 
            this.buttonChooseFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseFiles.Location = new System.Drawing.Point(43, 48);
            this.buttonChooseFiles.Name = "buttonChooseFiles";
            this.buttonChooseFiles.Size = new System.Drawing.Size(225, 92);
            this.buttonChooseFiles.TabIndex = 1;
            this.buttonChooseFiles.Text = "Choose files";
            this.buttonChooseFiles.UseVisualStyleBackColor = true;
            this.buttonChooseFiles.Click += new System.EventHandler(this.buttonChooseFiles_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(38, 237);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1568, 564);
            this.listBox1.TabIndex = 2;
            // 
            // buttonQuit
            // 
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(651, 48);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(225, 92);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            // 
            // FindDuplicateFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 876);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonChooseFiles);
            this.Controls.Add(this.buttonFindDuplicates);
            this.Name = "FindDuplicateFiles";
            this.Text = "FindDuplicateFiles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindDuplicates;
        private System.Windows.Forms.Button buttonChooseFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonQuit;
    }
}