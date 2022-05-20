using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_de_venta_garabatos_papelería_1._2
{
    public partial class frm_empleados : Form
    {
        SqlConnection conexion = new SqlConnection("data source = JONASPC; initial catalog = PuntoGarabatos; user id = sa; password = 415263");
        public void llenar_tabla()
        {
            string consulta = "select * from Personal";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public frm_empleados()
        {
            InitializeComponent();
        }

        private void frm_empleados_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Personal";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_id.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtbx_nombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtbx_usuario.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtbx_contraseña.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtbx_rfc.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtbx_puesto.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into Personal values("+txtbx_id.Text+",'"+txtbx_nombre.Text+"','"+txtbx_usuario.Text+"','"+txtbx_contraseña.Text+"',"+txtbx_rfc.Text+",'"+txtbx_puesto.Text+"')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            llenar_tabla();

            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "delete from Personal where idPersonal = "+txtbx_id.Text+"";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            llenar_tabla();

            conexion.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "update Personal set nombre='" + txtbx_nombre.Text + "',usuario='" + txtbx_usuario.Text + "',contraseña='"+txtbx_contraseña.Text+"',RFC="+txtbx_rfc.Text+",puesto='"+txtbx_puesto.Text+"' where idPersonal="+txtbx_id+"";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Personal Agregado");
            }
            conexion.Close();
        }
    }
}
