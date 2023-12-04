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
    public partial class GameForm : Form
    {
        private int lowNumber; 
        private int highNumber;

        public GameForm(int lowNumber, int highNumber)
        {
            this.lowNumber = lowNumber;
            this.highNumber = highNumber;
            this.timer1.Tick += new EventHandler(Timer1__Tick);
        }
        private void Timer1__Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value = 45)
            {
                this.timer1.Stop();
                MessageBox.Show("Game over!"); 1
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
