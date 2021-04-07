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
    public partial class Mantenimiento_Productos : Form
    {
        Producto producto = new Producto();

        public Mantenimiento_Productos()
        {
            InitializeComponent();
            DataGridProductos.DataSource = producto.MostrarRegistros();

        }

        #region Funciones CRUD

        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                if (producto.IngresarRegistro())
                {
                    DataGridProductos.DataSource = producto.MostrarRegistros();
                    LblNotificacion.Text = "Producto añadido con exito";
                    LblNotificacion.Visible = true;
                }
                else
                {
                    LblNotificacion.Text = "Error al Introducir el Producto";
                    LblNotificacion.Visible = true;
                }
            }
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            if (DataGridProductos.SelectedRows.Count > 0)
            {
                if (ComprobarDatos())
                {
                    if (producto.ActualizarRegistro())
                    {
                        DataGridProductos.DataSource = producto.MostrarRegistros();
                        LblAdvertencia.Visible = false;
                        LblNotificacion.Text = "Producto actualizado correctamente";
                        LblNotificacion.Visible = true;
                        LimpiarTextBox();
                    }
                    else
                    {
                        LblNotificacion.Text = "Error al Actualizar el producto";
                        LblNotificacion.Visible = true;
                    }
                }
            }
            else
            {
                LblAdvertencia.Text = "Debe de elegir un Producto Primero";
                LblAdvertencia.Visible = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridProductos.SelectedRows.Count > 0)
            {
                if (producto.EliminarRegistro())
                {
                    LimpiarTextBox();
                    DataGridProductos.DataSource = producto.MostrarRegistros();
                    LblAdvertencia.Visible = false;
                    LblNotificacion.Text = "Producto Eliminado Correctamente";
                    LblNotificacion.Visible = true;
                }
                else
                {
                    LblAdvertencia.Text = "No se puede Eliminar porque hay tablas \n que depende de este producto";
                    LblAdvertencia.Visible = true;
                }

            }
            else
            {
                LblAdvertencia.Text = "Debe de elegir un Producto Primero";
                LblAdvertencia.Visible = true;
            }
        }

        // -> Control y Confirmacion de Textos y Selecciones
        private bool ComprobarDatos()
        {
            bool confirmacion = false;
            if (TBoxNombre.Text == "" || TBoxPrecio.Text == "")
            {
                LblAdvertencia.Text = "Porfavor Rellene todos los campos";
                LblAdvertencia.Visible = true;
            }
            else
            {
                try
                {
                    producto.Precio = double.Parse(TBoxPrecio.Text);
                    producto.Nombre = TBoxNombre.Text;
                    LblAdvertencia.Visible = false;
                    confirmacion = true;
                }
                catch
                {
                    LblAdvertencia.Text = "El campo Precio Solo Acepta Numeros";
                    LblAdvertencia.Visible = true;
                }
            }
            return confirmacion;
        }

        #endregion



        // -> Control de Selecciones
        private void DataGridProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridProductos.SelectedRows.Count > 0)
            {
                try
                {
                    producto.ID = int.Parse(DataGridProductos.CurrentRow.Cells["ID"].Value.ToString());
                    producto.Nombre = DataGridProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                    producto.Precio = double.Parse(DataGridProductos.CurrentRow.Cells["Precio"].Value.ToString());

                }
                catch { }
                RellenarTextBox();
            }
        }
        
        // -> Llenar y limpiar datos
        private void RellenarTextBox()
        {
            LblID.Text = producto.ID.ToString();
            TBoxNombre.Text = producto.Nombre;
            TBoxPrecio.Text = producto.Precio.ToString();
        }

        private void LimpiarTextBox()
        {
            LblID.Text = "";
            TBoxNombre.Text = "";
            TBoxPrecio.Text = "";
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
    }
}
