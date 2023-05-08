using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoParroquia
{
     class encargado
    {
        //elemento de conexiones 
        Conexion connection = new Conexion();
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;

        //atributos y propiedades
        private string correo;
        private string clave;

        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }



        //función de verificación

        public bool verificarusuario(string nombre)
        {

            bool usuariosi = false;
            string selec;
            selec = "Select * from encargado  where Nombres=@Nombres";
            try
            {

                connection.conectar();
                dataAdapter = new SqlDataAdapter(selec, connection.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Nombres", nombre);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    usuariosi = true;
                    dataReader.Read();


                }
            }
            catch (Exception error)
            {
                MessageBox.Show("error" + error.Message);
            }
            finally
            {
                connection.cerrar();
                dataReader.Close();
            }
            return usuariosi;
        }


        public bool verificarcontraseña(string clave)
        {

            bool contrasi = false;
            string selec;
            selec = "Select * from encargado where clave=@clave";
            try
            {

                connection.conectar();
                dataAdapter = new SqlDataAdapter(selec, connection.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@clave", clave);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    contrasi = true;
                    dataReader.Read();


                }
            }
            catch (Exception error)
            {
                MessageBox.Show("error" + error.Message);
            }
            finally
            {
                connection.cerrar();
                dataReader.Close();
            }
            return contrasi;
        }
    }
}

