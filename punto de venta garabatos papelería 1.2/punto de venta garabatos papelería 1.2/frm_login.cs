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
    public partial class frm_login : Form
    {
        string usuario;
        string contraseña;
        public string tipo_usuario;
       /// SqlConnection conexion = new SqlConnection("server=JONASPC; database=[garabatos_papeleria] ; integrated security = true");
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            /*SqlDataAdapter sda = new SqlDataAdapter("SELECT tipo_usuario FROM usuarios WHERE usuario='" + txt_user.Text + "' AND password='" + txt_pwd.Text + "'", conexion);
            conexion.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt*/
            if (txt_user.Text == "administrador"&& txt_pwd.Text=="123")
            {
                tipo_usuario = "ADM";
                this.Close();

            }
            else if (txt_user.Text == "vendedor"&&txt_pwd.Text=="456")
            {
                tipo_usuario = "VEN";
                this.Close();

            }
            else
            {
                MessageBox.Show("usuario o contraseña inválidos");
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
