using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class PProcesarVentas : Form
    {
        LProcesarVentas lProcesarVentas = new LProcesarVentas();
        public PProcesarVentas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PProcesarVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            gdvproducto.DataSource = lProcesarVentas.Buscar(txtcodigo.Text);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            lProcesarVentas.AgregarProducto(txtcantidad.Value);
            var datos = lProcesarVentas.GetDatos();
            lvcarrito.Items.Add(datos.nombre);
            string precio = datos.precioBolivar.ToString();
            lvcarrito.Items.Add(precio);
            string cantidad = datos.cantidad.ToString();
            lvcarrito.Items.Add(cantidad);
            double result = datos.precioBolivar * datos.cantidad;
            string resultado = result.ToString();
            lvcarrito.Items.Add(resultado);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lProcesarVentas.LimpiarCarrito();
            lvcarrito.Clear();
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {

        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {

        }

        private void btnfacturar_Click(object sender, EventArgs e)
        {

        }

        private void gdvproducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = gdvproducto.CurrentRow.Cells[0].Value.ToString();
            string nombre = gdvproducto.CurrentRow.Cells[1].Value.ToString();
            double precioBolivar = double.Parse(gdvproducto.CurrentRow.Cells[3].Value.ToString());
            double precioDolar = double.Parse(gdvproducto.CurrentRow.Cells[4].Value.ToString());
            lProcesarVentas.GuardarDatos(codigo, nombre, precioBolivar, precioDolar);
        }
    }
}
