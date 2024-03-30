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
    public partial class FileRenameForm : Form
    {
        public FileRenameForm()
        {
            InitializeComponent();
        }
    }
}
//(File.Move στο ίδιο dir + bool για overwrite, αφού πρώτα δω ότι .Exists, check mark ότι πέτυχε, λίστα με τα αρχεία του φακέλου ή το αρχείο αριστερά, check αν είναι dir ή αρχείο για να τα εμφανίσει. Για όλα τα αρχεία του φακέλου ή και
//με if για συγκεκριμένα) rename partially και fully