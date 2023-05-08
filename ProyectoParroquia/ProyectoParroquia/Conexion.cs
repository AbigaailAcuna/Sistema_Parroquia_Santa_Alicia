using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoParroquia
{
    class Conexion
    {
        //cadena de conexión
        private static string cadena = "Data Source=(local);Initial Catalog=Parroquia1;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(cadena);

        public SqlConnection Conn { get => conn; set => conn = value; }

        public void conectar()
        {

            try
            {
                conn.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("eerror" + error.Message);
            }
        }

        public void cerrar()
        {
            conn.Close();
        }
    }
}

