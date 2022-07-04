using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Biblioteka.CLASSES
{

    class KSIAZKA
    {
        DATABASE.Database db = new DATABASE.Database();

        //dodaj ksiazke
        public Boolean addKsiazka(string isbn, string tytul, int autor_id, int gatunek_id, int ilosc, double cena,string wydawca, DateTime data_otrzymania)
        {
            string query = "INSERT INTO `ksiazki` (`isbn`,`tytul`,`autor_id`,`gatunek_id`,`ilosc`,`cena`,`wydawca`,`data_wydania`) " +
                "VALUES (@isbn,@tytul,@autorid,@gatunekid,@ilosc,@cena,@wydawca,@datao)";


            MySqlParameter[] param = new MySqlParameter[8];
            
            param[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            param[0].Value = isbn;
            param[1] = new MySqlParameter("@tytul", MySqlDbType.VarChar);
            param[1].Value = tytul;
            param[2] = new MySqlParameter("@autorid", MySqlDbType.Int32);
            param[2].Value = autor_id;
            param[3] = new MySqlParameter("@gatunekid", MySqlDbType.Int32);
            param[3].Value = gatunek_id;
            param[4] = new MySqlParameter("@ilosc", MySqlDbType.Int32);
            param[4].Value = ilosc;
            param[5] = new MySqlParameter("@cena", MySqlDbType.Double);
            param[5].Value = cena;
            param[6] = new MySqlParameter("@wydawca", MySqlDbType.VarChar);
            param[6].Value = wydawca;
            param[7] = new MySqlParameter("@datao", MySqlDbType.Date);
            param[7].Value = data_otrzymania.ToString("yyyy-MM-dd HH:mm:ss.fff");

            if (db.SetData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //edytuj ksiazke
        public Boolean editKsiazka(int idk, string isbn, string tytul, int autor_id, int gatunek_id, int ilosc, double cena, string wydawca, DateTime data_wydania)
        {
            string query_edit = "UPDATE `ksiazki` SET `isbn`=@isbn,`tytul`=@tytul,`autor_id`=@autorid," +
                "`gatunek_id`=@gatunekid,`ilosc`=@ilosc,`cena`=@cena,`wydawca`=@wydawca,`data_wydania`=@dto WHERE `id_ksiazki`=@idk";


            MySqlParameter[] param = new MySqlParameter[9];
            param[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            param[0].Value = isbn;
            param[1] = new MySqlParameter("@tytul", MySqlDbType.VarChar);
            param[1].Value = tytul;
            param[2] = new MySqlParameter("@autorid", MySqlDbType.Int32);
            param[2].Value = autor_id;
            param[3] = new MySqlParameter("@gatunekid", MySqlDbType.Int32);
            param[3].Value = gatunek_id;
            param[4] = new MySqlParameter("@ilosc", MySqlDbType.Int32);
            param[4].Value = ilosc;
            param[5] = new MySqlParameter("@cena", MySqlDbType.Double);
            param[5].Value = cena;
            param[6] = new MySqlParameter("@wydawca", MySqlDbType.VarChar);
            param[6].Value = wydawca;
            param[7] = new MySqlParameter("@dto", MySqlDbType.Date);
            param[7].Value = data_wydania;
            param[8] = new MySqlParameter("@idk", MySqlDbType.Int32);
            param[8].Value = idk;

            if (db.SetData(query_edit, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //usun ksiazke
        public Boolean removeKsiazka(int id)
        {
            string query = "DELETE FROM `ksiazki` WHERE `id_ksiazki`=@id";

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
        
        //zmniejsz ilosc ksiazek o 1
        public Boolean iloscMinusJedenKsiazka(int id)
        {
            string query = "UPDATE `ksiazki` SET `ilosc`=ilosc-1 WHERE `id_ksiazki`=@id";

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
        
        //ret tabela ksiazek
        public DataTable ListaKsiazka()
        {
            string query = "SELECT `id_ksiazki` AS 'ID', `isbn` AS 'ISBN', `tytul` AS 'Tytuł', " +
                "`autor_id` AS 'ID autora', `gatunek_id` AS 'ID gatunku', `ilosc` AS 'Ilość', `cena` AS 'Cena'," +
                "`wydawca` AS 'Wydawca', `data_wydania` AS 'Data wydania' FROM `ksiazki` ORDER BY `id_ksiazki` ASC";
            DataTable table = new DataTable();
            table = db.GetData(query, null);
            return table;
        }
        
        //isbn musi byc unikalny
        public Boolean IsISBNExist(string isbn, int id)
        {
            string query = "SELECT * FROM `ksiazki` WHERE `isbn`=@isbn AND `id_ksiazki` != @id";
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("@isbn",MySqlDbType.VarChar);
            param[0].Value = isbn;
            param[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[1].Value = id;
            DataTable table = new DataTable();
            table = db.GetData(query, param);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        
        //tytul musi byc unikalny
        public Boolean isTytulExist(string tytul,int id)
        {
            string query = "SELECT * FROM `ksiazki` WHERE `tytul`=@tytul AND `id_ksiazki` != @id";
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("@tytul", MySqlDbType.VarChar);
            param[0].Value = tytul;
            param[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[1].Value = id;
            DataTable table = new DataTable();
            table = db.GetData(query, param);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        //szukanie ksiazki po id lub isbn
        public DataTable SzukajKsiazkiPo_id_lub_isbn(string id_or_isbn, int? id, string isbn)
        {
            string query;
            MySqlParameter[] param = new MySqlParameter[1];

            if (id_or_isbn.Equals("id"))
            {
                //int id = Convert.ToInt32(id_or_isbn);
                query = "SELECT * FROM `ksiazki` WHERE `id_ksiazki`=@id";
                param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
                param[0].Value = id;
            }
            else
            {
                query = "SELECT * FROM `ksiazki` WHERE `isbn`=@isbn";
                param[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
                param[0].Value = isbn;
            }

            DataTable table = new DataTable();
            table = db.GetData(query, param);
            return table;
        }

        //lista ksiazek autora
        public DataTable ListaKsiazkaAutor(int id_autora)
        {
            string query = "SELECT * FROM `ksiazki` WHERE `autor_id`=@id";
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = id_autora;
            DataTable table = new DataTable();
            table = db.GetData(query, param);
            return table;
        }

        //lista z nazwami autorow i gatunkow
        //public DataTable 

        //lista ksiazek po gatunku
        public DataTable ListaKsiazkaGatunek(int wybranyGatunek)
        {
            string query = "SELECT * FROM `ksiazki` WHERE `gatunek_id`= @gatunek_id";

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@gatunek_id", MySqlDbType.Int32);
            param[0].Value = wybranyGatunek;

            DataTable table = new DataTable();
            table = db.GetData(query, param);
            return table;
        }
    }
    
}

