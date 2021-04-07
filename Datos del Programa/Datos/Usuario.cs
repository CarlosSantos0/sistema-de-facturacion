using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturacion.Datos
{
    
    
    abstract class Usuario : ICRUD
    {   
        public int ID { get; set; }
        public long Cedula_RNC { get; set; } // Este puede ser la Cedula o el RNC
        public string Nombre { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }


        #region -> ICRUD Implementacion
        public abstract bool IngresarRegistro();
        public abstract bool ActualizarRegistro();
        public abstract bool EliminarRegistro();
        public abstract DataTable MostrarRegistros();

        #endregion

        public abstract bool RegistrarMovimiento();
        public abstract void GenerarMovimiento();
        public abstract DataTable BuscarConFiltro(string Nombre);
        public abstract void ObtenerLista(ref List<int> Lista, ref ComboBox ComboBox);

  

       

    }
}
