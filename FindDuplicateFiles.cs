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
            string[] sameFilesArray = new string[fileArray.Length];

            for (int i = 0; i < fileArray.Length-1; i += 1)                         //Variable i is incremented until the array's length minus 1 because the last file has already been compared to all others before it.
            {
                fileStream1 = new FileStream(fileArray[i], FileMode.Open);          //Starting from the first, each of the array's files is going to be opened and compared to the files following it, by use of the second for loop.

                for (int j = i+1; j < fileArray.Length; j += 1)                     //Iterates through every file that follows the one in the previous for loop.
                {
                    if (sameFilesArray.Contains(fileArray[j]))                      //If a file has been found to be the same with another one, we do not need to compare it again.
                        continue;

                    fileStream2 = new FileStream(fileArray[j], FileMode.Open);

                    if (fileStream1.Length != fileStream2.Length)                   //If the two files have a different size, then they are not the same. No need to compare them.
                    {
                        fileStream1.Close();
                        fileStream2.Close();

                        continue;
                    }

                    firstFileCounter = fileStream1.ReadByte();
                    secondFileCounter = fileStream2.ReadByte();

                    //Compares the two files byte-by-byte until either a non-matching set of bytes is found or the end of the first file is reached.
                    while ((firstFileCounter == secondFileCounter) && (firstFileCounter != -1))
                    {
                        firstFileCounter = fileStream1.ReadByte();
                        secondFileCounter = fileStream2.ReadByte();
                    }

                    fileStream1.Close();
                    fileStream2.Close();

                    if (firstFileCounter - secondFileCounter == 0)
                    {

                    }
                }
            }
        }
    }
}
//Έχω for και αν δεν είναι ίδια τα byte, γίνεται break, αλλιώς έχω μετά το break την εντολή για αποθήκευση του ονόματος του αρχείου στον 2ο πίνακα.
//Να βάζω το νούμερο του αρχείου (π.χ., αν είναι το 1ο, το "1") μπροστά από το όνομα (στον 2ο πίνακα), ώστε να ξέρω ποιο αρχείο είναι το ίδιο με ποιο (και να κάνω τσεκ με ομάδες ίδιων αρχείων στον ίδιο φάκελο).

//Check πώς δουλεύει ο αλγόριθμος (από άποψη απόδοσης, όχι αν δίνει σωστό αποτέλεσμα) όταν είναι και τα 5 αρχεία ίδια και όταν είναι 3 + 2 ή σκέτο 3, π.χ. 1 - 3 - 5 ίδια (αν δουλεύουν τα break και continue).