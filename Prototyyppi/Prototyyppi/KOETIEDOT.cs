using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Prototyyppi
{
    class KOETIEDOT
    {
        YHDISTA yhteys = new YHDISTA();

        public bool lisaaTiedot(String en, String sn, String ss, String em, String ik, String ku, DateTime ai, String ki, String vs)
        {
            String ktunnus = en.Substring(0, 3).ToLower() + sn.Substring(0, 5).ToLower();
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO koetiedot (etunimi, sukunimi, kayttajatunnus, salasana, email, ika, kurssi, aika, kieli, vapaa) "+
                "Values (@enm, @snm, @ktu, @ssa, @eml, @ika, @krs, @aik, @kli, @vap);";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = en;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sn;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = ss;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = em;
            komento.Parameters.Add("@ika", MySqlDbType.VarChar).Value = ik;
            komento.Parameters.Add("@krs", MySqlDbType.VarChar).Value = ku;
            komento.Parameters.Add("@aik", MySqlDbType.DateTime).Value = ai;
            komento.Parameters.Add("@kli", MySqlDbType.VarChar).Value = ki;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vs;
            MessageBox.Show("Käyttäjätunnuksesi on " + ktunnus + " kirjoita nämä visusti talteen");

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
