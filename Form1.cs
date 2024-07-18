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

                    textReplaceWindow.WordApp = wordApplication;
                    textReplaceWindow.DocumentContents = rng;

                    this.Hide();
                    textReplaceWindow.ShowDialog();
                    textReplaceWindow.Focus();

                    if (textReplaceWindow.DialogResult == DialogResult.Cancel)      //If the user quits/closes the program.
                    {
                        this.Show();
                        textReplaceWindow.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }   //Tried making it work with an already open document, but did not succeed.

        private void buttonRenameFiles_Click(object sender, EventArgs e)        //The button that opens the program for renaming files.
        {
            FileRenameForm fileRenameForm = new FileRenameForm();

            this.Hide();
            fileRenameForm.ShowDialog();

            if (fileRenameForm.DialogResult == DialogResult.Cancel)             //If the user quits/closes the program.
            {
                this.Show();
                fileRenameForm.Dispose();
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFindDuplicateFiles_Click(object sender, EventArgs e)
        {
            FindDuplicateFiles findDuplicateFiles = new FindDuplicateFiles();

            this.Hide();
            findDuplicateFiles.ShowDialog();

            if (findDuplicateFiles.DialogResult == DialogResult.Cancel)             //If the user quits/closes the program.
            {
                this.Show();
                findDuplicateFiles.Dispose();
            }
        }
    }
}//Στον έναν πίνακα αποθηκεύω το όνομα και στον άλλον τα byte. Ξεκινάω να συγκρίνω το 1ο με όλα τα από κάτω, το 2ο με όλα τα από κάτω κοκ. Έχω for και αν δεν είναι ίδια τα byte, γίνεται break, αλλιώς έχω μετά το break την εντολή για
 //αποθήκευση του ονόματος του αρχείου στον 2ο πίνακα.
 //Σε περίπτωση που το 1ο είναι ίδιο με το 3ο και το 7ο (να το γράψω ως σχόλιο), να έχω if, για να ψάχνει μήπως το όνομα του αρχείου είναι ήδη γραμμένο, ώστε να μην ξεκινάει καθόλου τη σύγκριση ή να σβήνεται το
 //όνομα του αρχείου από τη λίστα με τα ατχεία για σύγκριση. Να βάζω το νούμερο του αρχείου (π.χ., αν είναι το 1ο, το "1") μπροστά από το όνομα (στον 2ο πίνακα), ώστε να ξέρω ποιο αρχείο είναι το ίδιο με ποιο (και να κάνω τσεκ με
 //ομάδες ίδιων αρχείων στον ίδιο φάκελο).