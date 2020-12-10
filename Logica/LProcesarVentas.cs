using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class LProcesarVentas
    {
        DProcesarVentas dProcesarVentas = new DProcesarVentas();
        public List<CarritoVenta> listCarrito = new List<CarritoVenta>();
        string codigo; string nombre; double precioBolivar; double precioDolar;
        public DataTable Buscar(string codigo)
        {
            DataTable tabla = dProcesarVentas.Buscar(codigo);
            return tabla;
        }

        public void GuardarDatos(string codigoA, string nombreA, double precioBolivarA, double precioDolarA)
        {
            codigo = codigoA;
            nombre = nombreA;
            precioBolivar = precioBolivarA;
            precioDolar = precioDolarA;
        }

        public void AgregarProducto(decimal cantidad)
        {
            int cantidadI = Convert.ToInt32(cantidad);
            CarritoVenta carrito = new CarritoVenta();
            carrito.codigo = codigo;
            carrito.nombre = nombre;
            carrito.precioBolivar = precioBolivar;
            carrito.precioDolar = precioDolar;
            carrito.cantidad = cantidadI;
            listCarrito.Add(carrito);
        }

        public void LimpiarCarrito()
        {
            listCarrito.Clear();
        }

        public (string nombre, double precioBolivar, int cantidad) GetDatos()
        {
            int index = listCarrito.Count - 1;
            string nombre = listCarrito[index].nombre;
            double precioBolivar = listCarrito[index].precioBolivar;
            int cantidad = listCarrito[index].cantidad;
            return (nombre, precioBolivar, cantidad);
        }
    }
}
