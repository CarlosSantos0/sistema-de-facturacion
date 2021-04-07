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
    public partial class Consultar_Proveedores : Form
    {
        Proveedor proveedor = new Proveedor();

        public Consultar_Proveedores()
        {
            InitializeComponent();
            DataGridProveedores.DataSource = proveedor.MostrarRegistros();
        }

        private void TBoxNombreProveedores_TextChanged(object sender, EventArgs e)
        {
            DataGridProveedores.DataSource = proveedor.BuscarConFiltro(TBoxNombreProveedores.Text);
        }

        private void TBoxEmailProveedor_TextChanged(object sender, EventArgs e)
        {
            DataGridProveedores.DataSource = proveedor.BuscarProveedorPorEmail(TBoxEmailProveedor.Text);
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            DataGridProveedores.DataSource = proveedor.MostrarRegistros();
            TBoxEmailProveedor.Text = "";
            TBoxNombreProveedores.Text = "";
        }
    }
}
