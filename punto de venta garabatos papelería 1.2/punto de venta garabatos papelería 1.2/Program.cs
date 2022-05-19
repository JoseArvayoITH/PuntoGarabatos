using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_de_venta_garabatos_papelería_1._2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm_login login = new frm_login();
            login.ShowDialog();
            string tipo = login.tipo_usuario;
            if(tipo == "ADM")
            {
                Application.Run(new frm_admin());
            }if (tipo == "VEN")
            {
                Application.Run(new frm_venta());
            }
            
        }
    }
}
