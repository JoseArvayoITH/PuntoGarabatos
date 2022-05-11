using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_de_venta_garabatos_papelería_1._2
{
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            frm_inventario inventario = new frm_inventario();
            inventario.ShowDialog();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            frm_empleados empleados = new frm_empleados();
            empleados.ShowDialog();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            frm_venta venta = new frm_venta();
            venta. ShowDialog();

        }
    }
}
