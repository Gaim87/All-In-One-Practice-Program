
namespace All_In_One_Practice_Program
{
    partial class FileRenameForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRenameFile = new System.Windows.Forms.TextBox();
            this.textBoxPartialRenameOrigText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPartialRenameFinalText = new System.Windows.Forms.TextBox();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.renameButton = new System.Windows.Forms.Button();
            this.buttonPartiallyRename = new System.Windows.Forms.Button();
            this.labelWrongPartialRename = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSameFilenameGiven = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rename to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Partially rename:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select one or more files";
            // 
            // textBoxRenameFile
            // 
            this.textBoxRenameFile.Location = new System.Drawing.Point(895, 191);
            this.textBoxRenameFile.Name = "textBoxRenameFile";
            this.textBoxRenameFile.Size = new System.Drawing.Size(310, 22);
            this.textBoxRenameFile.TabIndex = 4;
            this.textBoxRenameFile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRenameFile_KeyUp);
            // 
            // textBoxPartialRenameOrigText
            // 
            this.textBoxPartialRenameOrigText.Location = new System.Drawing.Point(895, 296);
            this.textBoxPartialRenameOrigText.Name = "textBoxPartialRenameOrigText";
            this.textBoxPartialRenameOrigText.Size = new System.Drawing.Size(310, 22);
            this.textBoxPartialRenameOrigText.TabIndex = 5;
            this.textBoxPartialRenameOrigText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPartialRenameOrigText_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1022, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "to:";
            // 
            // textBoxPartialRenameFinalText
            // 
            this.textBoxPartialRenameFinalText.Location = new System.Drawing.Point(895, 406);
            this.textBoxPartialRenameFinalText.Name = "textBoxPartialRenameFinalText";
            this.textBoxPartialRenameFinalText.Size = new System.Drawing.Size(310, 22);
            this.textBoxPartialRenameFinalText.TabIndex = 7;
            this.textBoxPartialRenameFinalText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPartialRenameFinalText_KeyUp);
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseFile.Location = new System.Drawing.Point(895, 28);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(245, 83);
            this.buttonChooseFile.TabIndex = 8;
            this.buttonChooseFile.Text = "Choose file(s)";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(895, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 70);
            this.button2.TabIndex = 9;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(43, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(595, 404);
            this.listBox1.TabIndex = 10;
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(1236, 191);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(149, 23);
            this.renameButton.TabIndex = 11;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // buttonPartiallyRename
            // 
            this.buttonPartiallyRename.Location = new System.Drawing.Point(1236, 406);
            this.buttonPartiallyRename.Name = "buttonPartiallyRename";
            this.buttonPartiallyRename.Size = new System.Drawing.Size(149, 23);
            this.buttonPartiallyRename.TabIndex = 12;
            this.buttonPartiallyRename.Text = "Rename";
            this.buttonPartiallyRename.UseVisualStyleBackColor = true;
            this.buttonPartiallyRename.Click += new System.EventHandler(this.buttonPartiallyRename_Click);
            // 
            // labelWrongPartialRename
            // 
            this.labelWrongPartialRename.ForeColor = System.Drawing.Color.Red;
            this.labelWrongPartialRename.Location = new System.Drawing.Point(1178, 450);
            this.labelWrongPartialRename.Name = "labelWrongPartialRename";
            this.labelWrongPartialRename.Size = new System.Drawing.Size(207, 44);
            this.labelWrongPartialRename.TabIndex = 13;
            this.labelWrongPartialRename.Text = "The chosen file(s) does not contain the text you provided!";
            this.labelWrongPartialRename.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSameFilenameGiven
            // 
            this.labelSameFilenameGiven.AutoSize = true;
            this.labelSameFilenameGiven.ForeColor = System.Drawing.Color.Red;
            this.labelSameFilenameGiven.Location = new System.Drawing.Point(895, 233);
            this.labelSameFilenameGiven.MaximumSize = new System.Drawing.Size(310, 0);
            this.labelSameFilenameGiven.Name = "labelSameFilenameGiven";
            this.labelSameFilenameGiven.Size = new System.Drawing.Size(233, 17);
            this.labelSameFilenameGiven.TabIndex = 14;
            this.labelSameFilenameGiven.Text = "The selected file is already named \"";
            this.labelSameFilenameGiven.Visible = false;
            // 
            // FileRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 637);
            this.Controls.Add(this.labelSameFilenameGiven);
            this.Controls.Add(this.labelWrongPartialRename);
            this.Controls.Add(this.buttonPartiallyRename);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.textBoxPartialRenameFinalText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPartialRenameOrigText);
            this.Controls.Add(this.textBoxRenameFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FileRenameForm";
            this.Text = "FileRenameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRenameFile;
        private System.Windows.Forms.TextBox textBoxPartialRenameOrigText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPartialRenameFinalText;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button buttonPartiallyRename;
        private System.Windows.Forms.Label labelWrongPartialRename;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSameFilenameGiven;
    }
}