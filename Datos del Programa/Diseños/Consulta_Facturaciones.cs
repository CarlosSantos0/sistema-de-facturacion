using Sistema_de_Facturacion.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturacion.Diseños
{
    public partial class Consulta_Facturaciones : Form
    {
       

        public Consulta_Facturaciones()
        {
            InitializeComponent();
            DataGridFactura.DataSource = ConsultaProcesos.BuscarFacturaConFiltro("");
        }

        private void DateFactura_ValueChanged(object sender, EventArgs e)
        {
            DataGridFactura.DataSource = ConsultaProcesos.BuscarFacturaConFiltro(DateFactura.Value);
        }

        private void TBoxNombreCliente_TextChanged(object sender, EventArgs e)
        {
            DataGridFactura.DataSource = ConsultaProcesos.BuscarFacturaConFiltro(TBoxNombreCliente.Text);
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TBoxNombreCliente.Text = "";
            DateFactura.Value = DateTime.Now;
            DataGridFactura.DataSource = ConsultaProcesos.BuscarFacturaConFiltro("");
            
        }
    }
}
