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
    public partial class Proceso_Mercancia : Form
    {
        List<int> ListaProveedor = new List<int>();
        List<int> ListaProductos = new List<int>();
        Proveedor proveedor = new Proveedor();

        public Proceso_Mercancia()
        {
            InitializeComponent();
            proveedor.GenerarMovimiento();
            proveedor.mercancia.producto.ObtenerListasDeProductos(ref ListaProductos, ref CMBProducto);
            proveedor.ObtenerLista(ref ListaProveedor, ref CMBProveedor);
  
            DataGridProveedor.DataSource = ConsultaProcesos.MostrarEntradas(10);
        }

        private bool ComprobarDatos()
        {
            bool confirmacion = false;

            if(CMBProveedor.SelectedIndex > -1)
            {
                if(CMBProducto.SelectedIndex > -1)
                {
                    if(NumCantidadProductos.Value > 0)
                    {
                        proveedor.ID = ListaProveedor[CMBProveedor.SelectedIndex];
                        proveedor.mercancia.producto.ID = ListaProductos[CMBProducto.SelectedIndex];
                        proveedor.mercancia.Cantidad = int.Parse(NumCantidadProductos.Value.ToString());
                        proveedor.mercancia.Fecha = DateTime.Now;
                        LblAdvertencia.Visible = false;
                        LblNotificacion.Text = "Mercancia Agregada con Exito!!";
                        LblNotificacion.Visible = true;
                        confirmacion = true;
                    }
                    else
                    {
                        LblAdvertencia.Text = "Debe de elegir una cantidad mayor a 0 ";
                        LblAdvertencia.Visible = true;
                    }
                }
                else
                {
                    LblAdvertencia.Text = "Debe de seleccionar un Producto";
                    LblAdvertencia.Visible = true;
                }
            }
            else
            {
                LblAdvertencia.Text = "Debe de seleccionar un proveedor";
                LblAdvertencia.Visible = true;
            }

            return confirmacion;
        }  


        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                proveedor.RegistrarMovimiento();
                LimpiarTextBox();
                DataGridProveedor.DataSource = ConsultaProcesos.MostrarEntradas(10);
            }
        }

        private void LimpiarTextBox()
        {
            CMBProducto.SelectedIndex = -1;
            CMBProveedor.SelectedIndex = -1;
            NumCantidadProductos.Value = 0;
        }

        private void VerInventario_Click(object sender, EventArgs e)
        {
            Form Inventario = new Mostrar_Inventario();
            Inventario.Show();
        }
    }
}
