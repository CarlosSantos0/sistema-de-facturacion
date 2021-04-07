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
    public partial class Mantemiento_Proveedores : Form
    {
        Proveedor proveedor = new Proveedor();
        public Mantemiento_Proveedores()
        {
            InitializeComponent();
            DataGridProveedor.DataSource = proveedor.MostrarRegistros();
           


        }

        // -> Funciones CRUD 

        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                if (proveedor.IngresarRegistro())
                {
                    DataGridProveedor.DataSource = proveedor.MostrarRegistros();
                    LblNotificacion.Text = "Proveedor añadido con exito";
                    LblNotificacion.Visible = true;
                }
                else
                {
                    LblNotificacion.Text = "No pueden haber dos proveedores\ncon el mismo RNC/CEDULA";
                    LblNotificacion.Visible = true;
                }
            }
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            if (DataGridProveedor.SelectedRows.Count > 0)
            {
                if (ComprobarDatos())
                {
                    if (proveedor.ActualizarRegistro())
                    {
                        DataGridProveedor.DataSource = proveedor.MostrarRegistros();
                        LblAdvertencia.Visible = false;
                        LblNotificacion.Text = "Proveedor actualizado correctamente";
                        LblNotificacion.Visible = true;
                    }
                    else
                    {
                        LblNotificacion.Text = "No se pudo actualizar porque hay \nregistros que depende de este proveedor";
                        LblNotificacion.Visible = true;
                    }
                }
            }
            else
            {
                LblAdvertencia.Text = "Debe de elegir un Proveedor primero";
                LblAdvertencia.Visible = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridProveedor.SelectedRows.Count > 0)
            {
                if (proveedor.EliminarRegistro())
                { 
                    LimpiarTextBox();
                DataGridProveedor.DataSource = proveedor.MostrarRegistros();
                LblAdvertencia.Visible = false;
                LblNotificacion.Text = "Proovedor Eliminado Correctamente";
                LblNotificacion.Visible = true; 
                }
                else
                {
                    LblNotificacion.Text = "No se pudo eliminar porque hay \nregistros que depende de este proveedor";
                    LblNotificacion.Visible = true;
                }

            }
            else
            {
                LblAdvertencia.Text = "Debe de elegir un Proveedor primero";
                LblAdvertencia.Visible = true;
            }
        }


        // -> Control y Confirmacion de Textos y Selecciones
        private bool ComprobarDatos()
        {
            bool confirmacion = false;
            if (TBoxIdentificacion.Text == "" || TBoxNombre.Text == "" )
            {
                LblAdvertencia.Text = "Porfavor Rellene los campos importantes\n(RNC/CEDULA y Nombre)";
                LblAdvertencia.Visible = true;
            }
            else
            {
                try
                {
                    proveedor.Cedula_RNC = long.Parse(TBoxIdentificacion.Text);
                    try
                    {
                        if (TBoxTelefono.Text == "")
                        {
                            proveedor.Telefono = 0;
                        }
                        else { proveedor.Telefono = long.Parse(TBoxTelefono.Text); }
                        proveedor.Nombre = TBoxNombre.Text;
                        proveedor.Email = TBoxEmail.Text;
                        LblAdvertencia.Visible = false;
                        
                        confirmacion = true;
                    }
                    catch
                    {
                        LblAdvertencia.Text = "El campo Telefono solo\npuede llevar numeros";
                        LblAdvertencia.Visible = true;
                        
                    }
                  
                }
                catch
                {
                    LblAdvertencia.Text = "El campo RNC/Cedula solo\n puede llevar numeros";
                    LblAdvertencia.Visible = true;
                }
            }
            return confirmacion;
            
        }

        private void DataGridProveedor_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridProveedor.SelectedRows.Count > 0)
            {
                try
                {
                    proveedor.ID = int.Parse(DataGridProveedor.CurrentRow.Cells["ID"].Value.ToString());
                    proveedor.Cedula_RNC = long.Parse(DataGridProveedor.CurrentRow.Cells["RNC/Cedula"].Value.ToString());
                    proveedor.Nombre = DataGridProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                    proveedor.Telefono = long.Parse(DataGridProveedor.CurrentRow.Cells["Telefono"].Value.ToString());
                    proveedor.Email = DataGridProveedor.CurrentRow.Cells["Email"].Value.ToString();

                }
                catch { }
                RellenarTextBox();
            }
        }

        // -> Llenar y limpiar datos
        private void RellenarTextBox()
        {
            LblID.Text = proveedor.ID.ToString();
            TBoxIdentificacion.Text = proveedor.Cedula_RNC.ToString();
            TBoxNombre.Text = proveedor.Nombre;
            TBoxTelefono.Text = proveedor.Telefono.ToString();
            TBoxEmail.Text = proveedor.Email;
        }

        private void LimpiarTextBox()
        {
            LblID.Text = "";
            TBoxNombre.Text = "";
            TBoxIdentificacion.Text = "";
            TBoxTelefono.Text = "";
            TBoxEmail.Text = "";
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
    }
}
