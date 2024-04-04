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

                    toolTip1.SetToolTip(listBox1, listBox1.SelectedItem.ToString());    //Sets a tool tip that shows the selected file's name. Useful when the path or the file's name are longer than the list box's margins.
                                                                                        //It shows the selected file's name no matter where you hover.
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                                        //Displays a modal box about the cause of the exception/error.
                }
        }
    }
}
//(File.Move στο ίδιο dir + bool για overwrite, αφού πρώτα δω ότι .Exists, check mark ότι πέτυχε, check αν είναι dir ή αρχείο για να τα εμφανίσει. Για όλα τα αρχεία του φακέλου ή και
//με if για συγκεκριμένα) rename partially και fully. Contains και IndexOf, για μετονομασία του αρχείου.