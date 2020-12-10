using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class LInicio
    {
        DInicio DInicio = new DInicio();

        public LInicio() { }

        public bool InicioSesion(string username, string password)
        {         
            var resultado = DInicio.IniciarSesion(username, password);
            if (resultado.resultado)
            {
                Usuario.username = username;
                Usuario.nombre = resultado.nombre;
                Usuario.apellido = resultado.apellido;
                Usuario.tipo = resultado.tipo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
