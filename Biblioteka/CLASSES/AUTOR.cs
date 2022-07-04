using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Biblioteka.CLASSES
{
    class AUTOR
    {
        DATABASE.Database db = new DATABASE.Database();

        public Boolean addAutor(string name, string lname )
        {
            string query = "INSERT INTO `autorzy` (`imie`,`nazwisko`) VALUE (@imie,@nazwisko)";
            

            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("@imie", MySqlDbType.VarChar);
            param[0].Value = name;
            param[1] = new MySqlParameter("@nazwisko", MySqlDbType.VarChar);
            param[1].Value = lname;

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

        public Boolean editAutor(int id, string imie, string nazwisko)
        {
            string query = "UPDATE `autorzy` SET `imie` = @imie, `nazwisko`=@nazwisko WHERE `id_autorzy`=@id";
            string name = imie;
            string lname = nazwisko;

            MySqlParameter[] param = new MySqlParameter[3];
            param[0] = new MySqlParameter("@imie", MySqlDbType.VarChar);
            param[0].Value = name;
            param[1] = new MySqlParameter("@nazwisko", MySqlDbType.VarChar);
            param[1].Value = lname;
            param[2] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[2].Value = id;

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
        public Boolean removeAutor(int id)
        {
            string query = "DELETE FROM `autorzy` WHERE `id_autorzy`=@id";

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
        //autorzy z pelnym imieniem i nazwiskiem
        public DataTable ListaAutor1()
        {
            string query = "SELECT `id_autorzy`, Concat(`imie`,' ',`nazwisko`) as fullname FROM `autorzy`";
            DataTable table = new DataTable();
            table = db.GetData(query, null);
            return table;
        }
        //wszyscy autorzy
        public DataTable ListaAutor()
        {
            string query = "SELECT `id_autorzy` AS 'ID', `imie`, `nazwisko` FROM `autorzy`";
            DataTable table = new DataTable();
            table = db.GetData(query, null);
            return table;
        }
        //autorzy po id
        public DataTable ListaAutorPoID(int id)
        {
            string query = "SELECT * FROM `autorzy` WHERE id_autorzy=@id";

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = id;

            DataTable table = new DataTable();
            table = db.GetData(query, param);

            return table;
        }
    }
}
