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
    public partial class PInicio : Form
    {
        LInicio LInicio = new LInicio();
        private bool passwordChar = true;
        public PInicio()
        {
            InitializeComponent();
            iconButton1.FlatAppearance.BorderSize = 0;
        }

        private void PInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtclave.UseSystemPasswordChar = !passwordChar;
            passwordChar = !passwordChar;
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text == "" || txtclave.Text == "")
            {
                lbladvertencia.Text = "Debe llenar todos los campos";
            }
            if(LInicio.InicioSesion(txtusuario.Text, txtclave.Text))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                lbladvertencia.Text = "Datos incorrestos. Por favor verifique";
                txtclave.Clear();
            }
        }
    }
}
