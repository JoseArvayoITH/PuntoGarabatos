namespace punto_de_venta_garabatos_papelería_1._2
{
    partial class frm_venta
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
            this.button3 = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.comboNumeroFactura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgrd_ventas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbx_tarjeta = new System.Windows.Forms.CheckBox();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 80);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 49);
            this.button3.TabIndex = 41;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(521, 23);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(267, 49);
            this.Guardar.TabIndex = 40;
            this.Guardar.Text = "Agregar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // comboNumeroFactura
            // 
            this.comboNumeroFactura.FormattingEnabled = true;
            this.comboNumeroFactura.Location = new System.Drawing.Point(99, 23);
            this.comboNumeroFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboNumeroFactura.Name = "comboNumeroFactura";
            this.comboNumeroFactura.Size = new System.Drawing.Size(399, 24);
            this.comboNumeroFactura.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Codigo";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(99, 90);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(399, 22);
            this.txtCantidad.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cantidad";
            // 
            // comboProducto
            // 
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Location = new System.Drawing.Point(99, 57);
            this.comboProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(399, 24);
            this.comboProducto.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Producto";
            // 
            // dtgrd_ventas
            // 
            this.dtgrd_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrd_ventas.ColumnHeadersHeight = 29;
            this.dtgrd_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.producto,
            this.precio_unitario,
            this.cantidad,
            this.total});
            this.dtgrd_ventas.Location = new System.Drawing.Point(20, 155);
            this.dtgrd_ventas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgrd_ventas.Name = "dtgrd_ventas";
            this.dtgrd_ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgrd_ventas.Size = new System.Drawing.Size(1050, 402);
            this.dtgrd_ventas.TabIndex = 42;
            this.dtgrd_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_ventas_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 566);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 49);
            this.button1.TabIndex = 44;
            this.button1.Text = "Vender";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(905, 579);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(855, 582);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total";
            // 
            // chkbx_tarjeta
            // 
            this.chkbx_tarjeta.AutoSize = true;
            this.chkbx_tarjeta.Location = new System.Drawing.Point(485, 582);
            this.chkbx_tarjeta.Name = "chkbx_tarjeta";
            this.chkbx_tarjeta.Size = new System.Drawing.Size(126, 20);
            this.chkbx_tarjeta.TabIndex = 47;
            this.chkbx_tarjeta.Text = "pago con tarjeta";
            this.chkbx_tarjeta.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "código ";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "precio unitario";
            this.precio_unitario.MinimumWidth = 6;
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // frm_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::punto_de_venta_garabatos_papelería_1._2.Properties.Resources.mascota_garabatos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1083, 628);
            this.Controls.Add(this.chkbx_tarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgrd_ventas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.comboNumeroFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboProducto);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_venta";
            this.Text = "frm_venta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.ComboBox comboNumeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrd_ventas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbx_tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}