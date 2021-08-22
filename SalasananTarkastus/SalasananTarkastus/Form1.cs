using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kk0Ku1ta")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPn.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen";
                VirheviestiLB.Visible = true;
            }
        }

        private void SalasanaForm_Load(object sender, EventArgs e)
        {
            Point uusi = SalasanaPanel.PointToScreen(new Point(0, 0));
            SalasanaPanel.Parent = this;
            SalasanaPanel.Location = this.PointToClient(uusi);
            SalasanaPanel.BringToFront();
        }
    }
}
