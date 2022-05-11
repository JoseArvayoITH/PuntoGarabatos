namespace punto_de_venta_garabatos_papelería_1._2
{
    partial class frm_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin));
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.Color.LightYellow;
            this.btn_inventario.Location = new System.Drawing.Point(12, 235);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(129, 87);
            this.btn_inventario.TabIndex = 1;
            this.btn_inventario.Text = "INVENTARIO";
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_venta
            // 
            this.btn_venta.BackColor = System.Drawing.Color.LightBlue;
            this.btn_venta.Location = new System.Drawing.Point(165, 235);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(128, 87);
            this.btn_venta.TabIndex = 2;
            this.btn_venta.Text = "VENTA";
            this.btn_venta.UseVisualStyleBackColor = false;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.BackColor = System.Drawing.Color.MistyRose;
            this.btn_empleados.Location = new System.Drawing.Point(320, 235);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(133, 87);
            this.btn_empleados.TabIndex = 3;
            this.btn_empleados.Text = "EMPLEADOS";
            this.btn_empleados.UseVisualStyleBackColor = false;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(465, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_empleados);
            this.Controls.Add(this.btn_venta);
            this.Controls.Add(this.btn_inventario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_admin";
            this.Text = "frm_admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}