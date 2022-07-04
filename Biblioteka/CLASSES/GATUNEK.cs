using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteka.CLASSES
{
    class GATUNEK
    {
        DATABASE.Database db = new DATABASE.Database();
        //stworz funkcje dodawania

        public Boolean addGatunek(string name)
        {
            string query = "INSERT INTO `gatunki` (`nazwa`) VALUE (@nazwagatunku)";
            string nazwa_gatunku = name;

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@nazwagatunku", MySqlDbType.VarChar);
            param[0].Value = name;

            if(db.SetData(query, param)==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //funkcje edycji

        public Boolean editGatunek(int id, string name)
        {
            string query = "UPDATE `gatunki` SET `nazwa` = @nazwagatunku WHERE `id_gatunki`=@id";
            string nazwa_gatunku = name;

            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("@nazwagatunku", MySqlDbType.VarChar);
            param[0].Value = name;
            param[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[1].Value = id;

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
        public Boolean removeGatunek(int id)
        {
            string query = "DELETE FROM `gatunki` WHERE `id_gatunki`=@id";

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
        //ret tabela
        public DataTable ListaGatunek()
        {
            string query = "SELECT `id_gatunki` AS 'ID', `nazwa` FROM `gatunki`";
            DataTable table = new DataTable();
            table = db.GetData(query, null);
            return table;
        }

        //public DataTable GetGatunek(string wybranyGatunek)
        //{
        //    string query = "SELECT * FROM `gatunki` WHERE @wybranyGatunek";
        //    MySqlParameter[] param = new MySqlParameter[1];
        //    param[0] = new MySqlParameter("@wybranyGatunek", MySqlDbType.String);
        //    param[0].Value = wybranyGatunek;
        //    DataTable table = new DataTable();
        //    table = db.GetData(query, null);
        //    return table;
        //}
    }
}
