using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Validaciones
    {
        public void ValidarNro(string cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsDigit(cadena[i]))
                {
                    // TODO EN ORDEN
                }
                else
                {
                    entry.Text = cadena.Remove(cadena.Length - 1);
                    entry.SelectionStart = cadena.Length;
                }
            }
        }
    }
}
