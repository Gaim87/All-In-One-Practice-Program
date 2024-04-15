using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_In_One_Practice_Program
{
    public partial class FileRenameForm : Form
    {
        public FileRenameForm()
        {
            InitializeComponent();
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)                        //If the user selected any files.
                try
                {
                    string[] selectedFiles = openFileDialog1.FileNames;                 //The name of the file(s) the user selected.
                                                                                        //...
                    for (int i = 0; i < selectedFiles.Length; i += 1)                   //is added to the list box.
                        listBox1.Items.Add(selectedFiles[i]);

                    listBox1.Invalidate();

                    if (selectedFiles.Length == 1)                                      //If the user selected only one file, it is automatically selected in the list box.
                        listBox1.SelectedItem = listBox1.Items[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                                        //Displays a modal box about the cause of the exception/error.
                }
        }

        private void RenameFile()
        {
            string oldFilePath = listBox1.SelectedItem.ToString();                          //E.g., "D:\Docs\Personal\Notes_from_work.pdf"
            int backslashLastOccurrence = oldFilePath.LastIndexOf("\\");                    //The last occurrence of the backslash (\) in the path is where the file's name starts.
            int dotLastOccurrence = oldFilePath.LastIndexOf(".");                           //The last occurrence of the dot (.) in the path is where the filename extension starts.

            string oldFileName = oldFilePath.Substring(backslashLastOccurrence + 1);        //+ 1 because we don't want to include the backslash.
            string filenameExtension = oldFilePath.Substring(dotLastOccurrence);            //This time, we want to include the dot.
            string newFileName = oldFileName.Replace(oldFileName, textBoxRenameFile.Text);  //I don't rename the file using the variable for the whole path ("oldFilePath"), because the file's name may be identical to a preceding folder's
                                                                                            //name, e.g. "D:\Docs\Notes_from_work\Notes_from_work.pdf", and in this case, the .Replace method will replace all instances of the given string
                                                                                            //(including the folder) and we will end up changing the file's path.

            //We remove the old file's name from the original path, then insert the new name at the same position and add the filename extension, because the Remove method deletes everything starting from the position you supply up to
            //the string's end.
            string newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, newFileName) + filenameExtension;

            File.Move(oldFilePath, newFilePath);    //The actual renaming. We "move" the file elsewhere while providing a new name (it just happens we move it to the same place it was before...).

            listBox1.Items[0] = newFilePath;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1)
                RenameFile();
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                toolTip1.SetToolTip(listBox1, listBox1.SelectedItem.ToString());    //Sets a tool tip that shows the selected file's name. Useful when the path or the file's name are longer than the list box's margins.
                                                                                    //It shows the selected file's name no matter where you hover inside the list box.
        }
    }
}
//Με if για partially. Να μετονομάζει σε (1), (2), αν διαλέξεις πολλά και κάνεις κανονικά rename και να κάνει το ίδιο, αν διαλέξεις πολλά για μερικό rename και τυχαίνει τα γύρω γύρω να είναι ίδια, οπότε θα είναι ίδια και τα τελικά
//ονόματα.