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

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //adding an event when buttons are clicked on 
            this.NewToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.OpenToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            this.SaveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);
            this.ExitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            this.CopyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            this.CutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            this.PasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStripItem__Click);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);

            this.MSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem__Click);
            this.TimesNewRomanToolStripMenuItem.Click += new EventHandler(timesNewRomanToolStripMenuItem__Click);

            this.richTextBox1.SelectionChanged += new EventHandler(RichTextBox1__SelectionChanged);

            //lets us know the title
            this.Text = "MyEditor"; 
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
            if(this.richTextBox1.SelectionFont != null)
            {
                this.BoldToolStripButton.Checked = richTextBox1.SelectionFont.Bold;
                this.ItalicsToolStripButton.Checked = richTextBox1.SelectionFont.Italic;
                this.UnderlineToolStripButton.Checked = richTextBox1.SelectionFont.Underline;

            }
            this.ColorToolStripButton.BackColor = richTextBox1.SelectionColor;
        }
        
        private void OpenToolStripMenuItem__Click(object sender, EventArgs e)
        {
           //if opening an existing file, show the dialog, and press ok
           if(openFileDialog.ShowDialog() == DialogResult.OK) 
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
            richTextBox1.Copy();

        }
        private void CutToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }
        private void PasteToolStripMenuItem__Click(object sender, EventArgs e)
        {
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
                if(ColorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = ColorDialog.Color; 
                    ColorToolStripButton.BackColor = ColorDialog.Color;
                }
            }
            if(fontStyle != FontStyle.Regular)
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
            if(bSet)
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
