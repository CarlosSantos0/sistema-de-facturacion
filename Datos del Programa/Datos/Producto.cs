using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturacion.Datos
{
    class Producto : ICRUD
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int cantidad { get; set; }
    

        #region Busquedas con Filtros y Obtencion de Listas
        public DataTable BuscarProductosConFiltro(string NombreProducto)
        {
            SqlCommand comando = new SqlCommand($"Select * from Productos where Nombre like '%{NombreProducto}%'", Program.conexion);
            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }

        public void ObtenerListasDeProductos(ref List<int> ListaProductos, ref ComboBox NombreProductos)
        {
            ListaProductos.Clear();
            NombreProductos.Items.Clear();
            SqlCommand comando = new SqlCommand("select ID, Nombre from Productos", Program.conexion);

            Program.conexion.Open();
            SqlDataReader Registro = comando.ExecuteReader();

            while (Registro.Read())
            {
                ListaProductos.Add(int.Parse(Registro[0].ToString()));
                NombreProductos.Items.Add(Registro[1]);
            }

            Program.conexion.Close();
        }

        public bool BuscarProducto(int id)
        {
            bool confirmacion = false;

            SqlCommand comando = new SqlCommand("Select Productos.ID, Productos.Nombre, Productos.Precio, " +
                     " Inventario.Cantidad from Productos left outer join Inventario on Productos.ID = " +
                     $" Inventario.ID_Producto where Productos.ID = {id}", Program.conexion);

            Program.conexion.Open();
            SqlDataReader Registro = comando.ExecuteReader();
            string cantidad;
            if (Registro.Read())
            {
                this.ID = int.Parse(Registro[0].ToString());
                this.Nombre = Registro[1].ToString();
                this.Precio = double.Parse(Registro[2].ToString());
                cantidad = Registro[3].ToString();
                if (cantidad == "")
                {
                    this.cantidad = 0;
                }
                else
                {
                    this.cantidad = int.Parse(Registro[3].ToString());
                   
                }

                confirmacion = true;
            }

            Program.conexion.Close();

            return confirmacion;
        }

        #endregion

        #region CRUD Implementacion
        public DataTable MostrarRegistros()
        {
            SqlCommand comando = new SqlCommand("Select * from Productos order by ID DESC", Program.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            return tabla;
        }

        public bool IngresarRegistro()
        {
            bool confirmacion = false;
            SqlCommand command = new SqlCommand($"Insert into Productos values('{this.Nombre}', {this.Precio})", Program.conexion);
            Program.conexion.Open();
            try
            {
                command.ExecuteNonQuery();
                confirmacion = true;
            }
            catch { }
            finally
            {
                Program.conexion.Close();
            }
            return confirmacion;
        }

        public bool ActualizarRegistro()
        {
            bool confirmacion = false;
            SqlCommand command = new SqlCommand($"Update Productos SET Nombre = '{this.Nombre}', Precio = {this.Precio} where ID = {this.ID}",Program.conexion);
           Program.conexion.Open();
            try { command.ExecuteNonQuery();
                confirmacion = true;
            }
            catch { }
            finally { Program.conexion.Close(); }
            return confirmacion;
        }

        public bool EliminarRegistro()
        {
            bool confirmacion = false;

            SqlCommand command = new SqlCommand($"Delete from Productos where ID = {this.ID}", Program.conexion);
            Program.conexion.Open();
            try {
                command.ExecuteNonQuery();
                confirmacion = true;
            }
            catch {}
            finally
            {
                Program.conexion.Close();
            }

            return confirmacion;
        }

        #endregion


    }
}
