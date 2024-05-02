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
            listBox1.Items.Clear();

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
            string helperString = " - Copy";

            //If the new file name already exists in the parent folder of the file-to-be-renamed, the string " - Copy" is added to the new name to differentiate it. Used a while loop for the (edge) case of there (e.g.) already existing both
            //a "Name.txt" and a "Name - Copy.txt" files inside the folder of the file the user wants to rename and he/she wants to rename a third, "Project.txt" file into "Name.txt". If I had used an if clause, the program would rename the
            //file "Name - Copy.txt" and crash. This way, it keeps adding " - Copy" until a valid filename can be created.
            while ((Directory.GetFiles(Path.GetDirectoryName(oldFilePath))).Contains(newFilePath))
            {
                newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, textBoxRenameFile.Text) + helperString + filenameExtension;

                helperString += " - Copy";
            }

            File.Move(oldFilePath, newFilePath);    //The actual renaming. We "move" the file elsewhere while providing a new name (it just happens we move it to the same place it was before...).

            listBox1.Items[listBox1.SelectedIndex] = newFilePath;        //The correct name is, now, displayed in the list box.
        }

        private void RenameManyFiles(ListBox.SelectedIndexCollection filesToRename) //While + το String.Concat χρειάζεται??
        {
            int numberOfFilesToRename = filesToRename.Count;        //After you rename a file, it is de-selected from the listbox, because of the line "listBox1.Items[filesToRename[i]] = newFilePath;", which displays the new, correct file
                                                                    //name. This causes the ListBox.SelectedIndexCollection filesToRename method parameter to lose one of its objects, so I save the parameter's number of objects in a
                                                                    //separate cariable, so that the for statement works correctly. (I was using "i < filesToRename.Count" before and the count was diminishing after each loop)
            int[] array = new int[numberOfFilesToRename];           //Created for the same reason as above. Program would crash.

            for (int i = 0; i < numberOfFilesToRename; i += 1)
                array[i] = filesToRename[i];

            string helperString = " - Copy";
            //int[] selectedFilesIndex = new int[filesToRename.Count];

            //for (int i = 0; i < filesToRename.Count; i += 1)    //Populating the int array.
            //    selectedFilesIndex[i] = filesToRename[i];

            for (int i = 0; i < numberOfFilesToRename; i += 1)
            {
                string oldFilePath = listBox1.Items[array[i]].ToString();                           //E.g., "D:\Docs\Personal\Notes_from_work.pdf". Selects the file with the specific index in the listbox.
                int backslashLastOccurrence = oldFilePath.LastIndexOf("\\");                        //The last occurrence of the backslash (\) in the path is where the file's name starts.            
                string filenameExtension = oldFilePath.Substring(oldFilePath.LastIndexOf("."));     //We isolate the filename extension (the last occurrence of the dot (.) in the path is where it starts).

                //We remove the old file's name from the original path, then insert the new name at the same position and add the filename extension, because the Remove method deletes everything starting from the position you supply up to
                //the string's end. We also cannot use the the Replace method, because it replaces all instances of the given parameter and we may end up changing the file's path, if it has the same name with the file itself (e.g.
                //"D:\Docs\Notes_from_work\Notes_from_work.pdf").
                string newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, textBoxRenameFile.Text) + filenameExtension;

                //If the new file name already exists in the parent folder of the file-to-be-renamed, the string " - Copy" is added to the new name to differentiate them.
                if ((Directory.GetFiles(Path.GetDirectoryName(oldFilePath))).Contains(newFilePath))
                {
                    newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, textBoxRenameFile.Text) + helperString + filenameExtension;

                    File.Move(oldFilePath, newFilePath);    //The actual renaming. We "move" the file elsewhere while providing a new name (it just happens we move it to the same place it was before...).

                    helperString = String.Concat(Enumerable.Repeat(" - Copy", i+2));
                }

                listBox1.Items[array[i]] = newFilePath;        //The correct name is, now, displayed in the list box. Used the "array" variable for the same reason stated in line /////////////////////////////108.
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1 && !string.IsNullOrWhiteSpace(textBoxRenameFile.Text))
                RenameFile();
            else
                RenameManyFiles(listBox1.SelectedIndices);      //Provides the method with each of the selected files' index, so that the correct files are renamed.

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
//Να μετονομάζει σε (1), (2) και για μερικό rename, αν τυχαίνει τα γύρω γύρω να είναι ίδια, οπότε θα είναι ίδια και τα τελικά ονόματα. + Να δουλεύει με Enter. +
//Όταν υπάρχει ήδη το αρχείο, σκάει. +  Για επόμενο push, διόρθωσα το όνομα που δίνει στο αρχείο όταν δίνεις σε πολλά αρχεία το ίδιο όνομα και έκανα να αδειάζει το list box όταν πατάς select.