using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteka.CLASSES
{
    class WYPOZYCZENIE
    {
        DATABASE.Database db = new DATABASE.Database();
        KSIAZKA ksiazka = new KSIAZKA();

        public Boolean addWypozyczenie(int IdKsiazki, int IdCzytelnika, string status, DateTime DataWypozyczenia, DateTime DataOddania)
        {
            string query = "INSERT INTO `wypozyczenia` " +
                "(`ksiazka_id`,`czytelnik_id`,`status`,`data_wypozyczenia`,`data_oddania`) " +
                "VALUE (@IdK,@IdC,@status,@Dwyp,@Dodd)";


            MySqlParameter[] param = new MySqlParameter[5];
            param[0] = new MySqlParameter("@IdK", MySqlDbType.Int32);
            param[0].Value = IdKsiazki;
            param[1] = new MySqlParameter("@IdC", MySqlDbType.Int32);
            param[1].Value = IdCzytelnika;
            param[2] = new MySqlParameter("@status", MySqlDbType.VarChar);
            param[2].Value = status;
            param[3] = new MySqlParameter("@Dwyp", MySqlDbType.Date);
            param[3].Value = DataWypozyczenia;
            param[4] = new MySqlParameter("@Dodd", MySqlDbType.Date);
            param[4].Value = DataOddania;

            if (db.SetData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ileWypozyczenKsiazki(int idKsiazki)
        {
            string query = "SELECT * FROM `wypozyczenia` WHERE `ksiazka_id`=@id";

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = idKsiazki;

            return db.GetData(query,param).Rows.Count;
        }
        public Boolean czyKsiazkaDostepna(int idKsiazki)
        {
            Boolean dostepna = false;
            //ilosc ksiazek
            string query = "SELECT `ilosc` FROM `ksiazki` WHERE `id_ksiazki`=@id";
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = idKsiazki;

            DataTable table = db.GetData(query, param);
            int iloscKsiazek = Convert.ToInt32(table.Rows[0][0].ToString());

            //ilosc wypozyczen
            int iloscWypozyczen = ileWypozyczenKsiazki(idKsiazki);


            if(iloscKsiazek > iloscWypozyczen)
            {
                dostepna = true;
            }
            return dostepna;
        }
        //wszystkie wypozyczenia na podstawie statusu
        public DataTable ListaWypozyczen(string status)
        {
            string query="SELECT * FROM `wypozyczenia`";
            if (!status.Equals(""))
            {
                query = "SELECT * FROM `wypozyczenia` WHERE `status` = '"+status+"'";
            }

            DataTable table = new DataTable();
            table = db.GetData(query, null);
            return table;
        }
        //oddanie/zgubienie ksiazki
        public bool zwrocKsiazke(int IdKsiazki, int IdCzytelnika, string status, DateTime DataWypozyczenia, DateTime DataOddania)
        {
            string query = "UPDATE `wypozyczenia` SET `status`=@status,`data_oddania`=@Dodd WHERE `ksiazka_id`=@IdK AND `czytelnik_id`=@IdC AND `data_wypozyczenia`=@Dwyp";


            MySqlParameter[] param = new MySqlParameter[5];
            param[0] = new MySqlParameter("@status", MySqlDbType.VarChar);
            param[0].Value = status;
            param[1] = new MySqlParameter("@Dodd", MySqlDbType.Date);
            param[1].Value = DataOddania;
            param[2] = new MySqlParameter("@IdK", MySqlDbType.Int32);
            param[2].Value = IdKsiazki;
            param[3] = new MySqlParameter("@IdC", MySqlDbType.Int32);
            param[3].Value = IdCzytelnika;
            param[4] = new MySqlParameter("@Dwyp", MySqlDbType.Date);
            param[4].Value = DataWypozyczenia;

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
        public Boolean removeWypozyczenie(int id)
        {
            string query = "DELETE FROM `wypozyczenia` WHERE `id_wypozyczenia`=@id";

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
        //sprawdzenie czy ksiazka jest wypozyczona przez danego czytelnika
        public Boolean czyKsiazkaWypozyczonaCzytelnikowi(int czytelnikID, int ksiazkaID)
        {
            string query = "SELECT * FROM `wypozyczenia` WHERE `status`='wypożyczono' AND `ksiazka_id`=@IdK AND `czytelnik_id`=@IdC";

            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("@IdK", MySqlDbType.Int32);
            param[0].Value = ksiazkaID;
            param[1] = new MySqlParameter("@IdC", MySqlDbType.Int32);
            param[1].Value = czytelnikID;

            DataTable table = db.GetData(query, param);
            if (table.Rows.Count >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
