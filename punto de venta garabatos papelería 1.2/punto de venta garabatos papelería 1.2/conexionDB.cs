using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace punto_de_venta_garabatos_papelería_1._2
{
    internal class conexionDB
    {
        //Cadena de Conexion
        string cadena = "data source = JONASPC; initial catalog = PuntoGarabatos; user id = Usuario; password = Contraseña";

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public conexionDB()
        {
            Conectarbd.ConnectionString = cadena;
        }
        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD ");
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }
}

