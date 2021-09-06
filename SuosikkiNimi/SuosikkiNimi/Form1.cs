using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

namespace SuosikkiNimi
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
=======
using System.IO;

namespace SuosikkiNimi
{
    public partial class SuosittuForm : Form
    {
        public SuosittuForm()
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
<<<<<<< HEAD
            string[] pojat = File.ReadAllLines("C:\\Users\\jyrilindroos\\source\\repos\\T1-tasonohjelmointi\\SuosikkiNimi\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\jyrilindroos\\source\\repos\\T1-tasonohjelmointi\\SuosikkiNimi\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1, laskurit = 1;
=======
            int laskurip = 1, laskurit = 1;
            string[] pojat = File.ReadAllLines("C:\\Users\\jyrili\\source\\T1-tasonohjelmointi\\SuosikkiNimi\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\jyrili\\source\\T1-tasonohjelmointi\\SuosikkiNimi\\tytot.txt");
            string nimi = NimiTB.Text;
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
            foreach(string poju in pojat)
            {
                if(nimi == poju)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
<<<<<<< HEAD
            foreach (string friidu in tytot)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin poikien nimi vuonna 2020";
=======
            foreach (string friidu in pojat)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if(VastausLB.Visible == false)
            {
<<<<<<< HEAD
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta! :-(";
=======
                VastausLB.Text = "Nimeäsi ei löytynyt suosituimpien nimien joukosta";
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
                VastausLB.Visible = true;
            }

        }
    }
}
