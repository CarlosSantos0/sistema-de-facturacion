using Sistema_de_Facturacion.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturacion.Diseños
{
    public partial class Consulta_Productos : Form
    {
        Producto producto = new Producto(); 

        public Consulta_Productos()
        {
            InitializeComponent();
            DataGridProductos.DataSource = producto.BuscarProductosConFiltro("");
        }

        private void TBoxNombreProducto_TextChanged(object sender, EventArgs e)
        {
            DataGridProductos.DataSource = producto.BuscarProductosConFiltro(TBoxNombreProducto.Text);
        }

      

    }
}
