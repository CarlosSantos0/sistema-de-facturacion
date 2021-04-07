namespace Sistema_de_Facturacion.Diseños
{
    partial class Consulta_Entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Entradas));
            this.CMBProducto = new System.Windows.Forms.ComboBox();
            this.CMBProveedor = new System.Windows.Forms.ComboBox();
            this.DateTimeEntrada = new System.Windows.Forms.DateTimePicker();
            this.DataGridEntradas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CMBProducto
            // 
            this.CMBProducto.BackColor = System.Drawing.Color.White;
            this.CMBProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBProducto.FormattingEnabled = true;
            this.CMBProducto.Location = new System.Drawing.Point(251, 53);
            this.CMBProducto.Name = "CMBProducto";
            this.CMBProducto.Size = new System.Drawing.Size(170, 24);
            this.CMBProducto.TabIndex = 102;
            this.CMBProducto.SelectedIndexChanged += new System.EventHandler(this.CMBProducto_SelectedIndexChanged);
            // 
            // CMBProveedor
            // 
            this.CMBProveedor.BackColor = System.Drawing.Color.White;
            this.CMBProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMBProveedor.FormattingEnabled = true;
            this.CMBProveedor.Location = new System.Drawing.Point(706, 51);
            this.CMBProveedor.Name = "CMBProveedor";
            this.CMBProveedor.Size = new System.Drawing.Size(182, 24);
            this.CMBProveedor.TabIndex = 102;
            this.CMBProveedor.SelectedIndexChanged += new System.EventHandler(this.CMBProveedor_SelectedIndexChanged);
            // 
            // DateTimeEntrada
            // 
            this.DateTimeEntrada.Location = new System.Drawing.Point(426, 108);
            this.DateTimeEntrada.Name = "DateTimeEntrada";
            this.DateTimeEntrada.Size = new System.Drawing.Size(200, 22);
            this.DateTimeEntrada.TabIndex = 103;
            this.DateTimeEntrada.ValueChanged += new System.EventHandler(this.DateTimeEntrada_ValueChanged);
            // 
            // DataGridEntradas
            // 
            this.DataGridEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridEntradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridEntradas.BackgroundColor = System.Drawing.Color.White;
            this.DataGridEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridEntradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridEntradas.ColumnHeadersHeight = 30;
            this.DataGridEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 4, 6, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridEntradas.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridEntradas.EnableHeadersVisualStyles = false;
            this.DataGridEntradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.DataGridEntradas.Location = new System.Drawing.Point(195, 145);
            this.DataGridEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridEntradas.Name = "DataGridEntradas";
            this.DataGridEntradas.ReadOnly = true;
            this.DataGridEntradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridEntradas.RowHeadersWidth = 51;
            this.DataGridEntradas.RowTemplate.Height = 24;
            this.DataGridEntradas.Size = new System.Drawing.Size(638, 351);
            this.DataGridEntradas.TabIndex = 236;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 46);
            this.label4.TabIndex = 238;
            this.label4.Text = "Consultar Entradas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 37);
            this.label5.TabIndex = 237;
            this.label5.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 237;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 237;
            this.label2.Text = "Fecha:";
            // 
            // Limpiar
            // 
            this.Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Limpiar.Image")));
            this.Limpiar.Location = new System.Drawing.Point(844, 100);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(47, 43);
            this.Limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Limpiar.TabIndex = 253;
            this.Limpiar.TabStop = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(569, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 4);
            this.pictureBox1.TabIndex = 252;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(342, 137);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 4);
            this.pictureBox2.TabIndex = 252;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox3.Location = new System.Drawing.Point(133, 83);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 4);
            this.pictureBox3.TabIndex = 254;
            this.pictureBox3.TabStop = false;
            // 
            // Consulta_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 608);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGridEntradas);
            this.Controls.Add(this.DateTimeEntrada);
            this.Controls.Add(this.CMBProveedor);
            this.Controls.Add(this.CMBProducto);
            this.Name = "Consulta_Entradas";
            this.Text = "Consulta_Entradas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CMBProducto;
        private System.Windows.Forms.ComboBox CMBProveedor;
        private System.Windows.Forms.DateTimePicker DateTimeEntrada;
        private System.Windows.Forms.DataGridView DataGridEntradas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Limpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}