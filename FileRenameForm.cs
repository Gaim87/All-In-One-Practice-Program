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

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                toolTip1.SetToolTip(listBox1, listBox1.SelectedItem.ToString());    //Sets a tool tip that shows the selected file's name. Useful when the path is long and cannot be displayed in its entirety.
                                                                                    //It shows the currently selected file's name no matter where you hover inside the list box.
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1 && !string.IsNullOrWhiteSpace(textBoxRenameFile.Text))
                RenameFile();
            else if (listBox1.SelectedIndices.Count > 1 && !string.IsNullOrWhiteSpace(textBoxRenameFile.Text))
                RenameManyFiles(listBox1.SelectedIndices);      //Provides the method with each of the selected files' index, so that the correct files are renamed.
        }

        private void textBoxRenameFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && listBox1.SelectedIndices.Count == 1 && !string.IsNullOrWhiteSpace(textBoxRenameFile.Text))
                RenameFile();
            else if (e.KeyCode.Equals(Keys.Enter) && listBox1.SelectedIndices.Count > 1 && !string.IsNullOrWhiteSpace(textBoxRenameFile.Text))
                RenameManyFiles(listBox1.SelectedIndices);
        }

        private void RenameFile()
        {
            string oldFilePath = listBox1.SelectedItem.ToString();                              //E.g., "D:\Docs\Personal\Notes_from_work.pdf"
            int backslashLastOccurrence = oldFilePath.LastIndexOf("\\");                        //The last occurrence of the backslash (\) in the path is where the file's name starts.            
            string filenameExtension = oldFilePath.Substring(oldFilePath.LastIndexOf("."));     //We isolate the filename extension (the last occurrence of the dot (.) in the path is where it starts).

            //We remove the old file's name from the original path, then insert the new name at the same position and add the filename extension, because the Remove method deletes everything starting from the position you supply up to
            //the string's end, unless I create another variable with the file's name, calculate its length and use the method's overload.
            //We also cannot use the the Replace method, because it replaces all instances of the given parameter and we may end up changing the file's path, if it has the same name with the file itself (e.g.
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
            textBoxRenameFile.Clear();
        }

        private void RenameManyFiles(ListBox.SelectedIndexCollection filesToRename)
        {
            int numberOfFilesToRename = filesToRename.Count;        //After you rename a file, it is de-selected from the listbox, because of the line "listBox1.Items[selectedListboxIndices[i]] = newFilePath", which displays the new,
                                                                    //correct file name. This causes the ListBox.SelectedIndexCollection filesToRename method parameter to lose one of its objects, so I save the parameter's initial
                                                                    //number of objects in aseparate variable, so that the for statement works correctly. (I was using "i < filesToRename.Count" before and the count was diminishing after each
                                                                    //loop)
            int[] selectedListboxIndices = new int[numberOfFilesToRename];           //Created for the same reason as above. Program would crash.

            for (int i = 0; i < numberOfFilesToRename; i += 1)
                selectedListboxIndices[i] = filesToRename[i];

            string helperString = " - Copy";

            for (int i = 0; i < numberOfFilesToRename; i += 1)
            {
                string oldFilePath = listBox1.Items[selectedListboxIndices[i]].ToString();          //E.g., "D:\Docs\Personal\Notes_from_work.pdf". Selects the file with the specific index in the listbox.
                int backslashLastOccurrence = oldFilePath.LastIndexOf("\\");                        //The last occurrence of the backslash (\) in the path is where the file's name starts.            
                string filenameExtension = oldFilePath.Substring(oldFilePath.LastIndexOf("."));     //We isolate the filename extension (the last occurrence of the dot (.) in the path is where it starts).

                //We remove the old file's name from the original path, then insert the new name at the same position and add the filename extension, because the Remove method deletes everything starting from the position you supply up to
                //the string's end, unless I create another variable with the file's name, calculate its length and use the method's overload.
                //We also cannot use the the Replace method, because it replaces all instances of the given parameter and we may end up changing the file's path, if it has the same name with the file itself (e.g.
                //"D:\Docs\Notes_from_work\Notes_from_work.pdf").
                string newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, textBoxRenameFile.Text) + filenameExtension;

                //If the new file name already exists in the parent folder of the file-to-be-renamed, the string " - Copy" is added to the new name to differentiate them.
                while ((Directory.GetFiles(Path.GetDirectoryName(oldFilePath))).Contains(newFilePath))
                {
                    newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, textBoxRenameFile.Text) + helperString + filenameExtension;

                    helperString += " - Copy";
                }

                File.Move(oldFilePath, newFilePath);    //The actual renaming. We "move" the file elsewhere while providing a new name (it just happens we move it to the same place it was before...).

                listBox1.Items[selectedListboxIndices[i]] = newFilePath;        //The correct name is, now, displayed in the list box. Used the array's variable for the same reason stated above.
                textBoxRenameFile.Clear();
            }
        }

        private void buttonPartiallyRename_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1 && !string.IsNullOrWhiteSpace(textBoxPartialRenameOrigText.Text) && !string.IsNullOrWhiteSpace(textBoxPartialRenameFinalText.Text))
                PartiallyRenameFile();
            else if (listBox1.SelectedIndices.Count > 1 && !string.IsNullOrWhiteSpace(textBoxPartialRenameOrigText.Text) && !string.IsNullOrWhiteSpace(textBoxPartialRenameFinalText.Text))
                PartiallyRenameManyFiles(listBox1.SelectedIndices);      //Provides the method with each of the selected files' index, so that the correct files are renamed.
        }

        private void textBoxPartialRenameOrigText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && listBox1.SelectedIndices.Count == 1 && !string.IsNullOrWhiteSpace(textBoxPartialRenameOrigText.Text) && !string.IsNullOrWhiteSpace(textBoxPartialRenameFinalText.Text))
                PartiallyRenameFile();
            else if (e.KeyCode.Equals(Keys.Enter) && listBox1.SelectedIndices.Count > 1 && !string.IsNullOrWhiteSpace(textBoxPartialRenameOrigText.Text) && !string.IsNullOrWhiteSpace(textBoxPartialRenameFinalText.Text))
                PartiallyRenameManyFiles(listBox1.SelectedIndices);
        }

        private void textBoxPartialRenameFinalText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && listBox1.SelectedIndices.Count == 1 && !string.IsNullOrWhiteSpace(textBoxPartialRenameOrigText.Text) && !string.IsNullOrWhiteSpace(textBoxPartialRenameFinalText.Text))
                PartiallyRenameFile();
            else if (e.KeyCode.Equals(Keys.Enter) && listBox1.SelectedIndices.Count > 1 && !string.IsNullOrWhiteSpace(textBoxPartialRenameOrigText.Text) && !string.IsNullOrWhiteSpace(textBoxPartialRenameFinalText.Text))
                PartiallyRenameManyFiles(listBox1.SelectedIndices);
        }

        private void PartiallyRenameFile()
        {
            string oldFilePath = listBox1.SelectedItem.ToString();                              //E.g., "D:\Docs\Personal\Notes_from_work.pdf"
            int backslashLastOccurrence = oldFilePath.LastIndexOf("\\");                        //The last occurrence of the backslash (\) in the path is where the file's name starts.            
            string filenameExtension = oldFilePath.Substring(oldFilePath.LastIndexOf("."));     //We isolate the filename extension (the last occurrence of the dot (.) in the path is where it starts).
            string oldFilename = oldFilePath.Remove(oldFilePath.LastIndexOf(".")).Substring(backslashLastOccurrence + 1);    //We remove the filename extension and save the part after the last backslash occurrence.

            //If the user has mistyped and wants to rename a part of the word that does not exist.
            if (!oldFilename.Contains(textBoxPartialRenameOrigText.Text))
            {
                labelWrongPartialRename.ForeColor = Color.Red;
                labelWrongPartialRename.Visible = true;

                timer1.Start();
                return;
            }

            //If the text to be changed is included more than once in the original filename, this method only informs us about the position of its first occurence. If the user wants to replace all occurrences, he'll have to partially
            //rename the file again or perform normal renaming.
            int textToBeChangedFirstOccurence = oldFilename.IndexOf(textBoxPartialRenameOrigText.Text);            
            string newFilePath;
            string helperString = " - Copy";

            string newFilename = oldFilename.Remove(textToBeChangedFirstOccurence, textBoxPartialRenameOrigText.Text.Length).Insert(textToBeChangedFirstOccurence, textBoxPartialRenameFinalText.Text);

            //As before, we remove the old file's name from the original path, then insert the new name at the same position and add the filename extension, because this Remove method deletes everything starting from the position you supply
            //up to the string's end. We also cannot use the the Replace method, because it replaces all instances of the given parameter and we may end up changing the file's path, if the text we want to change exists anywhere wlse inside
            //it.
            newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, newFilename) + filenameExtension;

            //If the new file name already exists in the parent folder of the file-to-be-renamed, the string " - Copy" is added to the new name to differentiate it. Used a while loop for the (edge) case of there (e.g.) already existing both
            //a "Name.txt" and a "Name - Copy.txt" files inside the folder of the file the user wants to rename and he/she wants to rename a third, "Project.txt" file into "Name.txt". If I had used an if clause, the program would rename the
            //file "Name - Copy.txt" and crash. This way, it keeps adding " - Copy" until a valid filename can be created.
            while ((Directory.GetFiles(Path.GetDirectoryName(oldFilePath))).Contains(newFilePath))
            {
                newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, newFilename) + helperString + filenameExtension;

                helperString += " - Copy";
            }

            File.Move(oldFilePath, newFilePath);    //The actual renaming. We "move" the file elsewhere while providing a new name (it just happens we move it to the same place it was before...).

            listBox1.Items[listBox1.SelectedIndex] = newFilePath;        //The correct name is, now, displayed in the list box.
            textBoxPartialRenameOrigText.Clear();
            textBoxPartialRenameFinalText.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelWrongPartialRename.Visible = false;
            timer1.Stop();                                      //The timer is stopped, because we want the event/method to be performed only once.
        }

        private void PartiallyRenameManyFiles(ListBox.SelectedIndexCollection filesToRename)
        {
            int numberOfFilesToRename = filesToRename.Count;        //After you rename a file, it is de-selected from the listbox, because of the line "listBox1.Items[selectedListboxIndices[i]] = newFilePath", which displays the new,
                                                                    //correct file name. This causes the ListBox.SelectedIndexCollection filesToRename method parameter to lose one of its objects, so I save the parameter's initial
                                                                    //number of objects in aseparate variable, so that the for statement works correctly. (I was using "i < filesToRename.Count" before and the count was diminishing after each
                                                                    //loop)
            int[] selectedListboxIndices = new int[numberOfFilesToRename];           //Created for the same reason as above. Program would crash.

            for (int i = 0; i < numberOfFilesToRename; i += 1)
                selectedListboxIndices[i] = filesToRename[i];

            for (int i = 0; i < numberOfFilesToRename; i += 1)
            {
                string oldFilePath = listBox1.Items[selectedListboxIndices[i]].ToString();          //E.g., "D:\Docs\Personal\Notes_from_work.pdf"
                int backslashLastOccurrence = oldFilePath.LastIndexOf("\\");                        //The last occurrence of the backslash (\) in the path is where the file's name starts.            
                string filenameExtension = oldFilePath.Substring(oldFilePath.LastIndexOf("."));     //We isolate the filename extension (the last occurrence of the dot (.) in the path is where it starts).
                string oldFilename = oldFilePath.Remove(oldFilePath.LastIndexOf(".")).Substring(backslashLastOccurrence + 1);    //We remove the filename extension and save the part after the last backslash occurrence.

                //If the user has mistyped and wants to rename a part of the word that does not exist.
                if (!oldFilename.Contains(textBoxPartialRenameOrigText.Text))
                {
                    labelWrongPartialRename.ForeColor = Color.Red;
                    labelWrongPartialRename.Visible = true;

                    timer1.Start();
                    return;
                }

                //If the text to be changed is included more than once in the original filename, this method only informs us about the position of its first occurence. If the user wants to replace all occurrences, he'll have to partially
                //rename the file again or perform normal renaming.
                int textToBeChangedFirstOccurence = oldFilename.IndexOf(textBoxPartialRenameOrigText.Text);
                string newFilePath;
                string helperString = " - Copy";

                string newFilename = oldFilename.Remove(textToBeChangedFirstOccurence, textBoxPartialRenameOrigText.Text.Length).Insert(textToBeChangedFirstOccurence, textBoxPartialRenameFinalText.Text);

                //As before, we remove the old file's name from the original path, then insert the new name at the same position and add the filename extension, because this Remove method deletes everything starting from the position you supply
                //up to the string's end. We also cannot use the the Replace method, because it replaces all instances of the given parameter and we may end up changing the file's path, if the text we want to change exists anywhere wlse inside
                //it.
                newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, newFilename) + filenameExtension;

                //If the new file name already exists in the parent folder of the file-to-be-renamed, the string " - Copy" is added to the new name to differentiate it. Used a while loop for the (edge) case of there (e.g.) already existing both
                //a "Name.txt" and a "Name - Copy.txt" files inside the folder of the file the user wants to rename and he/she wants to rename a third, "Project.txt" file into "Name.txt". If I had used an if clause, the program would rename the
                //file "Name - Copy.txt" and crash. This way, it keeps adding " - Copy" until a valid filename can be created.
                while ((Directory.GetFiles(Path.GetDirectoryName(oldFilePath))).Contains(newFilePath))
                {
                    newFilePath = oldFilePath.Remove(backslashLastOccurrence + 1).Insert(backslashLastOccurrence + 1, newFilename) + helperString + filenameExtension;

                    helperString += " - Copy";
                }

                File.Move(oldFilePath, newFilePath);    //The actual renaming. We "move" the file elsewhere while providing a new name (it just happens we move it to the same place it was before...).

                listBox1.Items[selectedListboxIndices[i]] = newFilePath;        //The correct name is, now, displayed in the list box.
                textBoxPartialRenameOrigText.Clear();
                textBoxPartialRenameFinalText.Clear();
            }
        }
    }//Να μη μετονομάζει σε Copy, όταν το αρχείο υπάρχει ήδη. Να βγάζει μόνο μήνυμα ότι υπάρχει ήδη.
 //NEXT ίδια αρχεία