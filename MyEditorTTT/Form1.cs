using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using MyEditorTTT;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1(MyEditorParent myEditorParent)
        {
            InitializeComponent();

            this.MdiParent = myEditorParent; 

            //adding an event when buttons are clicked on 
            this.NewToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            //open & save need to be linked to parent 
            myEditorParent.OpenToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            myEditorParent.SaveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);

            //exit is handled by parent 
            //this.ExitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            //handeled by parent 
            myEditorParent.CopyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            myEditorParent.CutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            myEditorParent.PasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);

            myEditorParent.closeAllToolStripMenuItem.Click += new EventHandler(closeAllToolStripMenuItem__Click);

            //redt are handled by toolStrip and are handeled by child
            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStripItem__Click);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);

            this.MSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem__Click);
            this.TimesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem__Click);

            this.richTextBox1.SelectionChanged += new EventHandler(RichTextBox1__SelectionChanged);

            //lets us know the title
            this.Text = "MyEditor";

            //when the form is closed remove the events
            this.FormClosing += new FormClosingEventHandler(Form1__FormClosing); 
        }

        private void Form1__FormClosing(object sender, FormClosingEventArgs e)
        {
            //remove the deligate methods that were added from the parent
            MyEditorParent myEditorParent = (MyEditorParent)this, MdiParent;
            myEditorParent.OpenToolStripMenuItem.Click -= new EventHandler(OpenToolStripMenuItem__CLick);
            myEditorParent.SaveToolStripMenuItem.Click -= new EventHandler(SaveToolStripMenuItem__Click);

            myEditorParent.CopyToolStripMenuItem.Click -= new EventHandler(CopyToolStripMenuItem__Click);
            myEditorParent.CutToolStripMenuItem.Click -= new EventHandler(CutToolStripMenuItem__Click);
            myEditorParent.PasteToolStripMenuItem.Click -= new EventHandler(PasteToolStripMenuItem__Click);

            myEditorParent.closeAllToolStripMenuItem.Click -= new EventHandler(closeAllToolStripMenuItem__Click);

        }

        private void CloseAllToolStripMenuItem(object sender, EventArgs e)
        {
            this.Close(); 
        }

        //method for when new is clicked
        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            //when new is clicked clear the contents
            richTextBox1.Clear();
            this.Text = "MyEditor"; //reset the form back to MyEditor

        }
        private void BoldToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }

        private void TestToolStripButton__Click(object sender, EventArgs e)
        {
            //initialize timer to have 500ms
            /*!!!UNCOMMENT WHEN DESIGN WORKS!!!!
             * this.timer.Interval = 500; 
             * this.toolStripProgressBar1.Value = 60; //determines how wide the progress bar will be
             * 
             * this.countdownLabel.Text = "3";
             * this.counddownLabel.Visible = true; 
             * this.richTextBox.Visible = fasle; 
             * 
             * for(int i = 3; i > 0; --i)
             * {
             *      this.countdownLabel.Txt = i.ToString(); 
             *      this.Refresh(); 
             *      Thread.Sleep(1000);
             * }
             * this.countdownLabel.Visible = false; 
             * this.richTextBox.Visible = true; 
             * 
             * this.timer.Start(); 
             */
        }
        private void Timer__Tick(object sender, EventArgs e)
        {
            /*
             * --this.toolStripProgressBar1.Value; 
             * if(this.toolStripProgressBar1.Value == 0)
             * {
             *      this.timer.Stop(); 
             *      string performance = "Congradulations! You typed " + Math.Round(this.richTextBox1.TextLength /30.0, 2) + " letters per second!";
             *      //message box displays a dialog box 
             *      MessageBox.Show(performance); 
             * }
             */
        }
        private void ItalicsToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }
        private void UnderlineToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }
        private void MSSansSerifToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);

            richTextBox1.SelectionFont = newFont;
        }
        private void TimeNewRomanToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);

            richTextBox1.SelectionFont = newFont;
        }

        private void RichTextBox__SelectionChanged(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionFont != null)
            {
                this.BoldToolStripButton.Checked = richTextBox1.SelectionFont.Bold;
                this.ItalicsToolStripButton.Checked = richTextBox1.SelectionFont.Italic;
                this.UnderlineToolStripButton.Checked = richTextBox1.SelectionFont.Underline;

            }
            this.ColorToolStripButton.BackColor = richTextBox1.SelectionColor;
        }

        private void OpenToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if(this.MdiParent.ActiveMdiChild != this)
            {
                return; 
            }
            //if opening an existing file, show the dialog, and press ok
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.LoadFile(openFileDialog.FileName, richTextBoxStreamType); //if we just give the path, it will assume its a .rtf and if its not there will be a runtime error

                this.Text = "MyEditor (" + openFileDialog.FileName + ")";
            }

        }
        private void SaveToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }
            saveFileDialog.FileName = openFileDialog.FileName;//if they opened a file already we can have the save file default to the open filename

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //we want to know what file type were saving
                //default to rtf
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.SaveFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }

        }
        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void CopyToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }
            richTextBox1.Copy();

        }
        private void CutToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }
            richTextBox1.Cut();

        }
        private void PasteToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }
            richTextBox1.Paste();

        }

        private void ToolStripItem__Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular; //we want to assume that the font coming into the file is regular font

            ToolStripButton toolStripButton = null;

            if (e.ClickedItem == this.BoldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.BoldToolStripButton;
            }
            else if (e.ClickedItem == this.ItalicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.ItalicsToolStripButton;
            }
            else if (e.ClickedItem == this.UnderlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.UnderlineToolStripButton;
            }
            else if (e.ClickedItem == this.ColorToolStripButton)
            {
                if (ColorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = ColorDialog.Color;
                    ColorToolStripButton.BackColor = ColorDialog.Color;
                }
            }
            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                //change the selected font for the selected text
                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }

        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }
            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                //ex: Underline = 4, Bold = 1, Italic = 2
                //in binary would be 111
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }
            this.richTextBox1.SelectionFont = newFont;
        }

    }
}
