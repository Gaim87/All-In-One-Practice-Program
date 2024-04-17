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
            string oldFilePath = listBox1.SelectedItem.ToString();                              //E.g., "D:\Docs\Personal\Notes_from_work.pdf"
            int backslashLastOccurrence = oldFilePath.LastIndexOf("\\");                        //The last occurrence of the backslash (\) in the path is where the file's name starts.            
            string filenameExtension = oldFilePath.Substring(oldFilePath.LastIndexOf("."));     //We isolate the filename extension (the last occurrence of the dot (.) in the path is where it starts).

            //We remove the old file's name from the original path, then insert the new name at the same position and add the filename extension, because the Remove method deletes everything starting from the position you supply up to
            //the string's end. We also cannot use the the Replace method, because it replaces all instances of the given parameter and we may end up changing the file's path, if it has the same name with the file itself (e.g.
            //"D:\Docs\Notes_from_work\Notes_from_work.pdf").
            string newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, textBoxRenameFile.Text) + filenameExtension;

            File.Move(oldFilePath, newFilePath);    //The actual renaming. We "move" the file elsewhere while providing a new name (it just happens we move it to the same place it was before...).

            listBox1.Items[listBox1.SelectedIndex] = newFilePath;        //The correct name is, now, displayed in the list box.
        }

        private void RenameFile(int selectedFileIndex, int helperInt)
        {
            string oldFilePath = listBox1.Items[selectedFileIndex].ToString();                              //E.g., "D:\Docs\Personal\Notes_from_work.pdf"
            int backslashLastOccurrence = oldFilePath.LastIndexOf("\\");                        //The last occurrence of the backslash (\) in the path is where the file's name starts.            
            string filenameExtension = oldFilePath.Substring(oldFilePath.LastIndexOf("."));     //We isolate the filename extension (the last occurrence of the dot (.) in the path is where it starts).
            string newFilePath = "";

            //We remove the old file's name from the original path, then insert the new name at the same position and add the filename extension, because the Remove method deletes everything starting from the position you supply up to
            //the string's end. We also cannot use the the Replace method, because it replaces all instances of the given parameter and we may end up changing the file's path, if it has the same name with the file itself (e.g.
            //"D:\Docs\Notes_from_work\Notes_from_work.pdf").
            if (helperInt != 0)
                newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, textBoxRenameFile.Text) + helperInt + filenameExtension;
            else
                newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, textBoxRenameFile.Text) + filenameExtension;

            File.Move(oldFilePath, newFilePath);    //The actual renaming. We "move" the file elsewhere while providing a new name (it just happens we move it to the same place it was before...).

            listBox1.Items[selectedFileIndex] = newFilePath;        //The correct name is, now, displayed in the list box.
        }

        private void RenameManyFiles(ListBox.SelectedIndexCollection filesToRename)
        {
            int[] selectedFilesIndex = new int[filesToRename.Count];

            for (int i = 0; i < filesToRename.Count; i += 1)
                selectedFilesIndex[i] = filesToRename[i];

            int numberOfFilesToRename = selectedFilesIndex.Length;

            for (int i = 0; i < numberOfFilesToRename; i += 1)
                RenameFile(selectedFilesIndex[i], i);
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1 && !string.IsNullOrWhiteSpace(textBoxRenameFile.Text))
                RenameFile();
            else
                RenameManyFiles(listBox1.SelectedIndices);

            textBoxRenameFile.Clear();
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                toolTip1.SetToolTip(listBox1, listBox1.SelectedItem.ToString());    //Sets a tool tip that shows the selected file's name. Useful when the path is long and cannot be displayed in its entirety.
                                                                                    //It shows the currently selected file's name no matter where you hover inside the list box.
        }
    }
}
//Με if για partially. Να μετονομάζει σε (1), (2), αν διαλέξεις πολλά και κάνεις κανονικά rename και να κάνει το ίδιο, αν διαλέξεις πολλά για μερικό rename και τυχαίνει τα γύρω γύρω να είναι ίδια, οπότε θα είναι ίδια και τα τελικά
//ονόματα. + Να δουλεύει με Enter. + Όταν ξαναπατάω το select files, να αδειάζει το list box.