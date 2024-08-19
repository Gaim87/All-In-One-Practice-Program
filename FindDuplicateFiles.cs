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
    public partial class FindDuplicateFiles : Form
    {
        string[] selectedFilesArray;         //The files that are going to be compared.

        public FindDuplicateFiles()
        {
            InitializeComponent();
        }

        private void buttonChooseFiles_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)                        //If the user selected any files.
            {
                try
                {
                    selectedFilesArray = openFileDialog1.FileNames;

                    for (int i = 0; i < selectedFilesArray.Length; i += 1)
                        listBox1.Items.Add(selectedFilesArray[i]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Performs a byte-by-byte comparison to all files contained in an array and displays the results in a list box.
        //Taken from https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/create-file-compare and edited.
        private void CompareFiles (string[] fileArray)
        {
            int firstFileCounter;
            int secondFileCounter;
            FileStream fileStream1;
            FileStream fileStream2;
            List<Tuple<int, string>> sameFilesList = new List<Tuple<int, string>>();    //Contains files that are identical to each other. Index-filename items pair.

            //Variable i is incremented up to the array's length minus 1, because the last file has already been compared to all others before it.
            //Starting from the first, each of the array's files is going to be opened and compared to the files following it, by use of the second for loop.
            for (int i = 0; i < fileArray.Length-1; i += 1)
            {
                bool skipCurrentComparison = false;

                foreach (Tuple<int, string> tpl in sameFilesList)       //Compares the filename of the sameFilesList's contents (Item2) to the current file's (fileArray[i]) filename.
                {                                                       //If the current file has already been found to be identical to another one, we do not need to compare it again.
                    if (tpl.Item2.Equals(fileArray[i]))
                    {
                        skipCurrentComparison = true;
                        break;
                    }
                }

                if (skipCurrentComparison)          //The current file (fileArray[i]) has already been found to be identical to another one, so we move on to the next.
                    continue;

                for (int j = i+1; j < fileArray.Length; j += 1)                     //Iterates through every file that follows the one in the previous for loop. For ease of reference, the first loop's file will be referred to as
                                                                                    //"the first file" and the second loop's as "the second file".
                {
                    fileStream1 = new FileStream(fileArray[i], FileMode.Open);      
                    fileStream2 = new FileStream(fileArray[j], FileMode.Open);

                    if (fileStream1.Length != fileStream2.Length)                   //If the two files have a different size, there is no need to compare them.
                    {
                        fileStream1.Close();
                        fileStream2.Close();

                        continue;
                    }

                    firstFileCounter = fileStream1.ReadByte();
                    secondFileCounter = fileStream2.ReadByte();

                    //Compares the two files byte-by-byte until either a non-matching set of bytes is found or the end of the first file is reached ("-1" returned).
                    while ((firstFileCounter == secondFileCounter) && (firstFileCounter != -1))
                    {
                        firstFileCounter = fileStream1.ReadByte();
                        secondFileCounter = fileStream2.ReadByte();
                    }

                    fileStream1.Close();
                    fileStream2.Close();

                    if (firstFileCounter - secondFileCounter == 0)                  //If the files are identical...
                        sameFilesList.Add(Tuple.Create(i, fileArray[j]));           //We create a new tuple/pair of values in our list of identical files. It contains an integer that is the first file's index in the file array (the i
                                                                                    //variable) and a string that is the second file's filename/path. E.g., "2, C:\Readme.txt" means that the file C:\Readme.txt is identical to the
                }                                                                   //original list's file with index 2 (fileArray[2]).
            }

            if (sameFilesList.Count() == 0)
                listBox1.Items.Add("No duplicate files were found.");
            else
            {
                for (int i = 0; i < fileArray.Count()-1; i += 1)                    //The duplicate file can be any one of the original array's files, so we increment up to its length minus 1. The last file is excluded as before.
                {
                    List<Tuple<int, string>> helperList = new List<Tuple<int, string>>();

                    try
                    {
                        helperList = sameFilesList.Where(x => x.Item1.Equals(i)).ToList();    //We create a list that contains all files that have been found to be identical to the file located at the original file list's i position
                    }                                                                         //(fileArray[i]). The loop, then, iterates through every file except the last, as stated above.
                    catch
                    {
                    }

                    if (helperList.Count() > 0)
                    {
                        if (helperList.Count() == 1)
                            listBox1.Items.Add("The file " + fileArray[i] + " is identical to the file " + helperList[0].Item2 + ".");
                        else if (helperList.Count() > 1)
                        {
                            string helperListContents = "";

                            if (helperList.Count() == 2)
                            {
                                listBox1.Items.Add("The file " + fileArray[i] + " is identical to the file " + helperList[0].Item2 + " and the file " + helperList[1].Item2 + ".");
                            }
                            else
                            {
                                for (int j = 0; j < helperList.Count(); j += 1)
                                {
                                    if (j == 0)
                                        helperListContents += "The file " + fileArray[i] + " is identical to the file " + helperList[0].Item2 + ", ";
                                    else if (j > 0 && j <= (helperList.Count() - 2))
                                        helperListContents += "the file " + helperList[j].Item2 + ", ";         //The penultimate file.
                                    else
                                        helperListContents += "and the file " + helperList[j].Item2 + ".";
                                }

                                listBox1.Items.Add(helperListContents);
                            }
                        }
                    }
                }
            }
        }

        private void buttonFindDuplicates_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (selectedFilesArray.Length > 0)
                CompareFiles(selectedFilesArray);
            else
                MessageBox.Show("You have not selected any files");
        }
    }
}
//Να βγάζει μήνυμα, αν δεν έχω επιλέξει αρχεία (σκάει).

//Να εμφανίζω τα ονόματα των αρχείων κομμένα (μόνο το όνομα του αρχείου, όχι όλο το path).

//Ενημέρωση σημειώσεις μου για tuples και για το ότι όταν ψάχνεις για ένα string μέσα σε λίστα, χρειάζεσαι foreach, αλλιώς ψάχνει το string αυτούσιο. Ενώ εγώ ήθελα να βρω αν το string μου περιέχετο σε κάποιο από τα ΠΕΡΙΕΧΟΜΕΝΑ
//της λίστας και όχι αυτούσιο.