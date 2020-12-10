using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySql
{
    public class Conector
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        
        public Conector()
        {
            con = new MySqlConnection("server=localhost; database=mckaos; uid=root; password=068856187030");
        }

        public void Conectar()
        {
            con.Open();
        }

        public void Desconectar()
        {
            con.Close();
        }
    }
}
