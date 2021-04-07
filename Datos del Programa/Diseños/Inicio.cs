using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Sistema_de_Facturacion.Diseños
{
    public partial class Inicio : Form
    {
       

        public Inicio()
        {
            InitializeComponent();
            EsconderSubMenus();
            RealizarCalculos();
        }

        #region Funcion De Mover Formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wparam, int lparam);

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012);
            }
            catch { }
        }

        private void PanelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012);
            }
            catch { }
        }

        #endregion

        #region Codigo Abrir Formularios

        private Form ActiveForm = null;
        private void AbrirFormulario(Form FmHijo)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
                ActiveForm = FmHijo;
            FmHijo.TopLevel = false;
            FmHijo.FormBorderStyle = FormBorderStyle.None;
            FmHijo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(FmHijo);
            PanelContenedor.Tag = FmHijo;
            FmHijo.BringToFront();
            FmHijo.Show();
        }
        #endregion


        #region Funciones Botones Basicos
        private void BtnSlider_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 80;
                EsconderSubMenus();
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnDesmaximizar.Visible = true;
            BtnMaximizar.Visible = false;
        }

        private void BtnDesmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnDesmaximizar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion


        #region DesplegarSubMenus 

        private void EsconderSubMenus()
        {
            SubmenuConsulta.Visible = false;
            SubMenuMantenimiento.Visible = false;
            SubMenuProceso.Visible = false;
        }

        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
           if(SubMenuMantenimiento.Visible == true)
            {
                SubMenuMantenimiento.Visible = false;
            }
            else
            {
                SubMenuMantenimiento.Visible = true;
            }

        }

        private void BtnProceso_Click(object sender, EventArgs e)
        {
            if(SubMenuProceso.Visible == true)
            {
                SubMenuProceso.Visible = false;
            }
            else
            {
                SubMenuProceso.Visible = true;
            }
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            if(SubmenuConsulta.Visible == true)
            {
                SubmenuConsulta.Visible = false;
            }
            else
            {
                SubmenuConsulta.Visible = true;
            }
        }
        #endregion

        private void BtnManProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Mantenimiento_Productos());
            
            
        }

        private void BtnManClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Mantemiento_Clientes());
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 80;
                EsconderSubMenus();
            }
        }

        private void BtnManProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Mantemiento_Proveedores());
        }

        private void BtnProcesoFacturar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Proceso_Facturacion());
        }

        private void BtnProcesoMercancia_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Proceso_Mercancia());
        }

        private void BtnConsulProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Consulta_Productos());
        }

        private void BtnConsulProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Consultar_Proveedores());
        }

        private void BtnConsulClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Consulta_Clientes());
        }

        private void BtnConsulEntradas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Consulta_Entradas());
        }

        private void BtnConsulFacturaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Consulta_Facturaciones());
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 80)
            {
                MenuVertical.Width = 250;
                EsconderSubMenus();
            }
            if(SubMenuMantenimiento.Visible == false)
            {
                SubMenuMantenimiento.Visible = true;
            }
            else
            {
                SubMenuMantenimiento.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 80)
            {
                MenuVertical.Width = 250;
                EsconderSubMenus();
            }
            if (SubMenuProceso.Visible == false)
            {
                SubMenuProceso.Visible = true;
            }
            else
            {
                SubMenuProceso.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 80)
            {
                MenuVertical.Width = 250;
                EsconderSubMenus();
            }
            if (SubmenuConsulta.Visible == false)
            {
                SubmenuConsulta.Visible = true;
            }
            else
            {
                SubmenuConsulta.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Diseño.color == Diseño.Color1)
            {
                Diseño.color = Diseño.Color2;
            }
            else
            {
                Diseño.color = Diseño.Color1;
            }
            PanelInferior.BackColor = Diseño.color;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try { ActiveForm.Close(); }
            catch { }
            RealizarCalculos();
        }

        private void RealizarCalculos()
        {
            
                SqlCommand comando = new SqlCommand("select sum((Importe - Descuento) - (Importe * 0.18)) from Facturas", Program.conexion);
                Program.conexion.Open();
                SqlDataReader Registro = comando.ExecuteReader();
            Registro.Read();
                LblDinero.Text = Registro[0].ToString() + "$";
            Program.conexion.Close();
                comando = new SqlCommand("select count(id) from Facturas", Program.conexion);
            Program.conexion.Open();
                SqlDataReader Registro1 = comando.ExecuteReader();
            Registro1.Read();
            LblVentas.Text = Registro1[0].ToString();
            Program.conexion.Close();
                comando = new SqlCommand("select count(id) from Clientes", Program.conexion);
            Program.conexion.Open();
               SqlDataReader Registro2 = comando.ExecuteReader();
            Registro2.Read();

            LblClientes.Text = Registro2[0].ToString();
            Program.conexion.Close();
                comando = new SqlCommand("select count(id) from Productos", Program.conexion);
            Program.conexion.Open();
               SqlDataReader Registro3 = comando.ExecuteReader();
            Registro3.Read();

            LblProductos.Text = Registro3[0].ToString();
            Program.conexion.Close();
                comando = new SqlCommand("select count(id) from Proveedores", Program.conexion);
            Program.conexion.Open();
               SqlDataReader Registro4 = comando.ExecuteReader();
            Registro4.Read();
            

            LblProveedores.Text = Registro4[0].ToString();
            Program.conexion.Close();
                comando = new SqlCommand("select sum(cantidad) from Inventario", Program.conexion);
            Program.conexion.Open();
               SqlDataReader Registro5 = comando.ExecuteReader();
            Registro5.Read();

            LblInventario.Text = Registro5[0].ToString();

                Program.conexion.Close();

            LblFecha.Text = DateTime.Now.ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try { ActiveForm.Close(); }
            catch { }
            RealizarCalculos();
        }
    }

}
