using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DInicio
    {
        MySql.Conector bd = new MySql.Conector();

        public bool VerificarExistencia(string username)
        {
            bd.Conectar();
            string query = String.Format("SELECT username FROM usuario WHERE username = '{0}';", username);
            bd.cmd = new MySqlCommand(query, bd.con);
            var resultado = bd.cmd.ExecuteScalar();
            if ((resultado != null) && (username == Convert.ToString(resultado)))
            {
                bd.Desconectar();
                return true;
            }
            else
            {
                bd.Desconectar();
                return false;
            }
        }

        public (bool resultado, string nombre, string apellido, string tipo) IniciarSesion(string username, string password)
        {
            bd.Conectar();
            string query = String.Format("SELECT * FROM usuario WHERE username='{0}' AND password=AES_ENCRYPT('{1}', 'Su$y15.');", username, password);
            bd.cmd = new MySqlCommand(query, bd.con);
            bd.dr = bd.cmd.ExecuteReader();
            if (bd.dr.Read())
            {

                string nombre = bd.dr[3].ToString();
                string apellido = bd.dr[4].ToString();
                string tipo = bd.dr[6].ToString();
                bd.dr.Close();
                bd.Desconectar();
                return (true, nombre, apellido, tipo);
            }
            else
            {
                bd.dr.Close();
                bd.Desconectar();
                return (false, "", "", "");
            }

        }
    }
}
