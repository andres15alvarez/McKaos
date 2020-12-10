using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DProcesarVentas
    {
        MySql.Conector bd = new MySql.Conector();
        public DataTable Buscar(string codigo)
        {
            bd.Conectar();
            string query = String.Format("SELECT codigo, nombre, cantidad, precio_bolivar, precio_dolar FROM producto WHERE codigo='{0}'", codigo);
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, bd.con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "producto");
            DataTable dataTable = ds.Tables["producto"];
            bd.Desconectar();
            return dataTable;       
        }
    }
}
