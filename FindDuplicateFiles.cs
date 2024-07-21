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
            List<string> sameFilesList = new List<string>();

            //Variable i is incremented up to the array's length minus 1, because the last file has already been compared to all others before it.
            //Starting from the first, each of the array's files is going to be opened and compared to the files following it, by use of the second for loop.
            for (int i = 0; i < fileArray.Length-1; i += 1)
            {
                if (sameFilesList.Contains(fileArray[i]))                      //If a file has already been found to be the same with another one, we do not need to compare it again.
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

                    //Compares the two files byte-by-byte until either a non-matching set of bytes is found or the end of the first file is reached "-1" returned).
                    while ((firstFileCounter == secondFileCounter) && (firstFileCounter != -1))
                    {
                        firstFileCounter = fileStream1.ReadByte();
                        secondFileCounter = fileStream2.ReadByte();
                    }

                    fileStream1.Close();
                    fileStream2.Close();

                    if (firstFileCounter - secondFileCounter == 0)                  //If the files are identical...
                        sameFilesList.Add(i + fileArray[j]);                        //The second file is saved in an array for later use as "the first file's position in the array (the i variable), followed by the second file's
                                                                                    //filename/path".
                }
            }

            if (sameFilesList.Count() == 0)
                listBox1.Items.Add("No duplicate files were found.");
            else
            {
                for (int i = 0; i < fileArray.Count()-1; i += 1)                      //The duplicate file can be any file of the original array's file, so we increment up to its length minus 1. The last file is excluded as before.
                {
                    List<string> helperList = new List<string>();

                    try
                    {
                        helperList = sameFilesList.Where(x => x.StartsWith(i.ToString())).ToList();    //E.g., if a file starts with "0", it means that it was found to be identical to the 1st (0-index) file in the "fileArray" parameter.
                    }
                    catch
                    {
                        
                    }

                    //If we compare more than 9 files, the second digit is not removed from the filename. I tried (1) SkipWhile and (2) saving the list's contents in a string variable and using Char.IsNumber + Remove, but
                    //nothing worked.
                        if (helperList.Count() > 0)
                    {
                        if (helperList.Count() == 1)
                            listBox1.Items.Add("The file " + fileArray[i] + " is identical to the file " + helperList[0].Remove(0, 1) + ".");
                        else if (helperList.Count() > 1)
                        {
                            string helperListContents = "";

                            if (helperList.Count() == 2)
                            {
                                listBox1.Items.Add("The file " + fileArray[i] + " is identical to the file " + helperList[0].Remove(0, 1) + " and the file " + helperList[1].Remove(0, 1) + ".");
                            }
                            else
                            {
                                for (int j = 0; j < helperList.Count(); j += 1)
                                {
                                    if (j == 0)
                                        helperListContents += "The file " + fileArray[i] + " is identical to the file " + helperList[0].Remove(0, 1) + ", ";
                                    else if (j > 0 && j <= (helperList.Count() - 2))
                                        helperListContents += "the file " + helperList[j].Remove(0, 1) + ", ";
                                    else
                                        helperListContents += "and the file " + helperList[j].Remove(0, 1) + ".";
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

            CompareFiles(selectedFilesArray);
        }
    }
}
//Check πώς δουλεύει ο αλγόριθμος όταν είναι και τα 5 αρχεία ίδια και όταν είναι 3 + 2 ή σκέτο 3, π.χ. 1 - 3 - 5 ίδια (αν δουλεύουν τα break και continue).
//Να βγάζει μήνυμα, αν δεν έχω επιλέξει αρχεία.
//Δε δουλεύει έτσι όπως νόμιζα το Contains και συγκρίνει κανονικά όλα τα αρχεία, δεν κάνει continue.
//Όταν εμφανίζει ποια αρχεία είναι ίδια, αν είναι πάνω από 2 ίδια, το 2ο και το 3ο τα ξαναγράφει. Π.χ., 1 +2 +3 είναι ίδια και από κάτω 2 + 3 είναι ίδια.