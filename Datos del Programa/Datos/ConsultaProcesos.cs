using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion.Datos
{
    abstract class ConsultaProcesos
    {

        #region Busqueda de Entradas
        public static DataTable MostrarEntradas()
        {
            SqlCommand comando = new SqlCommand("select Entradas.ID, Productos.Nombre [Producto], Entradas.Cantidad, Proveedores.Nombre [Proveedor], " +
                " Entradas.Fecha from Entradas inner join Productos on Entradas.ID_Producto = " +
                " Productos.ID inner join Proveedores on Entradas.ID_Proveedor = Proveedores.ID", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }
        public static DataTable MostrarEntradas(int cantidad)
        {
            SqlCommand comando = new SqlCommand($"Select top {cantidad} Productos.Nombre [Producto], Entradas.Cantidad, Proveedores.Nombre [Proveedor], " +
                " Entradas.Fecha from Entradas inner join Productos on Entradas.ID_Producto = Productos.ID inner join Proveedores " +
                " on Entradas.ID_Proveedor = Proveedores.ID order by Entradas.ID DESC", Program.conexion);
            Program.conexion.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            Program.conexion.Close();

            return tabla;

        }

        public static DataTable BuscarEntradaConFiltro(int IDProducto)
        {
            SqlCommand comando = new SqlCommand("select Entradas.ID, Productos.Nombre [Producto], Entradas.Cantidad, Proveedores.Nombre [Proveedor], " +
                " Entradas.Fecha from Entradas inner join Productos on Entradas.ID_Producto = " +
                $" Productos.ID inner join Proveedores on Entradas.ID_Proveedor = Proveedores.ID where Entradas.ID_Producto = {IDProducto}", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }

        public static DataTable BuscarEntradaConFiltro(DateTime Fecha)
        {
            SqlCommand comando = new SqlCommand("select Entradas.ID, Productos.Nombre [Producto], Entradas.Cantidad, Proveedores.Nombre [Proveedor], " +
                " Entradas.Fecha from Entradas inner join Productos on Entradas.ID_Producto = " +
                $" Productos.ID inner join Proveedores on Entradas.ID_Proveedor = Proveedores.ID where Entradas.Fecha = '{Fecha}'", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }
        public static DataTable BuscarEntradaPorProveedor(int IDProveedor)
        {
            SqlCommand comando = new SqlCommand("select Entradas.ID, Productos.Nombre [Producto], Entradas.Cantidad, Proveedores.Nombre [Proveedor], " +
                " Entradas.Fecha from Entradas inner join Productos on Entradas.ID_Producto = " +
                $" Productos.ID inner join Proveedores on Entradas.ID_Proveedor = Proveedores.ID where Entradas.ID_Proveedor = {IDProveedor}", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }
#endregion

        #region Busquedas de Facturas
        public static DataTable BuscarFacturaConFiltro(string NombreCliente)
        {
            SqlCommand comando = new SqlCommand("select Facturas.ID_Factura [ID], Clientes.Nombre [Cliente], Productos.Nombre [Producto], Facturas.Fecha, " +
                " Facturas.Cantidad, Facturas.Importe, Facturas.Descuento, (Facturas.Importe - Facturas.Descuento)[Total] " +
                " from Facturas inner join Clientes on Facturas.ID_Cliente = Clientes.ID inner join Productos on Facturas.ID_Producto = " +
                $" Productos.ID where Clientes.Nombre like '%{NombreCliente}%'", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }
        public static DataTable BuscarFacturaConFiltro(DateTime fecha)
        {
            SqlCommand comando = new SqlCommand("select Facturas.ID_Factura [ID], Clientes.Nombre [Cliente], Productos.Nombre [Producto], Facturas.Fecha, " +
                " Facturas.Cantidad, Facturas.Importe, Facturas.Descuento, (Facturas.Importe - Facturas.Descuento)[Total] " +
                " from Facturas inner join Clientes on Facturas.ID_Cliente = Clientes.ID inner join Productos on Facturas.ID_Producto = " +
                $" Productos.ID where Facturas.Fecha = '{fecha}'", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }
        #endregion

    }
}
