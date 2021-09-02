using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kilomlaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus="";
            if (TextBoxTB.Text.Length > 3) // Neljä lukua
            {
                luku1 = Convert.ToInt32(TextBoxTB.Text.Substring(0, 1));
                luku2 = Convert.ToInt32(TextBoxTB.Text.Substring(1, 1));
                luku3 = Convert.ToInt32(TextBoxTB.Text.Substring(2, 1));
                luku4 = Convert.ToInt32(TextBoxTB.Text.Substring(3, 1));
                if(luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if (luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if (luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                if(luku2 >= 5)
                {
                    vastaus += "D";
                    luku2 -= 5;
                }
                if(luku2 % 4 == 0 && luku2 != 0)
                {
                    vastaus += "CD";
                }
                else if(luku2 % 3 == 0 && luku2 != 0)
                {
                    vastaus += "CCC";
                }
                else if (luku2 % 2 == 0 && luku2 != 0)
                {
                    vastaus += "CC";
                }
                else if (luku2 % 1 == 0 && luku2 != 0)
                {
                    vastaus += "C";
                }
                // luku 3
                if (luku3 >= 5)
                {
                    vastaus += "L";
                    luku3 -= 5;
                }
                if (luku3 % 4 == 0 && luku3 != 0)
                {
                    vastaus += "LX";
                }
                else if (luku3 % 3 == 0 && luku3 != 0)
                {
                    vastaus += "XXX";
                }
                else if (luku3 % 2 == 0 && luku3 != 0)
                {
                    vastaus += "XX";
                }
                else if (luku3 % 1 == 0 && luku3 != 0)
                {
                    vastaus += "X";
                }
                //Luku4
                if (luku4 >= 5)
                {
                    vastaus += "V";
                    luku4 -= 5;
                }
                if (luku4 % 4 == 0 && luku4 != 0)
                {
                    vastaus += "IV";
                }
                else if (luku4 % 3 == 0 && luku4 != 0)
                {
                    vastaus += "III";
                }
                else if (luku4 % 2 == 0 && luku4 != 0)
                {
                    vastaus += "II";
                }
                else if (luku4 % 1 == 0 && luku4 != 0)
                {
                    vastaus += "I";
                }
                VastausLB.Text = vastaus;
                VastausLB.Visible = true;

            }
            else if (TextBoxTB.Text.Length > 2) // kolme lukua
            {
                luku2 = Convert.ToInt32(TextBoxTB.Text.Substring(0, 1));
                luku3 = Convert.ToInt32(TextBoxTB.Text.Substring(1, 1));
                luku4 = Convert.ToInt32(TextBoxTB.Text.Substring(2, 1));
                if (luku2 >= 5)
                {
                    vastaus += "D";
                    luku2 -= 5;
                }
                if (luku2 % 4 == 0 && luku2 != 0)
                {
                    vastaus += "CD";
                }
                else if (luku2 % 3 == 0 && luku2 != 0)
                {
                    vastaus += "CCC";
                }
                else if (luku2 % 2 == 0 && luku2 != 0)
                {
                    vastaus += "CC";
                }
                else if (luku2 % 1 == 0 && luku2 != 0)
                {
                    vastaus += "C";
                }
                // luku 3
                if (luku3 >= 5)
                {
                    vastaus += "L";
                    luku3 -= 5;
                }
                if (luku3 % 4 == 0 && luku3 != 0)
                {
                    vastaus += "LX";
                }
                else if (luku3 % 3 == 0 && luku3 != 0)
                {
                    vastaus += "XXX";
                }
                else if (luku3 % 2 == 0 && luku3 != 0)
                {
                    vastaus += "XX";
                }
                else if (luku3 % 1 == 0 && luku3 != 0)
                {
                    vastaus += "X";
                }
                //Luku4
                if (luku4 >= 5)
                {
                    vastaus += "V";
                    luku4 -= 5;
                }
                if (luku4 % 4 == 0 && luku4 != 0)
                {
                    vastaus += "IV";
                }
                else if (luku4 % 3 == 0 && luku4 != 0)
                {
                    vastaus += "III";
                }
                else if (luku4 % 2 == 0 && luku4 != 0)
                {
                    vastaus += "II";
                }
                else if (luku4 % 1 == 0 && luku4 != 0)
                {
                    vastaus += "I";
                }
                VastausLB.Text = vastaus;
                VastausLB.Visible = true;
            }
            else if (TextBoxTB.Text.Length > 1)
            {
                luku3 = Convert.ToInt32(TextBoxTB.Text.Substring(0, 1));
                luku4 = Convert.ToInt32(TextBoxTB.Text.Substring(1, 1));
                // luku 3
                if (luku3 >= 5)
                {
                    vastaus += "L";
                    luku3 -= 5;
                }
                if (luku3 % 4 == 0 && luku3 != 0)
                {
                    vastaus += "LX";
                }
                else if (luku3 % 3 == 0 && luku3 != 0)
                {
                    vastaus += "XXX";
                }
                else if (luku3 % 2 == 0 && luku3 != 0)
                {
                    vastaus += "XX";
                }
                else if (luku3 % 1 == 0 && luku3 != 0)
                {
                    vastaus += "X";
                }
                //Luku4
                if (luku4 >= 5)
                {
                    vastaus += "V";
                    luku4 -= 5;
                }
                if (luku4 % 4 == 0 && luku4 != 0)
                {
                    vastaus += "IV";
                }
                else if (luku4 % 3 == 0 && luku4 != 0)
                {
                    vastaus += "III";
                }
                else if (luku4 % 2 == 0 && luku4 != 0)
                {
                    vastaus += "II";
                }
                else if (luku4 % 1 == 0 && luku4 != 0)
                {
                    vastaus += "I";
                }
                VastausLB.Text = vastaus;
                VastausLB.Visible = true;

            }
            else
            {
                luku4 = Convert.ToInt32(TextBoxTB.Text.Substring(0, 1));
                //Luku4
                if (luku4 >= 5)
                {
                    vastaus += "V";
                    luku4 -= 5;
                }
                if (luku4 % 4 == 0 && luku4 != 0)
                {
                    vastaus += "IV";
                }
                else if (luku4 % 3 == 0 && luku4 != 0)
                {
                    vastaus += "III";
                }
                else if (luku4 % 2 == 0 && luku4 != 0)
                {
                    vastaus += "II";
                }
                else if (luku4 % 1 == 0 && luku4 != 0)
                {
                    vastaus += "I";
                }
                VastausLB.Text = vastaus;
                VastausLB.Visible = true;
            }

        }
    }
}
