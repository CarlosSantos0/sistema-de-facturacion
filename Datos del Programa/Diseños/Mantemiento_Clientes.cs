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
    public partial class Mantemiento_Clientes : Form
    {
        Cliente cliente = new Regular();

        public Mantemiento_Clientes()
        {
            InitializeComponent();
            DataGridClientes.DataSource = cliente.MostrarRegistros();
            CMBCategoria.Items.Add("Regular");
            CMBCategoria.Items.Add("Premium");
        
        }

        #region Funciones CRUD

        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                if (cliente.IngresarRegistro())
                {
                    DataGridClientes.DataSource = cliente.MostrarRegistros();
                    LblNotificacion.Text = "Cliente añadido con exito";
                    LblNotificacion.Visible = true;
                }
                else
                {
                    LblNotificacion.Text = "Error al agregar - No pueden haber \ndos clientes con el mismo RNC/Cedula";
                    LblNotificacion.Visible = true;
                       
                }
            }
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            if (DataGridClientes.SelectedRows.Count > 0)
            {
                if (ComprobarDatos())
                {
                    if (cliente.ActualizarRegistro())
                    {
                        DataGridClientes.DataSource = cliente.MostrarRegistros();
                        LblAdvertencia.Visible = false;
                        LblNotificacion.Text = "Cliente Actualizado Correctamente";
                        LblNotificacion.Visible = true;
                        LimpiarTextBox();
                    }
                    else
                    {
                        LblNotificacion.Text = "Error al Actualizar - No pueden haber \ndos clientes con el mismo RNC/Cedula";
                        LblNotificacion.Visible = true;

                    }
                }
            }
            else
            {
                LblAdvertencia.Text = "Debe de Elegir el Cliente";
                LblAdvertencia.Visible = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridClientes.SelectedRows.Count > 0)
            {
                if (cliente.EliminarRegistro())
                {
                    LimpiarTextBox();
                    DataGridClientes.DataSource = cliente.MostrarRegistros();
                    LblAdvertencia.Visible = false;
                    LblNotificacion.Text = "Cliente Eliminado Correctamente";
                    LblNotificacion.Visible = true;
                }
                else
                {
                    LblNotificacion.Text = "No se pudo eliminar porque hay \nregistros que depende de este cliente";
                    LblNotificacion.Visible = true;
                }

            }
            else
            {
                LblAdvertencia.Text = "Debe de Elegir el Cliente";
                LblAdvertencia.Visible = true;
            }
        }

        #endregion

        // -> Control y Confirmacion de Textos y Selecciones
        private bool ComprobarDatos()
        {
            bool confirmacion = false;
            if (TBoxIdentificacion.Text == "" || TBoxNombre.Text == "")
            {
                LblAdvertencia.Text = "Rellene los campos Importantes";
                LblAdvertencia.Visible = true;
            }
            else
            {
                if (CMBCategoria.SelectedIndex > -1)
                {
                    try
                    {
                        cliente.Cedula_RNC = long.Parse(TBoxIdentificacion.Text);
                        try
                        {
                            if (TBoxTelefono.Text == "")
                            {
                                cliente.Telefono = 0;
                            }
                            else { cliente.Telefono = long.Parse(TBoxTelefono.Text); }
                            cliente.Nombre = TBoxNombre.Text;
                            cliente.Email = TBoxEmail.Text;
                            cliente.Categoria = CMBCategoria.SelectedIndex;
                            LblAdvertencia.Visible = false;

                            confirmacion = true;
                        }
                        catch
                        {
                            LblAdvertencia.Text = "El Campo Telefono solo Acepta Numeros";
                            LblAdvertencia.Visible = true;

                        }

                    }
                    catch
                    {
                        LblAdvertencia.Text = "El Campo RNC/Cedula Solo Acepta Numeros";
                        LblAdvertencia.Visible = true;
                    }
                }
                else { LblAdvertencia.Text = "Debe de Escoger una Categoria";
                    LblAdvertencia.Visible = true;
                }
            }
            return confirmacion;

        }

        private void DataGridClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridClientes.SelectedRows.Count > 0)
            {
                try
                {
                    cliente.ID = int.Parse(DataGridClientes.CurrentRow.Cells["ID"].Value.ToString());
                    cliente.Cedula_RNC = long.Parse(DataGridClientes.CurrentRow.Cells["RNC/Cedula"].Value.ToString());
                    cliente.Nombre = DataGridClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    cliente.Telefono = long.Parse(DataGridClientes.CurrentRow.Cells["Telefono"].Value.ToString());
                    cliente.Email = DataGridClientes.CurrentRow.Cells["Email"].Value.ToString();
                    if (DataGridClientes.CurrentRow.Cells["Categoria"].Value.ToString() == "Regular")
                    {
                        cliente.Categoria = 0;
                    }
                    else
                    {
                        cliente.Categoria = 1;
                    }
                }
                catch { }
                RellenarTextBox();
            }
        }

        // -> Llenar y limpiar datos
        private void RellenarTextBox()
        {
            LblID.Text = cliente.ID.ToString();
            TBoxIdentificacion.Text = cliente.Cedula_RNC.ToString();
            TBoxNombre.Text = cliente.Nombre;
            TBoxTelefono.Text = cliente.Telefono.ToString();
            TBoxEmail.Text = cliente.Email;
            CMBCategoria.SelectedIndex = cliente.Categoria;
        }

        private void LimpiarTextBox()
        {
            LblID.Text = "";
            TBoxNombre.Text = "";
            TBoxIdentificacion.Text = "";
            TBoxTelefono.Text = "";
            TBoxEmail.Text = "";
            CMBCategoria.SelectedIndex = -1;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
    }
}
