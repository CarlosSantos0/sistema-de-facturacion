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
    public partial class Mostrar_Inventario : Form
    {
        public Mostrar_Inventario()
        {
            InitializeComponent();
            DataGridInventario.DataSource = MostrarInventario();
        }

        private DataTable MostrarInventario()
        {
            SqlCommand comando = new SqlCommand("Select Inventario.ID_Producto [ID] ,Productos.Nombre [Producto], Inventario.Cantidad from Inventario inner join Productos " +
                " on Inventario.ID_Producto = Productos.ID", Program.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            Program.conexion.Close();
            return tabla;
        }

        private void DataGridInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.DataGridInventario.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                try
                {
                    e.CellStyle.ForeColor = Color.White;

                    if (Convert.ToInt32(e.Value) <= 10)
                        e.CellStyle.BackColor = Color.FromArgb(231, 76, 60);
                    if (Convert.ToInt32(e.Value) > 10)
                        e.CellStyle.BackColor = Color.FromArgb(243, 156, 18);
                    if (Convert.ToInt32(e.Value) > 30)
                        e.CellStyle.BackColor = Color.FromArgb(39, 174, 96);
                }
                catch { }

            }
        }
    }
}
