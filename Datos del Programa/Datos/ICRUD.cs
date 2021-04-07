using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturacion.Datos
{
    interface ICRUD
    {
        DataTable MostrarRegistros();
        bool IngresarRegistro();
        bool ActualizarRegistro();
        bool EliminarRegistro();

    }
}
