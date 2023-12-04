using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT3Pres
{
    public partial class Presidents : Form
    {
        public Presidents()
        {
            InitializeComponent();
            //create evemt handlers for all of the radio buttons to change the form 
            this.harrRadioButton.CheckedChanged += new EventHandler(HarrRadioButton__CheckedChange);
            this.fdrRadioButton.CheckedChanged += new EventHandler(FdrRadioButton__CheckedChange);
            this.clintRadioButton.CheckedChanged += new EventHandler(ClintRadioButton__CheckedChange);
            this.bucRadioButton.CheckedChanged += new EventHandler(bucRadioButton__CheckedChange);
            this.pierRadioButton.CheckedChanged += new EventHandler(PierRadioButton__CheckedChange);
            this.bushRadioButton.CheckedChanged += new EventHandler(BushRadioButton__CheckedChange);
            this.obamaRadioButton.CheckedChanged += new EventHandler(ObamaRadioButton__CheckedChange);
            this.kenRadioButton.CheckedChanged += new EventHandler(KenRadioButton__CheckedChange);
            this.mckRadioButton.CheckedChanged += new EventHandler(MckRadioButton__CheckedChange);
            this.raeRadioButton.CheckedChanged += new EventHandler(RaeRadioButton__CheckedChange);
            this.eisRadioButton.CheckedChanged += new EventHandler(EisRadioButton__CheckedChange);
            this.vanRadioButton.CheckedChanged += new EventHandler(VanRadioButton__CheckedChange);
            this.washRadioButton.CheckedChanged += new EventHandler(WashRadioButton__CheckedChange);
            this.adamsRadioButton.CheckedChanged += new EventHandler(AdamsRadioButton__CheckedChange);
            this.roosRadioButton.CheckedChanged += new EventHandler(RoosRadioButton__CheckedChange);
            this.jeffRadioButton.CheckedChanged += new EventHandler(JeffRadioButton__CheckedChange);
            //navigate webbrowser to url 
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/");
            //the pictures should only be visible when the cooresponding radio button is clicked
            this.pictureBox.ImageLocation = null; 
            this.pictureBox.Visible = false;
            //exit buttton click event handler, exit button disables
            this.Exitbutton.Enabled = false;
            this.Exitbutton.Click += new EventHandler(ExitButton__Click);
            //textbox.keypress event handler, for each of the text boxes 
            this.harrisonTextBox.KeyPress += new KeyPressEventHandler(HarrisonTextBox__KeyPress);
            this.fdrTextBox.KeyPress += new KeyPressEventHandler(FdrTextBox__KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(ClintonTextBox__KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(BucTextBox__KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(PierTextBox__KeyPress);
            this.bushTextBox.KeyPress += new KeyPressEventHandler(BushTextBox__KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(ObamaTextBox__KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(KenTextBox__KeyPress);
            this.mckinleyTextBox.KeyPress += new KeyPressEventHandler(MckTextBox__KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(RaeTextBox__KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(EisTextBox__KeyPress);
            this.vanburenTextBox.KeyPress += new KeyPressEventHandler(VanTextBox__KeyPress);
            this.washington.KeyPress += new KeyPressEventHandler(Washington__KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(AdamsTextBox__KeyPress);
            this.rooseveltTextBox.KeyPress += new KeyPressEventHandler(RoosTextBox__KeyPress);
            this.jeffersonTextBox.KeyPress += new KeyPressEventHandler(JeffTextBox__KeyPress);

            this.democratRadioButton.CheckedChanged += new EventHandler(DemocratRadioButton__CheckedChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(RepublicanRadioButton__CheckedChanged);
            this.drRadioButton.CheckedChanged += new EventHandler(DRRadioButton__CheckedChanged);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FederalistRadioButton__CheckedChanged);
        }
        private void DemocratRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.democratRadioButton.Checked)
            {
                harrRadioButton.Visible = false;
                harrisonTextBox.Visible = false;
                bushRadioButton.Visible = false;
                bushTextBox.Visible = false;
                mckRadioButton.Visible = false;
                mckinleyTextBox.Visible = false;
                raeRadioButton.Visible = false;
                reaganTextBox.Visible = false;  
                eisRadioButton.Visible = false;
                eisenhowerTextBox.Visible = false;
                rooseveltTextBox.Visible = false;
                roosRadioButton.Visible = false;
                jeffRadioButton.Visible = false;
                jeffersonTextBox.Visible = false;
                washRadioButton.Visible = false;
                washington.Visible = false;
                adamsTextBox.Visible = false;
                adamsRadioButton.Visible = false;
            }
        }
        private void RepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.republicanRadioButton.Checked)
            {
                roosRadioButton.Visible=false;
                rooseveltTextBox.Visible=false;
                clintRadioButton.Visible=false; 
                clintonTextBox.Visible=false;
                bucRadioButton.Visible=false;   
                buchananTextBox.Visible=false;
                pierRadioButton.Visible=false;
                pierceTextBox.Visible=false;
                obamaRadioButton.Visible=false;
                obamaTextBox.Visible=false;
                kennedyTextBox.Visible=false;
                vanRadioButton.Visible=false;
                vanburenTextBox.Visible=false;
                jeffRadioButton.Visible = false;
                jeffersonTextBox.Visible = false;
                washRadioButton.Visible = false;
                washington.Visible = false;
                adamsTextBox.Visible = false;
                adamsRadioButton.Visible = false;
            }
        }
        private void DRRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            roosRadioButton.Visible = false;
            rooseveltTextBox.Visible = false;
            clintRadioButton.Visible = false;
            clintonTextBox.Visible = false;
            bucRadioButton.Visible = false;
            buchananTextBox.Visible = false;
            pierRadioButton.Visible = false;
            pierceTextBox.Visible = false;
            obamaRadioButton.Visible = false;
            obamaTextBox.Visible = false;
            kennedyTextBox.Visible = false;
            vanRadioButton.Visible = false;
            vanburenTextBox.Visible = false;
            harrRadioButton.Visible = false;
            harrisonTextBox.Visible = false;
            bushRadioButton.Visible = false;
            bushTextBox.Visible = false;
            mckRadioButton.Visible = false;
            mckinleyTextBox.Visible = false;
            raeRadioButton.Visible = false;
            reaganTextBox.Visible = false;
            eisRadioButton.Visible = false;
            eisenhowerTextBox.Visible = false;
            rooseveltTextBox.Visible = false;
            roosRadioButton.Visible = false;
            washRadioButton.Visible = false;
            washington.Visible = false;
            adamsTextBox.Visible = false;
            adamsRadioButton.Visible = false;
        }
        private void FederalistRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            roosRadioButton.Visible = false;
            rooseveltTextBox.Visible = false;
            clintRadioButton.Visible = false;
            clintonTextBox.Visible = false;
            bucRadioButton.Visible = false;
            buchananTextBox.Visible = false;
            pierRadioButton.Visible = false;
            pierceTextBox.Visible = false;
            obamaRadioButton.Visible = false;
            obamaTextBox.Visible = false;
            kennedyTextBox.Visible = false;
            vanRadioButton.Visible = false;
            vanburenTextBox.Visible = false;
            harrRadioButton.Visible = false;
            harrisonTextBox.Visible = false;
            bushRadioButton.Visible = false;
            bushTextBox.Visible = false;
            mckRadioButton.Visible = false;
            mckinleyTextBox.Visible = false;
            raeRadioButton.Visible = false;
            reaganTextBox.Visible = false;
            eisRadioButton.Visible = false;
            eisenhowerTextBox.Visible = false;
            rooseveltTextBox.Visible = false;
            roosRadioButton.Visible = false;
            jeffRadioButton.Visible = false;
            jeffersonTextBox.Visible = false;
        }
        private void HarrisonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 23)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void FdrTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 32)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void ClintonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 42)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void BucTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 15)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void PierTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 14)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void BushTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 43)
            {
                MessageBox.Show("Thats the wrong number");
            }
           
        }
        private void ObamaTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 44)
            {
                MessageBox.Show("Thats the wrong number");
            }
           
        }
        private void KenTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 35)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void MckTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 25)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void RaeTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 40)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void EisTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 34)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void VanTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void Washington__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 1)
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void AdamsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 2 )
            {
                MessageBox.Show("Thats the wrong number");
            }
        }
        private void RoosTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 26 )
            {
                MessageBox.Show("Thats the wrong number");
            }
            
        }
        private void JeffTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 3)
            {
                MessageBox.Show("Thats the wrong number");
            }
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //create all the radio button methods
        private void HarrRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            }

        }
        private void FdrRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
            }
        }
        private void ClintRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_J_Clinton");
            }
            
        }
        private void bucRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");
            }
            
        }
        private void PierRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
            }
            
        }
        private void BushRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_W_Bush");
            }
           
        }
        private void ObamaRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
            }
            
        }
        private void KenRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_F_Kennedy");
            }
            
        }
        private void MckRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
            }
            
        }
        private void RaeRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Raegan");
            }
            
        }
        private void EisRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower");
            }
            
        }
        private void VanRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
            }
            
        }
        private void WashRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
            }
        }
        private void AdamsRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
            }

        }
        private void RoosRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
            }
           
        }
        private void JeffRadioButton__CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //make the corresponding image visible
                this.pictureBox.Visible = true;
                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
                //show corresponding web control 
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
            }
  
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
