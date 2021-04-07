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
    class Proveedor: Usuario
    {
        public Mercancia mercancia { get; set; }

        #region Mercancia y Movimientos
        public override void GenerarMovimiento()
        {
            mercancia = new Mercancia();
        }
        public override bool RegistrarMovimiento()
        {
            bool confirmacion = false;
            SqlCommand comando = new SqlCommand($"Insert into Entradas values ({this.mercancia.producto.ID}, {this.mercancia.Cantidad}, " +
                $" {this.ID}, '{this.mercancia.Fecha}')", Program.conexion);

            Program.conexion.Open();
            try
            {
                comando.ExecuteNonQuery();
                confirmacion = true;
            }
            catch { }
            finally { Program.conexion.Close(); }

            return confirmacion;

        }
        #endregion

        #region Busqueda con Filtros y Obtener Listas

        public override DataTable BuscarConFiltro(string NombreProveedor)
        {
            SqlCommand comando = new SqlCommand("Select ID, Identificacion [RNC/Cedula], Nombre, Telefono, Email " +
                $" from proveedores where Nombre like '%{NombreProveedor}%'", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }

        public DataTable BuscarProveedorPorEmail(string EmailProveedor)
        {
            SqlCommand comando = new SqlCommand("Select ID, Identificacion [RNC/Cedula], Nombre, Telefono, Email " +
                $" from proveedores where Email like '%{EmailProveedor}%'", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }
        public override void ObtenerLista(ref List<int> ListaProveedores, ref ComboBox NombreProveedores)
        {
            ListaProveedores.Clear();
            NombreProveedores.Items.Clear();
            SqlCommand comando = new SqlCommand("select ID, Nombre from Proveedores", Program.conexion);

            Program.conexion.Open();
            SqlDataReader Registro = comando.ExecuteReader();

            while (Registro.Read())
            {
                ListaProveedores.Add(int.Parse(Registro[0].ToString()));
                NombreProveedores.Items.Add(Registro[1]);
            }

            Program.conexion.Close();
        }

        #endregion

        #region CRUD Implementacion
        public override DataTable MostrarRegistros()
        {
            SqlCommand comando = new SqlCommand("Select ID, Identificacion [RNC/Cedula], Nombre, Telefono, Email  from Proveedores " +
                "order by ID DESC ", Program.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            return tabla;
        }

        public override bool IngresarRegistro()
        {
            bool confirmacion = false;
            SqlCommand command = new SqlCommand();

            if (this.Telefono == 0)
            {
                 command = new SqlCommand($"insert into Proveedores values ({this.Cedula_RNC}, '{this.Nombre}', null, '{this.Email}')", Program.conexion);
            }
            else
            {
                command = new SqlCommand($"insert into Proveedores values ({this.Cedula_RNC}, '{this.Nombre}', {this.Telefono}, '{this.Email}')", Program.conexion);
            }
            Program.conexion.Open();
            try { command.ExecuteNonQuery();
                confirmacion = true;
            }
            catch {  }
            finally { Program.conexion.Close(); }
            return confirmacion;
        }

        public override bool ActualizarRegistro()
        {
            bool confirmacion = false;
            SqlCommand command = new SqlCommand($"Update Proveedores SET Identificacion = {this.Cedula_RNC}, Nombre = '{this.Nombre}', Telefono = {this.Telefono}, Email = '{this.Email}'  where ID = {this.ID}", Program.conexion);
            Program.conexion.Open();
            try
            {
                command.ExecuteNonQuery();
                confirmacion = true;
            }
            catch { }
            finally { Program.conexion.Close(); }
            return confirmacion;
        }

        public override bool EliminarRegistro()
        {
            bool confirmacion = false;

            SqlCommand command = new SqlCommand($"Delete from Proveedores where ID = {this.ID}", Program.conexion);
            Program.conexion.Open();
            try { command.ExecuteNonQuery();
                confirmacion = true;
            }
            catch {  }
            finally
            {
                Program.conexion.Close();
            }
            return confirmacion;
        }
        #endregion

    }
}
