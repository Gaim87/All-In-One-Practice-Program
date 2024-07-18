using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_In_One_Practice_Program
{
    public partial class FindDuplicateFiles : Form
    {
        public FindDuplicateFiles()
        {
            InitializeComponent();
        }

        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)                        //If the user selected any files.
            {
                try
                {
                    string[] selectedFiles = openFileDialog1.FileNames;

                    for (int i = 0; i < selectedFiles.Length; i += 1)
                        listBox1.Items.Add(selectedFiles[i]);

                    if (selectedFiles.Length == 1)
                        listBox1.SelectedItem = listBox1.Items[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
