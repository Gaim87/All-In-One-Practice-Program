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
        public Microsoft.Office.Interop.Word.Application WordApp { get; set; }
        public Range DocumentContents { get; set; }


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
            WordApp.Selection.Find.ClearFormatting();                                       //Resets the search criteria (they are cumulative).
            WordApp.Selection.Find.Forward = true;                                          //Searches/Finds the next word towards the end of the document.
            WordApp.Selection.Find.Execute(textBoxTextToBeReplaced.Text.ToString());        //The actual search.
            WordApp.Selection.Find.Wrap = WdFindWrap.wdFindContinue;                        //When it finds the last match in the document, it restarts/continues searching from the first match. Respectively, when it finds the first match,
                                                                                            //it moves to the last one.
        }

        private void FindPrevious() //Find object properties included here as well, in case the user presses "Find Previous" first.
        {
            WordApp.Selection.Find.Forward = false;                                         //Searches/Finds the next word towards the begining of the document.
            WordApp.Selection.Find.Wrap = WdFindWrap.wdFindContinue;                        //When it finds the last match in the document, it restarts/continues searching from the first match. Respectively, when it finds the first match,
                                                                                            //it moves to the last one.
            WordApp.Selection.Find.Execute(textBoxTextToBeReplaced.Text.ToString());        //The actual search.
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
            WordApp.Selection.Text = textBoxReplacementText.Text.ToString();    //You, normally, replace text with the code in the above lines, but it would replace the previously-found text and not the one that was selected.
                                                                                //Couldn't fix it, so I used this way instead.
        }

        private void buttonQuitBoth_Click(object sender, EventArgs e)
        {
            WordApp.Quit(WdSaveOptions.wdPromptToSaveChanges);
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e) //Find object properties included here as well, in case the user presses "Find Previous" first.
        {
            DocumentContents.Find.ClearFormatting();        //Used a Range object instead of a Selection one, because the former does not change the selection (i.e., ther cursor does not move to the selected/found text).
            DocumentContents.Find.Forward = true;                                          //Resets the search criteria (they are cumulative).
            DocumentContents.Find.Wrap = WdFindWrap.wdFindContinue;                        //When it finds the last match in the document, it restarts/continues searching from the first match. Respectively, when it finds the first match,
                                                                                            //it moves to the last one. Included here as well, in case the user presses "Replace All" first.

            while (DocumentContents.Find.Execute(textBoxTextToBeReplaced.Text.ToString())) //The actual search.
            {
                DocumentContents.Text = textBoxReplacementText.Text.ToString();
            }

            pictureBox1.Visible = true;                                                     //Check mark icon from https://clipart-library.com/clip-art/green-check-mark-icon-transparent-background-21.htm

            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Stop();                                      //The timer is stopped, because we want the event/method to be performed only once.
        }
    }
}