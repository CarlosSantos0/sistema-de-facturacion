namespace Sistema_de_Facturacion.Diseños
{
    partial class Proceso_Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TBoxIDCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBNombreCliente = new System.Windows.Forms.ComboBox();
            this.NumericProductos = new System.Windows.Forms.NumericUpDown();
            this.DataGridProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblIdentificacionCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTelefonoCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCategoriaCliente = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LblCantidadProducto = new System.Windows.Forms.Label();
            this.LblPrecioProducto = new System.Windows.Forms.Label();
            this.TBoxIDProducto = new System.Windows.Forms.TextBox();
            this.CMBNombreProducto = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.LblProductoItbis = new System.Windows.Forms.Label();
            this.LblDescuentoPremium = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblTotalImporte = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnNuevaFactura = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnVerClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TBoxIDCliente
            // 
            this.TBoxIDCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.TBoxIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxIDCliente.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxIDCliente.Location = new System.Drawing.Point(52, 44);
            this.TBoxIDCliente.Name = "TBoxIDCliente";
            this.TBoxIDCliente.Size = new System.Drawing.Size(48, 28);
            this.TBoxIDCliente.TabIndex = 102;
            this.TBoxIDCliente.TextChanged += new System.EventHandler(this.TBoxIDCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Open Sans", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 38);
            this.label1.TabIndex = 101;
            this.label1.Text = "Cliente";
            // 
            // CMBNombreCliente
            // 
            this.CMBNombreCliente.BackColor = System.Drawing.Color.White;
            this.CMBNombreCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBNombreCliente.FormattingEnabled = true;
            this.CMBNombreCliente.Location = new System.Drawing.Point(108, 72);
            this.CMBNombreCliente.Name = "CMBNombreCliente";
            this.CMBNombreCliente.Size = new System.Drawing.Size(166, 24);
            this.CMBNombreCliente.TabIndex = 104;
            this.CMBNombreCliente.SelectedIndexChanged += new System.EventHandler(this.CMBNombreCliente_SelectedIndexChanged);
            // 
            // NumericProductos
            // 
            this.NumericProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumericProductos.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericProductos.Location = new System.Drawing.Point(555, 284);
            this.NumericProductos.Name = "NumericProductos";
            this.NumericProductos.Size = new System.Drawing.Size(110, 24);
            this.NumericProductos.TabIndex = 106;
            // 
            // DataGridProductos
            // 
            this.DataGridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridProductos.BackgroundColor = System.Drawing.Color.White;
            this.DataGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridProductos.ColumnHeadersHeight = 30;
            this.DataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 4, 6, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridProductos.EnableHeadersVisualStyles = false;
            this.DataGridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.DataGridProductos.Location = new System.Drawing.Point(397, 107);
            this.DataGridProductos.Name = "DataGridProductos";
            this.DataGridProductos.ReadOnly = true;
            this.DataGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridProductos.RowHeadersVisible = false;
            this.DataGridProductos.RowHeadersWidth = 51;
            this.DataGridProductos.RowTemplate.Height = 24;
            this.DataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridProductos.Size = new System.Drawing.Size(731, 140);
            this.DataGridProductos.TabIndex = 217;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 27);
            this.label2.TabIndex = 101;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 101;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 27);
            this.label4.TabIndex = 101;
            this.label4.Text = "RNC/Cedula:";
            // 
            // LblIdentificacionCliente
            // 
            this.LblIdentificacionCliente.AutoSize = true;
            this.LblIdentificacionCliente.BackColor = System.Drawing.Color.White;
            this.LblIdentificacionCliente.Font = new System.Drawing.Font("Open Sans SemiBold", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdentificacionCliente.Location = new System.Drawing.Point(406, 30);
            this.LblIdentificacionCliente.Name = "LblIdentificacionCliente";
            this.LblIdentificacionCliente.Size = new System.Drawing.Size(0, 30);
            this.LblIdentificacionCliente.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 27);
            this.label5.TabIndex = 101;
            this.label5.Text = "Telefono:";
            // 
            // LblTelefonoCliente
            // 
            this.LblTelefonoCliente.AutoSize = true;
            this.LblTelefonoCliente.BackColor = System.Drawing.Color.White;
            this.LblTelefonoCliente.Font = new System.Drawing.Font("Open Sans SemiBold", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefonoCliente.Location = new System.Drawing.Point(388, 73);
            this.LblTelefonoCliente.Name = "LblTelefonoCliente";
            this.LblTelefonoCliente.Size = new System.Drawing.Size(0, 30);
            this.LblTelefonoCliente.TabIndex = 101;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(982, 84);
            this.button1.TabIndex = 107;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 27);
            this.label7.TabIndex = 101;
            this.label7.Text = "Categoria:";
            // 
            // LblCategoriaCliente
            // 
            this.LblCategoriaCliente.AutoSize = true;
            this.LblCategoriaCliente.BackColor = System.Drawing.Color.White;
            this.LblCategoriaCliente.Font = new System.Drawing.Font("Open Sans SemiBold", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoriaCliente.Location = new System.Drawing.Point(639, 28);
            this.LblCategoriaCliente.Name = "LblCategoriaCliente";
            this.LblCategoriaCliente.Size = new System.Drawing.Size(0, 30);
            this.LblCategoriaCliente.TabIndex = 101;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(11, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(982, 84);
            this.button3.TabIndex = 107;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Open Sans", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 38);
            this.label8.TabIndex = 101;
            this.label8.Text = "Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 27);
            this.label13.TabIndex = 101;
            this.label13.Text = "ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 27);
            this.label14.TabIndex = 101;
            this.label14.Text = "Nombre:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(308, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 27);
            this.label15.TabIndex = 101;
            this.label15.Text = "Precio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(474, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 54);
            this.label16.TabIndex = 101;
            this.label16.Text = "Cantidad \r\na llevar:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Open Sans SemiBold", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(642, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 30);
            this.label17.TabIndex = 101;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(304, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 27);
            this.label18.TabIndex = 101;
            this.label18.Text = "En stock:";
            // 
            // LblCantidadProducto
            // 
            this.LblCantidadProducto.AutoSize = true;
            this.LblCantidadProducto.BackColor = System.Drawing.Color.White;
            this.LblCantidadProducto.Font = new System.Drawing.Font("Open Sans SemiBold", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadProducto.Location = new System.Drawing.Point(381, 305);
            this.LblCantidadProducto.Name = "LblCantidadProducto";
            this.LblCantidadProducto.Size = new System.Drawing.Size(0, 30);
            this.LblCantidadProducto.TabIndex = 101;
            // 
            // LblPrecioProducto
            // 
            this.LblPrecioProducto.AutoSize = true;
            this.LblPrecioProducto.BackColor = System.Drawing.Color.White;
            this.LblPrecioProducto.Font = new System.Drawing.Font("Open Sans SemiBold", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioProducto.Location = new System.Drawing.Point(369, 262);
            this.LblPrecioProducto.Name = "LblPrecioProducto";
            this.LblPrecioProducto.Size = new System.Drawing.Size(0, 30);
            this.LblPrecioProducto.TabIndex = 101;
            // 
            // TBoxIDProducto
            // 
            this.TBoxIDProducto.BackColor = System.Drawing.SystemColors.Menu;
            this.TBoxIDProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxIDProducto.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxIDProducto.Location = new System.Drawing.Point(52, 276);
            this.TBoxIDProducto.Name = "TBoxIDProducto";
            this.TBoxIDProducto.Size = new System.Drawing.Size(48, 28);
            this.TBoxIDProducto.TabIndex = 102;
            this.TBoxIDProducto.TextChanged += new System.EventHandler(this.TBoxIDProducto_TextChanged);
            // 
            // CMBNombreProducto
            // 
            this.CMBNombreProducto.BackColor = System.Drawing.Color.White;
            this.CMBNombreProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBNombreProducto.FormattingEnabled = true;
            this.CMBNombreProducto.Location = new System.Drawing.Point(105, 304);
            this.CMBNombreProducto.Name = "CMBNombreProducto";
            this.CMBNombreProducto.Size = new System.Drawing.Size(166, 24);
            this.CMBNombreProducto.TabIndex = 104;
            this.CMBNombreProducto.SelectedIndexChanged += new System.EventHandler(this.CMBNombreProducto_SelectedIndexChanged);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Open Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(896, 261);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(88, 65);
            this.BtnEliminar.TabIndex = 220;
            this.BtnEliminar.Text = "Ver Inventario";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(719, 258);
            this.BtnAgregarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(170, 33);
            this.BtnAgregarProducto.TabIndex = 220;
            this.BtnAgregarProducto.Text = "Agregar Producto";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.BtnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.BtnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(719, 295);
            this.BtnEliminarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(170, 33);
            this.BtnEliminarProducto.TabIndex = 220;
            this.BtnEliminarProducto.Text = "Eliminar Producto";
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // LblProductoItbis
            // 
            this.LblProductoItbis.AutoSize = true;
            this.LblProductoItbis.BackColor = System.Drawing.Color.White;
            this.LblProductoItbis.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductoItbis.Location = new System.Drawing.Point(567, 388);
            this.LblProductoItbis.Name = "LblProductoItbis";
            this.LblProductoItbis.Size = new System.Drawing.Size(28, 33);
            this.LblProductoItbis.TabIndex = 221;
            this.LblProductoItbis.Text = "0";
            // 
            // LblDescuentoPremium
            // 
            this.LblDescuentoPremium.AutoSize = true;
            this.LblDescuentoPremium.BackColor = System.Drawing.Color.White;
            this.LblDescuentoPremium.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescuentoPremium.Location = new System.Drawing.Point(609, 425);
            this.LblDescuentoPremium.Name = "LblDescuentoPremium";
            this.LblDescuentoPremium.Size = new System.Drawing.Size(28, 33);
            this.LblDescuentoPremium.TabIndex = 222;
            this.LblDescuentoPremium.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(508, 424);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 33);
            this.label21.TabIndex = 223;
            this.label21.Text = "Descuento:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(512, 388);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 33);
            this.label22.TabIndex = 224;
            this.label22.Text = "ITBIS:";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.BackColor = System.Drawing.Color.White;
            this.LblSubTotal.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.Location = new System.Drawing.Point(596, 353);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(28, 33);
            this.LblSubTotal.TabIndex = 225;
            this.LblSubTotal.Text = "0";
            // 
            // LblTotalImporte
            // 
            this.LblTotalImporte.AutoSize = true;
            this.LblTotalImporte.BackColor = System.Drawing.Color.White;
            this.LblTotalImporte.Font = new System.Drawing.Font("Open Sans", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalImporte.Location = new System.Drawing.Point(813, 388);
            this.LblTotalImporte.Name = "LblTotalImporte";
            this.LblTotalImporte.Size = new System.Drawing.Size(32, 38);
            this.LblTotalImporte.TabIndex = 226;
            this.LblTotalImporte.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Open Sans", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(744, 388);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 38);
            this.label19.TabIndex = 227;
            this.label19.Text = "Total:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(511, 352);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 33);
            this.label20.TabIndex = 228;
            this.label20.Text = "Subtotal:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 343);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 96);
            this.button2.TabIndex = 229;
            this.button2.Text = "Generar Factura";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnGenerarFactura_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(172, 343);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 96);
            this.button4.TabIndex = 230;
            this.button4.Text = "Imprimir Factura";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // BtnNuevaFactura
            // 
            this.BtnNuevaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.BtnNuevaFactura.FlatAppearance.BorderSize = 0;
            this.BtnNuevaFactura.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevaFactura.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaFactura.ForeColor = System.Drawing.Color.White;
            this.BtnNuevaFactura.Location = new System.Drawing.Point(11, 445);
            this.BtnNuevaFactura.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevaFactura.Name = "BtnNuevaFactura";
            this.BtnNuevaFactura.Size = new System.Drawing.Size(302, 33);
            this.BtnNuevaFactura.TabIndex = 231;
            this.BtnNuevaFactura.Text = "Nueva Factura";
            this.BtnNuevaFactura.UseVisualStyleBackColor = false;
            this.BtnNuevaFactura.Click += new System.EventHandler(this.BtnNuevaFactura_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(498, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(495, 137);
            this.button5.TabIndex = 232;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // BtnVerClientes
            // 
            this.BtnVerClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.BtnVerClientes.FlatAppearance.BorderSize = 0;
            this.BtnVerClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerClientes.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerClientes.ForeColor = System.Drawing.Color.White;
            this.BtnVerClientes.Location = new System.Drawing.Point(812, 25);
            this.BtnVerClientes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVerClientes.Name = "BtnVerClientes";
            this.BtnVerClientes.Size = new System.Drawing.Size(170, 33);
            this.BtnVerClientes.TabIndex = 234;
            this.BtnVerClientes.Text = "Ver Clientes";
            this.BtnVerClientes.UseVisualStyleBackColor = false;
            this.BtnVerClientes.Click += new System.EventHandler(this.BtnVerClientes_Click);
            // 
            // Proceso_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 634);
            this.Controls.Add(this.BtnVerClientes);
            this.Controls.Add(this.BtnNuevaFactura);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.LblTotalImporte);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.LblProductoItbis);
            this.Controls.Add(this.LblDescuentoPremium);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.BtnEliminarProducto);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DataGridProductos);
            this.Controls.Add(this.NumericProductos);
            this.Controls.Add(this.CMBNombreProducto);
            this.Controls.Add(this.CMBNombreCliente);
            this.Controls.Add(this.TBoxIDProducto);
            this.Controls.Add(this.TBoxIDCliente);
            this.Controls.Add(this.LblPrecioProducto);
            this.Controls.Add(this.LblIdentificacionCliente);
            this.Controls.Add(this.LblCantidadProducto);
            this.Controls.Add(this.LblTelefonoCliente);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LblCategoriaCliente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Name = "Proceso_Facturacion";
            this.Text = "Proceso_Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.NumericProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBoxIDCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBNombreCliente;
        private System.Windows.Forms.NumericUpDown NumericProductos;
        private System.Windows.Forms.DataGridView DataGridProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblIdentificacionCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTelefonoCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCategoriaCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LblCantidadProducto;
        private System.Windows.Forms.Label LblPrecioProducto;
        private System.Windows.Forms.TextBox TBoxIDProducto;
        private System.Windows.Forms.ComboBox CMBNombreProducto;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.Label LblProductoItbis;
        private System.Windows.Forms.Label LblDescuentoPremium;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblTotalImporte;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnNuevaFactura;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnVerClientes;
    }
}