using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace All_In_One_Practice_Program
{
    public partial class Form1 : Form       //The program's main window.
    {    
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReplaceWordText_Click(object sender, EventArgs e)    //The button that opens the program for replacing words in a Word document.
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)            //openFileDialog1 is the name of the control for opening a file from storage.
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    Microsoft.Office.Interop.Word.Application wordApplication = new Microsoft.Office.Interop.Word.Application();
                    Document selectedDocument = new Document();

                    wordApplication.Visible = true;

                    selectedDocument = wordApplication.Documents.Open(filePath);

                    Range rng = selectedDocument.Content;
                    TextReplaceWindow textReplaceWindow = new TextReplaceWindow();      //A new, second form/window for performing the actual word replacement.

                    textReplaceWindow.wordApp = wordApplication;

                    this.Hide();
                    textReplaceWindow.ShowDialog();
                    textReplaceWindow.Focus();

                    if (textReplaceWindow.DialogResult == DialogResult.Cancel)      //If the user quits/closes the program.
                        this.ShowDialog();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }   //Tried making it work with an already open document, but did not succeed.
    }
}