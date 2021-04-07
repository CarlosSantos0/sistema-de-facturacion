using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion.Datos
{
    abstract class Procesos
    {
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public Producto producto = new Producto();
        public abstract void GenerarNuevoProducto();



    }
}
