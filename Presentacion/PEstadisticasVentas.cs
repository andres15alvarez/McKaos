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
    public partial class PEstadisticasVentas : Form
    {
        public PEstadisticasVentas()
        {
            InitializeComponent();
            dtpfechainicial.Value = DateTime.Today;
            dtpfechainicial.MaxDate = dtpfechainicial.Value;
            dtpfechafinal.Value = DateTime.Today;
            dtpfechafinal.MaxDate = dtpfechafinal.Value;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {

        }

        private void btnestadisticasdolar_Click(object sender, EventArgs e)
        {

        }
    }
}
