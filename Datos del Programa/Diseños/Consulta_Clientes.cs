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
    public partial class Consulta_Clientes : Form
    {
        Cliente cliente = new Regular(); 

        public Consulta_Clientes()
        {
            InitializeComponent();
            DataGridClientes.DataSource = cliente.MostrarRegistros();
            LblListaDeClientes.Text = cliente.ContarClientes().ToString();
            CMBCategoriaClientes.Items.Add("Regular");
            CMBCategoriaClientes.Items.Add("Premium");

        }

        private void TBoxNombreCliente_TextChanged(object sender, EventArgs e)
        {
            DataGridClientes.DataSource = cliente.BuscarConFiltro(TBoxNombreCliente.Text);
        }

        private void CMBCategoriaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridClientes.DataSource = cliente.BuscarConFiltro(CMBCategoriaClientes.SelectedIndex);
            LblListaDeClientes.Text = cliente.ContarClientes(CMBCategoriaClientes.SelectedIndex).ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TBoxNombreCliente.Text = "";
            CMBCategoriaClientes.SelectedIndex = -1;
            DataGridClientes.DataSource = cliente.MostrarRegistros();
            LblListaDeClientes.Text = cliente.ContarClientes().ToString();
        }
    }
}
