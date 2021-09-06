using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.IO;

namespace Paivakirja
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
=======

namespace Paivakirja
{
    public partial class PaivakirjaForm : Form
    {
        public PaivakirjaForm()
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string teksti = File.ReadAllText(@"C:\\Users\\jyrilindroos\\source\\repos\\T1-tasonohjelmointi\\Paivakirja\\paivakirja.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\jyrilindroos\\source\\repos\\T1-tasonohjelmointi\\Paivakirja\\paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();

=======
            string teksti = System.IO.File.ReadAllText(@"C:\\Users\\jyrili\\source\\T1-tasonohjelmointi\\Paivakirja\\demo.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\jyrili\\source\\T1-tasonohjelmointi\\Paivakirja\\demo.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
        }
    }
}
