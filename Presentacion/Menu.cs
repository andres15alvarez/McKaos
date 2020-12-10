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
    public partial class Menu : Form
    {
        private Form formularioactivo = null;
        public Menu()
        {
            InitializeComponent();
            lblnombre.Text = Usuario.apellido + ", " + Usuario.nombre;
            lbltipo.Text += Usuario.username;
            panelventas.Visible = false;
            panelcompras.Visible = false;
            panelconfiguracion.Visible = false;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            bool visible = !panelventas.Visible;
            panelcompras.Visible = false;
            panelventas.Visible = visible;
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            panelventas.Visible = false;
            panelcompras.Visible = !panelcompras.Visible;
        }

        private void btnprocesarventas_Click(object sender, EventArgs e)
        {
            PProcesarVentas procesarVentas = new PProcesarVentas();
            AbrirFormulario(procesarVentas);
        }

        private void btnestadisticasventas_Click(object sender, EventArgs e)
        {

        }

        private void btnguardarcompras_Click(object sender, EventArgs e)
        {

        }

        private void btnestadisticascompras_Click(object sender, EventArgs e)
        {

        }

        private void btninventario_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Hide();
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void btncrearusuario_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizarusuario_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(Form form)
        {
            if (formularioactivo != null)
                formularioactivo.Close();
            formularioactivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelcontenedor.Controls.Add(form);
            panelcontenedor.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
