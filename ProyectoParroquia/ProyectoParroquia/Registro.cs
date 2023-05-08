using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ProyectoParroquia
{
    public partial class Registro : Form
    {

        private SqlCommand insert1;

        public Registro()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            bool validado = true;
            Regex expresion = new Regex("^[0-9]{8}-[0-9]{1}$");
            Regex expresioncorreo = new Regex("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$");
            if (textBoxdui.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxdui, "Por favor digite su Dui");


            }
            else if (expresion.IsMatch(textBoxdui.Text) == false)
            {
                validado = false;
                errorProvider1.SetError(textBoxdui, "Por favor use un formato válido 00000000-0");

            }
            if (textBoxnombre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxnombre, "Por favor digite su Nombre");
            }
            if (textBoxapellido.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxapellido, "Por favor digite su Apellido");
            }
           
            if (textBoxcontraseña.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxcontraseña, "Por favor digite su Contraseña");
            }



            return validado;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                //verificamos validaciones
                if (validar() == true)
                {
                    //llamamos a la clase conexión
                    Conexion connection = new Conexion();
                    connection.conectar();
                    //hacemos inserts
                    string insertencargado;
                    insertencargado = "insert into encargado(Nombres,Apellido,Dui,correo,clave)";
                    insertencargado += "values(@Nombres,@Apellido,@Dui,@correo,@clave)";
                    insert1 = new SqlCommand(insertencargado, connection.Conn);
                    insert1.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar));
                    insert1.Parameters["@Nombres"].Value = textBoxnombre.Text;
                    insert1.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
                    insert1.Parameters["@Apellido"].Value = textBoxapellido.Text;
                    insert1.Parameters.Add(new SqlParameter("@Dui", SqlDbType.VarChar));
                    insert1.Parameters["@Dui"].Value = textBoxdui.Text;
                    insert1.Parameters.Add(new SqlParameter("@correo", SqlDbType.VarChar));
                    insert1.Parameters["@correo"].Value = textBoxcorreo.Text;
                    insert1.Parameters.Add(new SqlParameter("@clave", SqlDbType.VarChar));
                    insert1.Parameters["@clave"].Value = textBoxcontraseña.Text;
                    insert1.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado con éxito\nSu Usuario es: " + textBoxnombre.Text);
                    //limpiando textbox
                    textBoxnombre.Clear();
                    textBoxapellido.Clear();
                    textBoxdui.Clear();
                    textBoxcontraseña.Clear();
                    textBoxcorreo.Clear();

                    textBoxnombre.Focus();
                    
                    connection.cerrar();

                    //abrimos inicio de sesión
                    InicioSesión inicio = new InicioSesión();
                    inicio.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Ingrese la información correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la ejecución, " + error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesión inicio = new InicioSesión();
            inicio.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
