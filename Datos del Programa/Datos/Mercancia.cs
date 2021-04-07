using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion.Datos
{
    class Mercancia : Procesos
    {

        public override void GenerarNuevoProducto()
        {
            producto = new Producto();
        }


    }
}
