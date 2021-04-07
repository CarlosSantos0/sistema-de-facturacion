using Sistema_de_Facturacion.Diseños;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturacion
{
    static class Program
    {
        public static SqlConnection conexion = new SqlConnection("Data source =localhost\\SQLEXPRESS;" +
                    " initial catalog = SistemaDeFacturacion; integrated security = true");

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
