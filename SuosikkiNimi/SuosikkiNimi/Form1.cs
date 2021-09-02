using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SuosikkiNimi
{
    public partial class SuosittuForm : Form
    {
        public SuosittuForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            int laskurip = 1, laskurit = 1;
            string[] pojat = File.ReadAllLines("C:\\Users\\jyrili\\source\\T1-tasonohjelmointi\\SuosikkiNimi\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\jyrili\\source\\T1-tasonohjelmointi\\SuosikkiNimi\\tytot.txt");
            string nimi = NimiTB.Text;
            foreach(string poju in pojat)
            {
                if(nimi == poju)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string friidu in pojat)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if(VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimeäsi ei löytynyt suosituimpien nimien joukosta";
                VastausLB.Visible = true;
            }

        }
    }
}
