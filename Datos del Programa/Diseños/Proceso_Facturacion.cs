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
    public partial class Proceso_Facturacion : Form
    {
        int ID_Cliente;
        int ID_Producto;
        Cliente cliente = new Regular();
        List<int> ListaClientes = new List<int>();
        List<int> ListaProductos = new List<int>();
        DataTable tabla = new DataTable();

        public Proceso_Facturacion()
        {
            InitializeComponent();
            cliente.GenerarMovimiento();
            cliente.ObtenerLista(ref ListaClientes, ref CMBNombreCliente);
            cliente.factura.producto.ObtenerListasDeProductos(ref ListaProductos, ref CMBNombreProducto);

            tabla.Columns.Add("ID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Importe");
            
            DataGridProductos.DataSource = tabla;

        }

        #region Modulo Cliente
        private bool ComprobarDatosIDCliente()
        {
            bool confirmacion = false;
            try { ID_Cliente = int.Parse(TBoxIDCliente.Text);
                confirmacion = true;
            }
            catch { }
            return confirmacion;

        }

        private void RellenarTextBoxCliente()
        {
            TBoxIDCliente.Text = cliente.ID.ToString();
            CMBNombreCliente.Text = cliente.Nombre;
            LblIdentificacionCliente.Text = cliente.Cedula_RNC.ToString();
            LblTelefonoCliente.Text = cliente.Telefono.ToString();
            if (cliente.Categoria == 0)
            {
                LblCategoriaCliente.Text = "Regular";
            }
            else
            {
                LblCategoriaCliente.Text = "Premium";
            }
        }

        private void TBoxIDCliente_TextChanged(object sender, EventArgs e)
        {
            if (TBoxIDCliente.Text != "" && ComprobarDatosIDCliente())
            {
                if (cliente.BuscarCliente(ID_Cliente))
                {
                    if (cliente.Categoria == 0)
                    {
                        cliente = new Regular();
                    }
                    else
                    {
                        cliente = new Premium();
                    }
                    
                    cliente.BuscarCliente(ID_Cliente);
                    cliente.GenerarMovimiento();
                    RellenarTextBoxCliente();
                }
               
                
            }
        }
   

        private void CMBNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                if (cliente.BuscarCliente(ListaClientes[CMBNombreCliente.SelectedIndex]))
                {
                    RellenarTextBoxCliente();
                }
             

            
        }

        #endregion


        #region Modulo Productos


        private bool ComprobarDatosIDProducto()
        {
            bool confirmacion = false;
            try
            {
                 ID_Producto = int.Parse(TBoxIDProducto.Text);
                confirmacion = true;
            }
            catch { }
            return confirmacion;

        }

        private void RellenarTextBoxProducto()
        {
            TBoxIDProducto.Text = cliente.factura.producto.ID.ToString();
            CMBNombreProducto.Text = cliente.factura.producto.Nombre.ToString();
            LblPrecioProducto.Text = cliente.factura.producto.Precio.ToString();
            LblCantidadProducto.Text = cliente.factura.producto.cantidad.ToString();
            NumericProductos.Value = 0;
            NumericProductos.Maximum = cliente.factura.producto.cantidad;
        }

        private void TBoxIDProducto_TextChanged(object sender, EventArgs e)
        {

            if (TBoxIDProducto.Text != "" && ComprobarDatosIDProducto())
            {
                if (cliente.factura.producto.BuscarProducto(ID_Producto))
                {
                    RellenarTextBoxProducto();
                }
            }

        }
        private void CMBNombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cliente.factura.producto.BuscarProducto(ListaProductos[CMBNombreProducto.SelectedIndex]))
            {
                RellenarTextBoxProducto();
            }
        }

        #endregion


        private void AgregarProductoATabla()
        {
            DataRow fila = tabla.NewRow();

            fila[0] = cliente.factura.producto.ID;
            fila[1] = cliente.factura.producto.Nombre;
            fila[2] = cliente.factura.producto.Precio;
            fila[3] = cliente.factura.producto.cantidad;
            fila[4] = cliente.factura.producto.Precio * cliente.factura.producto.cantidad;

            tabla.Rows.Add(fila);

            DataGridProductos.DataSource = tabla;
        }


        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cliente.ID != 0)
            {
                if (cliente.factura.producto.ID != 0 && NumericProductos.Value != 0)
                {

                    cliente.factura.producto.cantidad = int.Parse(NumericProductos.Value.ToString());
                    if (cliente.factura.AñadirProducto())
                    {
                        cliente.CalcularFactura();
                        RellenarTextBoxImporte();
                        AgregarProductoATabla();
                        cliente.factura.GenerarNuevoProducto();
                        LimpiarTextBoxProductos();
                    }
                    else
                    {
                        MessageBox.Show("Ya el producto esta ingresado");
                    }


                }
                else
                {
                    MessageBox.Show("Debe de Elegir el Producto y la Cantidad a Llevar");
                } 
            }
            else
            {
                MessageBox.Show("Debe de Elegir el cliente");
                LimpiarTextBoxProductos();
            }

        }

        
        private void RellenarTextBoxImporte()
        {
            LblSubTotal.Text = cliente.factura.Subtotal.ToString() +"$";
            LblProductoItbis.Text = cliente.factura.ITBIS.ToString() + "$";
            LblDescuentoPremium.Text = cliente.factura.DescuentoPremium.ToString() + "$";
            LblTotalImporte.Text = cliente.factura.Importe.ToString() +"$";
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DataGridProductos.SelectedRows.Count > 0)
            {
               ID_Producto = int.Parse(DataGridProductos.CurrentRow.Cells["ID"].Value.ToString());
             

                tabla.AcceptChanges();
                foreach(DataRow row in tabla.Rows)
                {
                    if(row[0].ToString() == ID_Producto.ToString()){
                        row.Delete();
                    }
                }

                cliente.factura.EliminarProducto(ID_Producto);
                DataGridProductos.DataSource = tabla;
                LimpiarTextBoxProductos();
                cliente.CalcularFactura();
                RellenarTextBoxImporte();
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }

        private void BtnGenerarFactura_Click(object sender, EventArgs e)
        { 

           if( cliente.RegistrarMovimiento())
                MessageBox.Show("Factura Realizada Con Exito!!");
        }

        private void BtnNuevaFactura_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxCliente();
            LimpiarTextBoxProductos();
            LimpiarImporte();
            LimpiarTabla();
            cliente = new Regular();
            cliente.GenerarMovimiento();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Form inventario = new Mostrar_Inventario();
            inventario.Show();
        }

        private void BtnVerClientes_Click(object sender, EventArgs e)
        {
            Form VerCliente = new Consulta_Clientes();
            VerCliente.Show();
        }

        private void BtnAplicarDescuento_Click(object sender, EventArgs e)
        {
            cliente.CalcularFactura();
            RellenarTextBoxImporte();
        }

        private void LimpiarTextBoxCliente()
        {
            TBoxIDCliente.Text = "";
            CMBNombreCliente.Text = "";
            LblCategoriaCliente.Text = "";
            LblIdentificacionCliente.Text = "";
            LblTelefonoCliente.Text = "";

        }

        private void LimpiarTextBoxProductos()
        {
            LblCantidadProducto.Text = "";
            LblPrecioProducto.Text = "";
            TBoxIDProducto.Text = "";
            CMBNombreProducto.Text = "";
            NumericProductos.Value = 0;
        }

        private void LimpiarImporte()
        {
            LblTotalImporte.Text = "0";
            LblProductoItbis.Text = "0";
            LblDescuentoPremium.Text = "0";
            LblSubTotal.Text = "0";
        }

        private void LimpiarTabla()
        {
            tabla.Clear();
          

            DataGridProductos.DataSource = tabla;
        }

    }
}
