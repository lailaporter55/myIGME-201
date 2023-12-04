using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.startButton.Click += new EventHandler(StartButton__Click); 
        }
        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0; 
            int highNumber = 0;
            //convert the strings entered in lowTextBox and highTextBox 
            //to lowNumber and highNumber Int32.Parse
            lowNumber = Int32.Parse(lowTextBox.Text);
            highNumber = Int32.Parse(highTextBox.Text);
            //if not a valid range 
            if (lowNumber < 0 && highNumber > 100)
            {
                //show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid"); 
            }
            else 
            {
                //otherwise we're good 
                //create a form object of the second form 
                //passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);
                //display the form as a model dialog,
                //which makes the first form inactive
                gameForm.ShowDialog();
            }
            
        }
    }
}
