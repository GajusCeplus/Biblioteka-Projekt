using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.CLASSES
{
    class UZYTKOWNIK
    {
        DATABASE.Database db = new DATABASE.Database();

        public Boolean addUser(string name, string lname, string login, string haslo, string userType)
        {
            string query = "INSERT INTO `uzytkownicy` (`imie`,`nazwisko`,`login`,`haslo`,`typ_uzytkownika`) VALUE (@imie,@nazwisko,@login,@haslo,@typU)";


            MySqlParameter[] param = new MySqlParameter[5];
            param[0] = new MySqlParameter("@imie", MySqlDbType.VarChar);
            param[0].Value = name;
            param[1] = new MySqlParameter("@nazwisko", MySqlDbType.VarChar);
            param[1].Value = lname;
            param[2] = new MySqlParameter("@login", MySqlDbType.VarChar);
            param[2].Value = login;
            param[3] = new MySqlParameter("@haslo", MySqlDbType.VarChar);
            param[3].Value = haslo;
            param[4] = new MySqlParameter("@typU", MySqlDbType.VarChar);
            param[4].Value = userType;


            if (db.SetData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //funkcje edycji

        public Boolean editUser(int id, string imie, string nazwisko, string login, string haslo, string userType)
        {
            string query = "UPDATE `uzytkownicy` SET `imie` = @imie, `nazwisko`=@nazwisko, " +
                "`login`=@login, `haslo`=@haslo, `typ_uzytkownika`=@typU WHERE `id_uzytkownicy`=@id";

            MySqlParameter[] param = new MySqlParameter[6];
            param[0] = new MySqlParameter("@imie", MySqlDbType.VarChar);
            param[0].Value = imie;
            param[1] = new MySqlParameter("@nazwisko", MySqlDbType.VarChar);
            param[1].Value = nazwisko;
            param[2] = new MySqlParameter("@login", MySqlDbType.VarChar);
            param[2].Value = login;
            param[3] = new MySqlParameter("@haslo", MySqlDbType.VarChar);
            param[3].Value = haslo;
            param[4] = new MySqlParameter("@typU", MySqlDbType.VarChar);
            param[4].Value = userType;
            param[5] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[5].Value = id;

            if (db.SetData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //usun
        public Boolean removeUser(int id)
        {
            string query = "DELETE FROM `uzytkownicy` WHERE `id_uzytkownicy`=@id";

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = id;

            if (db.SetData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //wszyscy uzytkownicy
        //nie wyswietla bibliotekarza (wlasciciela/glownego admina)
        public DataTable ListaUser()
        {
            string query = "SELECT * FROM `uzytkownicy` WHERE `typ_uzytkownika`!='bibliotekarz'";
            DataTable table = new DataTable();
            table = db.GetData(query, null);
            return table;
        }

        //weryfikacja danych w apce
        public bool Weryfikacja(string imie, string nazwisko, string login, string haslo, string rehaslo)
        {
            if (imie.Equals("") || nazwisko.Equals("") || login.Equals("") || haslo.Equals("") || rehaslo.Equals(""))
            {
                return false;
            }
            else if (!haslo.Equals(rehaslo))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //czy login juz zajety
        public Boolean czyLoginJuzIstnieje(string login, int id)
        {
            string query = "SELECT * FROM `uzytkownicy` WHERE `login`=@login AND `id_uzytkownicy`!=@id";

            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("@login", MySqlDbType.VarChar);
            param[0].Value = login;
            param[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[1].Value = id;

            DataTable table = new DataTable();
            table = db.GetData(query, param);
            
            if(table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
