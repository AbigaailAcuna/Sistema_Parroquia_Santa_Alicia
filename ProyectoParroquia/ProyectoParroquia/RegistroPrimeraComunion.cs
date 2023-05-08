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
using System.Runtime.InteropServices;


namespace ProyectoParroquia
{
    public partial class RegistroPrimeraComunion : Form
    {
        private SqlCommand insert3;
        private SqlCommand insert4;
        private SqlCommand insert5;
        public RegistroPrimeraComunion()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            bool validado = true;
            if (textBoxsacerdote.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxsacerdote, "Por favor digite el nombre del sacerdote");

            }

            if (textBoxnombre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxnombre, "Por favor digite su Nombre");
            }
            if (textBoxmadre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxmadre, "Por favor digite su Nombre");
            }
            if (textBoxpadre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxpadre, "Por favor digite su Nombre");
            }
           
            if (textBoxlugarnacimiento.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxlugarnacimiento, "Por favor digite el lugar de nacimiento");
            }




            return validado;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegistroPrimeraComunion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrimeraComunion.informacionPrimeraComunion' Puede moverla o quitarla según sea necesario.
            
        }

        private void buttonregreso_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }

        private void buttonregistrar_Click(object sender, EventArgs e)
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
                    string insertPrimeraComunion;
                    insertPrimeraComunion = "insert into informacionPrimeraComunion(Nombre,Dui,NombreSacerdote,NombrePadre,NombreMadre,LugarNacimiento,fechanacimiento,fecharegistro,estado,idActa)";
                    insertPrimeraComunion += "values(@Nombre,@Dui,@NombreSacerdote,@NombrePadre,@NombreMadre,@LugarNacimiento,@fechanacimiento,@fecharegistro,@estado,@idActa)";
                    insert3 = new SqlCommand(insertPrimeraComunion, connection.Conn);
                    insert3.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                    insert3.Parameters["@Nombre"].Value = textBoxnombre.Text;
                    insert3.Parameters.Add(new SqlParameter("@Dui", SqlDbType.VarChar));
                    insert3.Parameters["@Dui"].Value = textBoxdui.Text;
                    insert3.Parameters.Add(new SqlParameter("@NombreSacerdote", SqlDbType.VarChar));
                    insert3.Parameters["@NombreSacerdote"].Value = textBoxsacerdote.Text;
                    insert3.Parameters.Add(new SqlParameter("@NombrePadre", SqlDbType.VarChar));
                    insert3.Parameters["@NombrePadre"].Value = textBoxpadre.Text;
                    insert3.Parameters.Add(new SqlParameter("@NombreMadre", SqlDbType.VarChar));
                    insert3.Parameters["@NombreMadre"].Value = textBoxmadre.Text;
                    
                   
                    insert3.Parameters.Add(new SqlParameter("@LugarNacimiento", SqlDbType.VarChar));
                    insert3.Parameters["@LugarNacimiento"].Value = textBoxlugarnacimiento.Text;

                    insert3.Parameters.Add(new SqlParameter("@fechanacimiento", SqlDbType.Date));
                    insert3.Parameters["@fechanacimiento"].Value = datenacimiento.Value;
                    insert3.Parameters.Add(new SqlParameter("@fecharegistro", SqlDbType.Date));
                    insert3.Parameters["@fecharegistro"].Value = dateTimePicker2.Value;
                    //
                    insert3.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar));
                    insert3.Parameters["@estado"].Value = textBox2.Text;
                    //
                    insert3.Parameters.Add(new SqlParameter("@idActa", SqlDbType.VarChar));
                    insert3.Parameters["@idActa"].Value = textBox1.Text;

                    insert3.ExecuteNonQuery();




                    //limpiando textbox
                    textBoxsacerdote.Text = "";
                    textBoxnombre.Text = "";
                    textBoxmadre.Text = "";
                    textBoxpadre.Text = "";
                    
                    textBoxdui.Text = "";
                    textBoxlugarnacimiento.Text = "";
                    datenacimiento.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;




                    textBoxsacerdote.Focus();
                    MessageBox.Show("Registro con acta de bautizo agregado con éxito");
                    connection.cerrar();



                }
                else
                {
                    MessageBox.Show("Ingrese la información correcra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la ejecución, " + error);
            }
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está entrando a menú de actualización", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    //llamamos a la conexión
                    Conexion connection = new Conexion();
                    connection.conectar();
                    string actualizar = "update informacionPrimeraComunion set Nombre=@Nombre,NombreSacerdote=@NombreSacerdote, NombrePadre=@NombrePadre, NombreMadre=@NombreMadre,LugarNacimiento=@LugarNacimiento, fechanacimiento=@fechanacimiento where Dui like ('" + textBoxdui.Text + "') ";
                    insert4 = new SqlCommand(actualizar, connection.Conn);
                    insert4.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                    insert4.Parameters["@Nombre"].Value = textBoxnombre.Text;
                    //insert4.Parameters.Add(new SqlParameter("@Dui", SqlDbType.VarChar));
                    //insert4.Parameters["@Dui"].Value = textBoxdui.Text;
                    insert4.Parameters.Add(new SqlParameter("@NombreSacerdote", SqlDbType.VarChar));
                    insert4.Parameters["@NombreSacerdote"].Value = textBoxsacerdote.Text;
                     //  insert4.Parameters.Add(new SqlParameter("@Dui", SqlDbType.VarChar));
                    // insert4.Parameters["@Dui"].Value = textBoxdui.Text;
                    insert4.Parameters.Add(new SqlParameter("@NombrePadre", SqlDbType.VarChar));
                    insert4.Parameters["@NombrePadre"].Value = textBoxpadre.Text;
                    insert4.Parameters.Add(new SqlParameter("@NombreMadre", SqlDbType.VarChar));
                    insert4.Parameters["@NombreMadre"].Value = textBoxmadre.Text;
                   
                    insert4.Parameters.Add(new SqlParameter("@LugarNacimiento", SqlDbType.VarChar));
                    insert4.Parameters["@LugarNacimiento"].Value = textBoxlugarnacimiento.Text;

                    insert4.Parameters.Add(new SqlParameter("@fechanacimiento", SqlDbType.Date));
                    insert4.Parameters["@fechanacimiento"].Value = datenacimiento.Value;
                    insert4.Parameters.Add(new SqlParameter("@fecharegistro", SqlDbType.Date));
                    insert4.Parameters["@fecharegistro"].Value = dateTimePicker2.Value;
                    insert4.ExecuteNonQuery();
                    //limpiando textbox
                    textBoxsacerdote.Text = "";
                    textBoxdui.Text = "";
                    textBoxnombre.Text = "";
                    
                    textBoxmadre.Text = "";
                    
                    textBoxpadre.Text = "";
                    textBoxlugarnacimiento.Text = "";
                    datenacimiento.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;

                    textBoxsacerdote.Focus();
                    MessageBox.Show("Actualización del registro con acta de bautizo modificado con éxito");
                    connection.cerrar();

                }
                catch (Exception error)
                {

                    MessageBox.Show("Error en la ejecución, " + error);
                }
            }
            else
            {

            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está entrando a menú de eliminación", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    textBox2.Text = "NA";

                    //llamamos a la conexión
                    Conexion connection = new Conexion();
                    connection.conectar();
                    string actualizar = "update informacionPrimeraComunion set estado=@estado where Dui like ('" + textBoxdui.Text + "') ";
                    insert5 = new SqlCommand(actualizar, connection.Conn);
                    insert5.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar));
                    insert5.Parameters["@estado"].Value = textBox2.Text;
                    insert5.ExecuteNonQuery();

                    MessageBox.Show("Eliminación del registro con acta de bautizo modificado con éxito");
                    connection.cerrar();


                    //limpiando textbox
                    textBoxsacerdote.Text = "";
                    textBoxnombre.Text = "";
                    textBoxmadre.Text = "";
                    textBoxpadre.Text = "";
                   
                    textBoxdui.Text = "";
                    textBoxlugarnacimiento.Text = "";
                    datenacimiento.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                }
                catch (Exception error)
                {

                    MessageBox.Show("Error en la ejecución, " + error);
                }
            }
            else if (result == DialogResult.Cancel)
            {

            }

        }

        private void buttonacta_Click(object sender, EventArgs e)
        {
            this.informacionPrimeraComunionTableAdapter.Fill(this.dataSetPrimeraComunion.informacionPrimeraComunion, textBoxdui.Text);

            this.reportViewer1.RefreshReport();
        }

        //Permite que la ventana pueda moverse 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RegistroPrimeraComunion_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
