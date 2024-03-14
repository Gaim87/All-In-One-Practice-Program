using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace All_In_One_Practice_Program
{
    public partial class TextReplaceWindow : Form
    {
        public Microsoft.Office.Interop.Word.Application wordApp { get; set; }

        public TextReplaceWindow()
        {
            InitializeComponent();
        }

        private void buttonFindNextWord_Click(object sender, EventArgs e)
        {
            FindNext();
        }

        private void textBoxTextToBeReplaced_TextChanged(object sender, EventArgs e)
        {
            FindNext();
        }

        private void FindNext()
        {
            wordApp.Selection.Find.ClearFormatting();                                       //Resets the search criteria (they are cumulative).
            wordApp.Selection.Find.Forward = true;                                          //Searches/Finds the next word towards the end of the document.
            wordApp.Selection.Find.Execute(textBoxTextToBeReplaced.Text.ToString());        //The actual search.
            wordApp.Selection.Find.Wrap = WdFindWrap.wdFindContinue;                        //When it finds the last match in the document, it restarts/continues searching from the first match. Respectively, when it finds the first match,
                                                                                            //it moves to the last one.
        }

        private void FindPrevious()
        {
            wordApp.Selection.Find.Forward = false;                                         //Searches/Finds the next word towards the begining of the document.
            wordApp.Selection.Find.Execute(textBoxTextToBeReplaced.Text.ToString());        //The actual search.
        }

        private void buttonFindPrevious_Click(object sender, EventArgs e)
        {
            FindPrevious();
        }

        private void textBoxTextToBeReplaced_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                FindNext();
        }

        private void buttonReplaceText_Click(object sender, EventArgs e)
        {
            //wordApp.Selection.Find.Replacement.ClearFormatting();
            //wordApp.Selection.Find.Execute(textBoxTextToBeReplaced.Text.ToString(), null, null, null, null, null, null, null, null, textBoxReplacementText.Text.ToString(), WdReplace.wdReplaceAll);
            wordApp.Selection.Text = textBoxReplacementText.Text.ToString();    //You, normally, replace text with the code in the above lines, but it would replace the previously-found text and not the one that was selected.
                                                                                //Couldn't fix it, so I used this way instead.
        }

        private void buttonQuitBoth_Click(object sender, EventArgs e)
        {
            wordApp.Quit(WdSaveOptions.wdPromptToSaveChanges);
            this.DialogResult = DialogResult.Cancel;
        }
    }
}   //Να γράψω κώδικα για το Replace All