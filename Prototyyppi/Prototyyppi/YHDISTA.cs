using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototyyppi
{
    class YHDISTA
    {
            private MySqlConnection yhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=ttvkoe;SSL Mode = None");
            // Luodaan funktio yhteyttä varten
            public MySqlConnection otaYhteys()
            {
                return yhteys;
            }
            // Luodaan funktio yhteyden avaamista varten - HUOM! System.Data -kirjasto
            public void avaaYhteys()
            {
                if (yhteys.State == ConnectionState.Closed)
                {
                    try
                    {
                    yhteys.Open();
                    }
                    catch(Exception ex)
                    {
                    MessageBox.Show("Virhe " + ex);
                    }
                    
                }
            }
            // Luodaan funktio yhteyden sulkemista varten
            public void suljeYhteys()
            {
                if (yhteys.State == ConnectionState.Open)
                {
                    yhteys.Close();
                }
            }
    }
}
