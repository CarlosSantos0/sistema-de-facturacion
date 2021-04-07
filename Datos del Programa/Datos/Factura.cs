using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion.Datos
{
    class Factura : Procesos
    {
        public double Importe { get; set; }
        public double DescuentoPremium { get; set; }
        public double ITBIS { get; set; }
        public double Subtotal { get; set; }
        public int Num_Factura { get; set; }

        public  List<Producto> ListaProductos = new List<Producto>();


    
        #region Venta de Productos
        public override void GenerarNuevoProducto()
        {
            producto = new Producto();
        }

        public bool AñadirProducto()
        {
            bool confirmacion = true;

            for(int i = 0; i < ListaProductos.Count; i++)
            {
                if (ListaProductos[i].ID == producto.ID)
                {
                    confirmacion = false;
                }
            }
            if (confirmacion)
            {
                ListaProductos.Add(producto);

            }
            return confirmacion;
        }

        public void EliminarProducto(int Id_Producto)
        {
            for (int i = 0; i < ListaProductos.Count(); i++)
            {
                if (ListaProductos[i].ID == Id_Producto)
                {
                    ListaProductos.RemoveAt(i);
                }
            }
        }

        

        #endregion


    }
}
