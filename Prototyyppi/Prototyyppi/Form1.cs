using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototyyppi
{
    public partial class palauteFM : Form
    {
        public palauteFM()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            uusiktPL.Visible = false;
            TervetuloaPL.Visible = false;
            KirjautuminenPL.Visible = true;
        }

        private void loginTSL_Click(object sender, EventArgs e)
        {
            KirjautuminenPL.Visible = false;
            TervetuloaPL.Visible = false;
            uusiktPL.Visible = true;
        }

        private void kotisivuTSL_Click(object sender, EventArgs e)
        {
            KirjautuminenPL.Visible = false;
            TervetuloaPL.Visible = true;
            uusiktPL.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lahetaBT_Click(object sender, EventArgs e)
        {
            string etunimi, sukunimi, salasana1, salasana2, email, huomiota;
            string kurssi = "";
            string aika = "";
            string okieli = "";
            string ika = "";
            etunimi = etunimiTB.Text;
            sukunimi = sukunimiTB.Text;
            salasana1 = salasana1TB.Text;
            salasana2 = salasana2TB.Text;
            email = emailTB.Text;
            huomiota = huomTB.Text;

            foreach (RadioButton r in tenttiGB.Controls)
            {
                if (r.Checked)
                {
                    aika = r.Text;
                }                 
            }
            foreach (CheckBox c in kurssiGB.Controls)
            {
                if (c.Checked)
                {
                    kurssi += c.Text + " ";
                }
            }
            try
            {
                okieli = kieletCB.SelectedItem.ToString();
                ika = ikaCB.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("pudotusvalikot eivät ole valittu" + ex.Message);
            }
            

            if(etunimi.Trim().Equals("") || sukunimi.Trim().Equals("") || salasana1.Trim().Equals("") || salasana2.Trim().Equals("") || email.Trim().Equals("") || huomiota.Trim().Equals("") || aika.Trim().Equals("") || kurssi.Trim().Equals(""))
            {
                MessageBox.Show("Syötä kaikki kentät", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(salasana1TB.Text != salasana2TB.Text)
            {
                MessageBox.Show("Salasanat eivät täsmää", "Ei yhtenäiset salasanat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                KirjautuminenPL.Visible = true;
                uusiktPL.Visible = false;
                theendPL.Visible = false;
                TervetuloaPL.Visible = false;
            }
            
        }

        private void kirjaudusBT_Click(object sender, EventArgs e)
        {
            if(ktTB.Text == "jyrlindr" && ssTB.Text == "Ja@kk0Ku1t4")
            {
                KirjautuminenPL.Visible = false;
                uusiktPL.Visible = false;
                theendPL.Visible = true;
                TervetuloaPL.Visible = false;
            }
            else
            {
                virheLB.Text = "Käyttäjätunnus tai salasana väärin!";
            } 
        }

        private void kirjauduBT_Click(object sender, EventArgs e)
        {
            KirjautuminenPL.Visible = true;
            uusiktPL.Visible = false;
            theendPL.Visible = false;
            TervetuloaPL.Visible = false;
        }

        private void uusiktBT_Click(object sender, EventArgs e)
        {
            KirjautuminenPL.Visible = false;
            uusiktPL.Visible = true;
            theendPL.Visible = false;
            TervetuloaPL.Visible = false;
        }
    }
}
