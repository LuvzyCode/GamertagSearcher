using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamertagSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GamertagInput.ForeColor = SystemColors.GrayText;
            GamertagInput.Text = "Enter Gamertag Here";
            this.GamertagInput.Leave += new System.EventHandler(this.GamertagInput_Leave);
            this.GamertagInput.Enter += new System.EventHandler(this.GamertagInput_Enter);
        }

        private void GamertagInput_Leave(object sender, EventArgs e)
        {
            if (GamertagInput.Text.Length == 0)
            {
                GamertagInput.Text = "Enter Gamertag Here";
                GamertagInput.ForeColor = SystemColors.GrayText;
            }
        }

        private void GamertagInput_Enter(object sender, EventArgs e)
        {
            if (GamertagInput.Text == "Enter Gamertag Here")
            {
                GamertagInput.Text = "";
                GamertagInput.ForeColor = SystemColors.WindowText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GamertagInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string url = "https://account.xbox.com/en-gb/profile?gamertag=" + GamertagInput.Text;
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
