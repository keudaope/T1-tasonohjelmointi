using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paivakirja
{
    public partial class PaivakirjaForm : Form
    {
        public PaivakirjaForm()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = System.IO.File.ReadAllText(@"C:\\Users\\jyrili\\source\\T1-tasonohjelmointi\\Paivakirja\\demo.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\jyrili\\source\\T1-tasonohjelmointi\\Paivakirja\\demo.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
