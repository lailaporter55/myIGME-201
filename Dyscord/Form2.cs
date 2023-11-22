using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO; 

namespace Dyscord
{
    public partial class DyscordForm : Form
    {
        string targetUser;
        string TargetIp;
        int targetPort;
        string myIp; 
        int myPort;
        Thread thread;
        Socket listener; 
        public DyscordForm()
        {
            InitializeComponent();
            this.Show();
            SettingsForm settingsForm = new SettingsForm(this, myPort); 
            settingsForm.ShowDialog();
        }
    }
}
