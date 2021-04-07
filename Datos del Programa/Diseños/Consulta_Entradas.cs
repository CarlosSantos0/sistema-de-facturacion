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
    public partial class Consulta_Entradas : Form
    {
        Mercancia mercancia = new Mercancia();
        Producto producto = new Producto();
        Proveedor proveedor = new Proveedor();

        List<int> ListaProducto = new List<int>();
        List<int> ListaProveedores = new List<int>();

        public Consulta_Entradas()
        {
            InitializeComponent();
            DataGridEntradas.DataSource = ConsultaProcesos.MostrarEntradas();
            producto.ObtenerListasDeProductos(ref ListaProducto, ref CMBProducto);
            proveedor.ObtenerLista(ref ListaProveedores, ref CMBProveedor);
        }

        private void CMBProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CMBProducto.SelectedIndex != -1)
            DataGridEntradas.DataSource = ConsultaProcesos.BuscarEntradaConFiltro(ListaProducto[CMBProducto.SelectedIndex]);
        }

        private void CMBProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CMBProveedor.SelectedIndex != -1)
            DataGridEntradas.DataSource = ConsultaProcesos.BuscarEntradaPorProveedor(ListaProducto[CMBProveedor.SelectedIndex]);
        }

        private void DateTimeEntrada_ValueChanged(object sender, EventArgs e)
        {
            DataGridEntradas.DataSource = ConsultaProcesos.BuscarEntradaConFiltro(DateTimeEntrada.Value);
        }

        private void BtnBorrarFiltros_Click(object sender, EventArgs e)
        {
            DataGridEntradas.DataSource = ConsultaProcesos.MostrarEntradas();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            DataGridEntradas.DataSource = ConsultaProcesos.MostrarEntradas();
            CMBProducto.SelectedIndex = -1;
            CMBProveedor.SelectedIndex = -1;
            DateTimeEntrada.Value = DateTime.Now;
        }

       
    }
}
