using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Biblioteka.CLASSES
{
    class CZYTELNIK
    {
        DATABASE.Database db = new DATABASE.Database();

        public Boolean addCzytelnik(string name, string lname, string gender, string telefon, string email)
        {
            string query = "INSERT INTO `czytelnicy` (`imie`,`nazwisko`,`gender`,`telefon`,`email`) VALUE (@imie,@nazwisko,@gender,@telefon,@email)";


            MySqlParameter[] param = new MySqlParameter[5];
            param[0] = new MySqlParameter("@imie", MySqlDbType.VarChar);
            param[0].Value = name;
            param[1] = new MySqlParameter("@nazwisko", MySqlDbType.VarChar);
            param[1].Value = lname;
            param[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            param[2].Value = gender;
            param[3] = new MySqlParameter("@telefon", MySqlDbType.VarChar);
            param[3].Value = telefon;
            param[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            param[4].Value = email;

            if (db.SetData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean editCzytelnik(int id,string name, string lname, string gender, string telefon, string email)
        {
            string query = "UPDATE `czytelnicy` SET `imie` = @imie, `nazwisko`=@nazwisko, `gender`=@gender, `telefon`=@telefon,`email`=@email WHERE `id_czytelnicy`=@id";


            MySqlParameter[] param = new MySqlParameter[6];
            param[0] = new MySqlParameter("@imie", MySqlDbType.VarChar);
            param[0].Value = name;
            param[1] = new MySqlParameter("@nazwisko", MySqlDbType.VarChar);
            param[1].Value = lname;
            param[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            param[2].Value = gender;
            param[3] = new MySqlParameter("@telefon", MySqlDbType.VarChar);
            param[3].Value = telefon;
            param[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            param[4].Value = email;
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

        public Boolean removeCzytelnik(int id)
        {
            string query = "DELETE FROM `czytelnicy` WHERE `id_czytelnicy`=@id";

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

        //czytelnicy z pelnym imieniem i nazwiskiem
        public DataTable ListaCzytelnik1()
        {
            string query = "SELECT `id_czytelnicy`, Concat(`imie`,' ',`nazwisko`) as fullname FROM `czytelnicy`";
            DataTable table = new DataTable();
            table = db.GetData(query, null);
            return table;
        }
        //wszyscy czytelnicy
        public DataTable ListaCzytelnik()
        {
            string query = "SELECT `id_czytelnicy` AS 'ID', `imie`, `nazwisko`, `gender` AS 'płeć', `telefon`, `email` FROM `czytelnicy`";
            DataTable table = new DataTable();
            table = db.GetData(query, null);
            return table;
        }
        //czytelnicy po id
        public DataTable ListaCzytelnikPoID(int id)
        {
            string query = "SELECT * FROM `czytelnicy` WHERE id_czytelnicy=@id";

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = id;

            DataTable table = new DataTable();
            table = db.GetData(query, param);

            return table;
        }

        //zwraca czytelnika po id
        public DataTable getCzytelnikPoID(int id)
        {
            string query = "SELECT * FROM `czytelnicy` WHERE `id_czytelnicy`=@id";

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = id;

            DataTable table = new DataTable();
            table = db.GetData(query, param);

            return table;
        }
    }
}
