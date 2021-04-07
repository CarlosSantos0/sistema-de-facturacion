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

    abstract class Cliente : Usuario
    {
        public int Categoria { get; set; }
        public Factura factura { get; set; }


        #region Factura y Movimientos

        public override void GenerarMovimiento()
        {
            factura = new Factura();
        }

        public override bool RegistrarMovimiento()
        {
            bool confirmacion = false;

            if (ID > 0)
            {
                if (factura.ListaProductos.Count() > 0)
                {
                    // Comprobar si la factura ya se registro
                    SqlCommand comando = new SqlCommand("select (select top 1 ID_Factura from Facturas order by ID_Factura DESC)", Program.conexion);
                    Program.conexion.Open();
                    SqlDataReader Registro = comando.ExecuteReader();
                    Registro.Read();
                    int UltimaFactura = -1;
                    try { UltimaFactura = int.Parse(Registro[0].ToString()); }
                    catch {  }
                    finally { Program.conexion.Close(); }

                    if (UltimaFactura != factura.Num_Factura)
                    {
                        
                        // Obtener numero de factura
                        comando = new SqlCommand("select (select top 1 ID_Factura from Facturas order by ID_Factura DESC) + 1", Program.conexion);
                        Program.conexion.Open();
                        Registro = comando.ExecuteReader();
                        Registro.Read();
                        if (UltimaFactura == -1)
                        { factura.Num_Factura = 1; }
                        else
                        {
                            factura.Num_Factura = int.Parse(Registro[0].ToString());
                        }
                        Program.conexion.Close();


                        // Registrar productos
                        for (int i = 0; i < factura.ListaProductos.Count(); i++)
                        {
                            double Importe = factura.ListaProductos[i].Precio * factura.ListaProductos[i].cantidad;
                            double Descuento = 0;
                            if (Categoria == 1)
                            {
                                Descuento = Importe * 0.05;
                            }

                            comando = new SqlCommand($"Insert into Facturas values ({factura.Num_Factura}, {this.ID}, {factura.ListaProductos[i].ID}, " +
                            $" '{DateTime.Now}', {factura.ListaProductos[i].cantidad}, {Importe}, {Descuento} )", Program.conexion);

                            Program.conexion.Open();
                            comando.ExecuteNonQuery();
                            Program.conexion.Close();
                        }
                        confirmacion = true;
                    }
                    else
                    {
                        MessageBox.Show("Esta factura ya fue registrada");
                    }
                }
                else
                {
                    MessageBox.Show("Debe de registrar un producto");
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un cliente");
            }

            return confirmacion;
        }

        public virtual void CalcularFactura()
        {
            factura.Subtotal = 0;
            for (int i = 0; i < factura.ListaProductos.Count(); i++)
            {
                if (i == 0)
                {
                    factura.Subtotal = double.Parse(factura.ListaProductos[i].Precio.ToString()) * int.Parse(factura.ListaProductos[i].cantidad.ToString());
                }
                else
                {
                    factura.Subtotal = factura.Subtotal + (double.Parse(factura.ListaProductos[i].Precio.ToString()) * int.Parse(factura.ListaProductos[i].cantidad.ToString()));
                }
            }

            factura.ITBIS = factura.Subtotal * 0.18;



            factura.Importe = factura.Subtotal - factura.DescuentoPremium + factura.ITBIS;

        }

        #endregion

        #region Busqueda con Filtros y Obtener Listas

        public override DataTable BuscarConFiltro(string NombreCliente)
        {
            SqlCommand comando = new SqlCommand("Select Clientes.ID, clientes.Identificacion [RNC/Cedula], Clientes.Nombre, " +
            " clientes.Telefono, Clientes.Email, Categoria_Cliente.Nombre[Categoria] from clientes inner join " +
            $" Categoria_Cliente on Clientes.Categoria = Categoria_Cliente.ID where Clientes.Nombre like '%{NombreCliente}%'", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }

        public DataTable BuscarConFiltro(int CategoriaCliente)
        {
            SqlCommand comando = new SqlCommand("Select Clientes.ID, clientes.Identificacion [RNC/Cedula], Clientes.Nombre, " +
            " clientes.Telefono, Clientes.Email, Categoria_Cliente.Nombre[Categoria] from clientes inner join " +
            $" Categoria_Cliente on Clientes.Categoria = Categoria_Cliente.ID where Clientes.Categoria like '%{CategoriaCliente}%'", Program.conexion);

            Program.conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);
            Program.conexion.Close();
            return tabla;
        }

        public int ContarClientes()
        {
            SqlCommand comando = new SqlCommand("select count(*) from Clientes", Program.conexion);
            Program.conexion.Open();
            SqlDataReader Registro = comando.ExecuteReader();
            Registro.Read();
            int ListaDeClientes = int.Parse(Registro[0].ToString());
            Program.conexion.Close();
            return ListaDeClientes;
        }

        public int ContarClientes(int CategoriaCliente)
        {
            SqlCommand comando = new SqlCommand($"select count(*) from Clientes where Categoria = {CategoriaCliente}", Program.conexion);
            Program.conexion.Open();
            SqlDataReader Registro = comando.ExecuteReader();
            Registro.Read();
            int ListaDeClientes = int.Parse(Registro[0].ToString());
            Program.conexion.Close();
            return ListaDeClientes;
        }

        public override void ObtenerLista(ref List<int> ListaClientes, ref ComboBox NombreClientes)
        {
            ListaClientes.Clear();
            NombreClientes.Items.Clear();
            SqlCommand comando = new SqlCommand("select ID, Nombre from Clientes", Program.conexion);

            Program.conexion.Open();
            SqlDataReader Registro = comando.ExecuteReader();

            while (Registro.Read())
            {
                ListaClientes.Add(int.Parse(Registro[0].ToString()));
                NombreClientes.Items.Add(Registro[1]);
            }

            Program.conexion.Close();
        }

        public bool BuscarCliente(int id)
        {
            bool confirmacion = false;

            SqlCommand comando = new SqlCommand($"Select * from Clientes where ID = {id}", Program.conexion);

            Program.conexion.Open();
            SqlDataReader Registro = comando.ExecuteReader();

            if (Registro.Read())
            {
                this.ID = int.Parse(Registro[0].ToString());
                this.Cedula_RNC = long.Parse(Registro[1].ToString());
                this.Nombre = Registro[2].ToString();
                this.Telefono = long.Parse(Registro[3].ToString());
                this.Email = Registro[4].ToString();
                this.Categoria = int.Parse(Registro[5].ToString());

                confirmacion = true;
            }

            Program.conexion.Close();

            return confirmacion;
        }
        #endregion

        #region CRUD Implementacion
        public override DataTable MostrarRegistros()
        {
            
            SqlCommand comando = new SqlCommand("select Clientes.ID, Clientes.Identificacion [RNC/Cedula], Clientes.Nombre, Clientes.Telefono, " +
            "Clientes.Email, Categoria_Cliente.Nombre [Categoria] from Clientes inner join Categoria_Cliente " +
            " on Clientes.Categoria = Categoria_Cliente.ID order by Clientes.ID DESC", Program.conexion);
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
              command = new SqlCommand($"insert into clientes values ({this.Cedula_RNC}, '{this.Nombre}', null, '{this.Email}', {this.Categoria})", Program.conexion);
            }
            else
            {
                command = new SqlCommand($"insert into clientes values ({this.Cedula_RNC}, '{this.Nombre}', {this.Telefono}, '{this.Email}', {this.Categoria})", Program.conexion);
            }
            Program.conexion.Open();
            try { command.ExecuteNonQuery();
                confirmacion = true;
            }
            catch { }
            finally { Program.conexion.Close(); }

            return confirmacion;
        }

        public override bool ActualizarRegistro()
        {
            bool confirmacion = false;
            SqlCommand command = new SqlCommand($"Update Clientes SET Identificacion = {this.Cedula_RNC}, Nombre = '{this.Nombre}', Telefono = {this.Telefono}, Email = '{this.Email}', Categoria = {this.Categoria} where ID = {this.ID}", Program.conexion);
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

        public override bool EliminarRegistro()
        {
            bool confirmacion = false;

            SqlCommand command = new SqlCommand($"Delete from Clientes where ID = {this.ID}", Program.conexion);
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
        #endregion


    }

    class Regular : Cliente
    {

    }

    class Premium : Cliente
    {
        private void CalcularDescuentoPremium()
        {
            factura.DescuentoPremium = factura.Subtotal * 0.05;
        }

        public override void CalcularFactura()
        {
            factura.Subtotal = 0;
            for (int i = 0; i < factura.ListaProductos.Count(); i++)
            {
                if (i == 0)
                {
                    factura.Subtotal = double.Parse(factura.ListaProductos[i].Precio.ToString()) * int.Parse(factura.ListaProductos[i].cantidad.ToString());
                }
                else
                {
                    factura.Subtotal = factura.Subtotal + (double.Parse(factura.ListaProductos[i].Precio.ToString()) * int.Parse(factura.ListaProductos[i].cantidad.ToString()));
                }
            }

            factura.ITBIS = factura.Subtotal * 0.18;

            CalcularDescuentoPremium();

            factura.Importe = factura.Subtotal - factura.DescuentoPremium + factura.ITBIS;

        }
    }

}
