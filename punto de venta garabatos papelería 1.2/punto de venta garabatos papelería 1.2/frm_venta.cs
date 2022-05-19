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
    public partial class frm_venta : Form
    {
        public frm_venta()
        {
            InitializeComponent();
        }

        private void dtgrd_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            dtgrd_ventas.Rows.Add();
        }
    }
}
