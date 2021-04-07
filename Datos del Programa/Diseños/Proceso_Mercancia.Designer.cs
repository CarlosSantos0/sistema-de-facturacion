namespace Sistema_de_Facturacion.Diseños
{
    partial class Proceso_Mercancia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso_Mercancia));
            this.LblAdvertencia = new System.Windows.Forms.Label();
            this.NumCantidadProductos = new System.Windows.Forms.NumericUpDown();
            this.DataGridProveedor = new System.Windows.Forms.DataGridView();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.VerInventario = new System.Windows.Forms.Button();
            this.BtnAnadir = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNotificacion = new System.Windows.Forms.Label();
            this.CMBProducto = new System.Windows.Forms.ComboBox();
            this.CMBProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdvertencia
            // 
            this.LblAdvertencia.AutoSize = true;
            this.LblAdvertencia.BackColor = System.Drawing.Color.Transparent;
            this.LblAdvertencia.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LblAdvertencia.Location = new System.Drawing.Point(63, 340);
            this.LblAdvertencia.Name = "LblAdvertencia";
            this.LblAdvertencia.Size = new System.Drawing.Size(200, 33);
            this.LblAdvertencia.TabIndex = 218;
            this.LblAdvertencia.Text = "-> Advertencia <-";
            this.LblAdvertencia.Visible = false;
            // 
            // NumCantidadProductos
            // 
            this.NumCantidadProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumCantidadProductos.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCantidadProductos.Location = new System.Drawing.Point(117, 291);
            this.NumCantidadProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumCantidadProductos.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumCantidadProductos.Name = "NumCantidadProductos";
            this.NumCantidadProductos.Size = new System.Drawing.Size(155, 31);
            this.NumCantidadProductos.TabIndex = 217;
            // 
            // DataGridProveedor
            // 
            this.DataGridProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridProveedor.BackgroundColor = System.Drawing.Color.White;
            this.DataGridProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridProveedor.ColumnHeadersHeight = 30;
            this.DataGridProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 4, 6, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridProveedor.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridProveedor.EnableHeadersVisualStyles = false;
            this.DataGridProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.DataGridProveedor.Location = new System.Drawing.Point(813, 119);
            this.DataGridProveedor.Name = "DataGridProveedor";
            this.DataGridProveedor.ReadOnly = true;
            this.DataGridProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridProveedor.RowHeadersWidth = 51;
            this.DataGridProveedor.RowTemplate.Height = 24;
            this.DataGridProveedor.Size = new System.Drawing.Size(588, 381);
            this.DataGridProveedor.TabIndex = 216;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 385);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 215;
            this.pictureBox7.TabStop = false;
            // 
            // VerInventario
            // 
            this.VerInventario.BackColor = System.Drawing.Color.RoyalBlue;
            this.VerInventario.FlatAppearance.BorderSize = 0;
            this.VerInventario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.VerInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerInventario.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerInventario.ForeColor = System.Drawing.Color.White;
            this.VerInventario.Location = new System.Drawing.Point(681, 509);
            this.VerInventario.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.VerInventario.Name = "VerInventario";
            this.VerInventario.Size = new System.Drawing.Size(219, 53);
            this.VerInventario.TabIndex = 213;
            this.VerInventario.Text = "Ver Inventario";
            this.VerInventario.UseVisualStyleBackColor = false;
            this.VerInventario.Click += new System.EventHandler(this.VerInventario_Click);
            // 
            // BtnAnadir
            // 
            this.BtnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.BtnAnadir.FlatAppearance.BorderSize = 0;
            this.BtnAnadir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnadir.Font = new System.Drawing.Font("Open Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnadir.ForeColor = System.Drawing.Color.White;
            this.BtnAnadir.Location = new System.Drawing.Point(57, 385);
            this.BtnAnadir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAnadir.Name = "BtnAnadir";
            this.BtnAnadir.Size = new System.Drawing.Size(254, 41);
            this.BtnAnadir.TabIndex = 214;
            this.BtnAnadir.Text = "Registrar Mercancia";
            this.BtnAnadir.UseVisualStyleBackColor = false;
            this.BtnAnadir.Click += new System.EventHandler(this.BtnAnadir_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox4.Location = new System.Drawing.Point(16, 321);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(277, 4);
            this.pictureBox4.TabIndex = 212;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 37);
            this.label5.TabIndex = 211;
            this.label5.Text = "Cantidad:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(16, 165);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 4);
            this.pictureBox2.TabIndex = 210;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 208;
            this.label2.Text = "Proveedor:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox9.Location = new System.Drawing.Point(16, 237);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(320, 4);
            this.pictureBox9.TabIndex = 207;
            this.pictureBox9.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 205;
            this.label1.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 46);
            this.label4.TabIndex = 204;
            this.label4.Text = "Entrada De Mercancia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNotificacion
            // 
            this.LblNotificacion.AutoSize = true;
            this.LblNotificacion.BackColor = System.Drawing.Color.Transparent;
            this.LblNotificacion.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblNotificacion.Location = new System.Drawing.Point(613, 56);
            this.LblNotificacion.Name = "LblNotificacion";
            this.LblNotificacion.Size = new System.Drawing.Size(157, 33);
            this.LblNotificacion.TabIndex = 203;
            this.LblNotificacion.Text = "-> Anuncio <-";
            this.LblNotificacion.Visible = false;
            // 
            // CMBProducto
            // 
            this.CMBProducto.BackColor = System.Drawing.Color.White;
            this.CMBProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBProducto.FormattingEnabled = true;
            this.CMBProducto.Location = new System.Drawing.Point(117, 203);
            this.CMBProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CMBProducto.Name = "CMBProducto";
            this.CMBProducto.Size = new System.Drawing.Size(211, 32);
            this.CMBProducto.TabIndex = 219;
            // 
            // CMBProveedor
            // 
            this.CMBProveedor.BackColor = System.Drawing.Color.White;
            this.CMBProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBProveedor.FormattingEnabled = true;
            this.CMBProveedor.Location = new System.Drawing.Point(132, 131);
            this.CMBProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CMBProveedor.Name = "CMBProveedor";
            this.CMBProveedor.Size = new System.Drawing.Size(211, 32);
            this.CMBProveedor.TabIndex = 220;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 38);
            this.label3.TabIndex = 208;
            this.label3.Text = "Ultimas Entradas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 506);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 215;
            this.pictureBox1.TabStop = false;
            // 
            // Proceso_Mercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 764);
            this.Controls.Add(this.CMBProveedor);
            this.Controls.Add(this.CMBProducto);
            this.Controls.Add(this.LblAdvertencia);
            this.Controls.Add(this.NumCantidadProductos);
            this.Controls.Add(this.DataGridProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.VerInventario);
            this.Controls.Add(this.BtnAnadir);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNotificacion);
            this.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Proceso_Mercancia";
            this.Text = "asfa";
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAdvertencia;
        private System.Windows.Forms.NumericUpDown NumCantidadProductos;
        private System.Windows.Forms.DataGridView DataGridProveedor;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button VerInventario;
        private System.Windows.Forms.Button BtnAnadir;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNotificacion;
        private System.Windows.Forms.ComboBox CMBProducto;
        private System.Windows.Forms.ComboBox CMBProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}