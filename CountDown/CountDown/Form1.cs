using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class LaskuriForm : Form
    {
       
        public LaskuriForm()
        {
            InitializeComponent();
        }
        private int kokonaisaika;
        private void LaskuriForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; // Aivan alussa poistetaan Stop-button käytöstä
            for(int i=0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString()); // Lisäämme minuutteihin 0-59
                sekunnitCB.Items.Add(i.ToString()); // Lisäämme sekunteihin 0-59
            }
            minuutitCB.SelectedIndex = 30; // Määrittelemme, että oletus on 30
            sekunnitCB.SelectedIndex = 0; // Määrittelemme, että oletus on 0
        }
        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; // Poistetaan tämä painike käytöstä
            StopBT.Enabled = true; // Otetaan Stop-painike käyttöön
            // lasketaan kokonaisaika sekunteina
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString()); // Haetaan valitut minuutit
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString()); // Haetaan valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }
        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true; // Otetaan Start-painike käyttöön
            StopBT.Enabled = false; // Poistetaan tämä painike käytöstä
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            aikaLB.Text = "00:00";

        }
        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
