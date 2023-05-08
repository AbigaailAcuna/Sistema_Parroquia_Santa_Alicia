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
    public partial class RegistroConfirma : Form
    {
        private SqlCommand insert3;
        private SqlCommand insert4;
        private SqlCommand insert5;
        public RegistroConfirma()
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
            if (textBoxmadrina.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxmadrina, "Por favor digite su Nombre");
            }
            if (textBoxpadrino.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxpadrino, "Por favor digite su Nombre");
            }

            if (textBoxlugarnacimiento.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxlugarnacimiento, "Por favor digite el lugar de nacimiento");
            }
            if (textBoxlugardeBautizo.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxlugardeBautizo, "Por favor digite el lugar de Bautizo");
            }




            return validado;
        }

        private void RegistroConfirma_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetConfirma.informacionConfirma' Puede moverla o quitarla según sea necesario.
            
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
                    string insertBautizado;
                    insertBautizado = "insert into informacionConfirma(Nombre,Dui,NombreSacerdote,NombrePadre,NombreMadre,NombreMadrinadeConfirma,NombrePadrinodeConfirma,LugarNacimiento,LugardeBautismo,fechanacimiento,fechaConfirmacion,fechaExpedicion,estado,idActa)";
                    insertBautizado += "values(@Nombre,@Dui,@NombreSacerdote,@NombrePadre,@NombreMadre,@NombreMadrina,@NombrePadrino,@LugarNacimiento,@lugardebautismo,@fechanacimiento,@fechaconfirmacion,@fechaexpedicion,@estado,@idActa)";
                    insert3 = new SqlCommand(insertBautizado, connection.Conn);
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
                    insert3.Parameters.Add(new SqlParameter("@NombreMadrina", SqlDbType.VarChar));
                    insert3.Parameters["@NombreMadrina"].Value = textBoxmadrina.Text;
                    insert3.Parameters.Add(new SqlParameter("@NombrePadrino", SqlDbType.VarChar));
                    insert3.Parameters["@NombrePadrino"].Value = textBoxpadrino.Text;
                    insert3.Parameters.Add(new SqlParameter("@LugarNacimiento", SqlDbType.VarChar));
                    insert3.Parameters["@LugarNacimiento"].Value = textBoxlugarnacimiento.Text;
                    insert3.Parameters.Add(new SqlParameter("@lugardebautismo", SqlDbType.VarChar));
                    insert3.Parameters["@lugardebautismo"].Value = textBoxlugardeBautizo.Text;

                    insert3.Parameters.Add(new SqlParameter("@fechanacimiento", SqlDbType.Date));
                    insert3.Parameters["@fechanacimiento"].Value = datenacimiento.Value;
                    insert3.Parameters.Add(new SqlParameter("@fechaconfirmacion", SqlDbType.Date));
                    insert3.Parameters["@fechaconfirmacion"].Value = dateConfirmado.Value;
                    insert3.Parameters.Add(new SqlParameter("@fechaexpedicion", SqlDbType.Date));
                    insert3.Parameters["@fechaexpedicion"].Value = dateexpedicion.Value;
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
                    textBoxpadrino.Text = "";
                    textBoxmadrina.Text = "";
                    textBoxdui.Text = "";
                    textBoxlugarnacimiento.Text = "";
                    textBoxlugardeBautizo.Text = "";
                    dateexpedicion.Value = DateTime.Now;
                    dateConfirmado.Value = DateTime.Now;
                    datenacimiento.Value = DateTime.Now;




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
                    string actualizar = "update informacionConfirma set Nombre=@Nombre,NombreSacerdote=@NombreSacerdote, NombrePadre=@NombrePadre, NombreMadre=@NombreMadre, NombreMadrinadeConfirma=@NombreMadrina, NombrePadrinodeConfirma=@NombrePadrino,LugarNacimiento=@LugarNacimiento,LugardeBautismo=@LugardeBautismo, fechanacimiento=@fechanacimiento, fechaConfirmacion=@fechaconfirmacion,fechaExpedicion=@fechaExpedicion,estado=@estado,idActa=@idActa where Dui like ('" + textBoxdui.Text + "') ";
                    insert4 = new SqlCommand(actualizar, connection.Conn);
                    insert4.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                    insert4.Parameters["@Nombre"].Value = textBoxnombre.Text;
                   // insert4.Parameters.Add(new SqlParameter("@Dui", SqlDbType.VarChar));
                    //insert4.Parameters["@Dui"].Value = textBoxdui.Text;
                    insert4.Parameters.Add(new SqlParameter("@NombreSacerdote", SqlDbType.VarChar));
                    insert4.Parameters["@NombreSacerdote"].Value = textBoxsacerdote.Text;
                    //   insert4.Parameters.Add(new SqlParameter("@Dui", SqlDbType.VarChar));
                    // insert4.Parameters["@Dui"].Value = textBoxdui.Text;
                    insert4.Parameters.Add(new SqlParameter("@NombrePadre", SqlDbType.VarChar)); 
                    insert4.Parameters["@NombrePadre"].Value = textBoxpadre.Text;
                    insert4.Parameters.Add(new SqlParameter("@NombreMadre", SqlDbType.VarChar));
                    insert4.Parameters["@NombreMadre"].Value = textBoxmadre.Text;
                    insert4.Parameters.Add(new SqlParameter("@NombreMadrina", SqlDbType.VarChar));
                    insert4.Parameters["@NombreMadrina"].Value = textBoxmadrina.Text;
                    insert4.Parameters.Add(new SqlParameter("@NombrePadrino", SqlDbType.VarChar));
                    insert4.Parameters["@NombrePadrino"].Value = textBoxpadrino.Text;
                    insert4.Parameters.Add(new SqlParameter("@LugarNacimiento", SqlDbType.VarChar));
                    insert4.Parameters["@LugarNacimiento"].Value = textBoxlugarnacimiento.Text;
                    insert4.Parameters.Add(new SqlParameter("@LugardeBautismo", SqlDbType.VarChar));
                    insert4.Parameters["@LugardeBautismo"].Value = textBoxlugardeBautizo.Text;

                    insert4.Parameters.Add(new SqlParameter("@fechanacimiento", SqlDbType.Date));
                    insert4.Parameters["@fechanacimiento"].Value = datenacimiento.Value;
                    insert4.Parameters.Add(new SqlParameter("@fechaconfirmacion", SqlDbType.Date));
                    insert4.Parameters["@fechaconfirmacion"].Value = dateConfirmado.Value;
                    insert4.Parameters.Add(new SqlParameter("@fechaExpedicion", SqlDbType.Date));
                    insert4.Parameters["@fechaExpedicion"].Value = dateexpedicion.Value;

                    insert4.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar));
                    insert4.Parameters["@estado"].Value = textBox2.Text;
                    //
                    insert4.Parameters.Add(new SqlParameter("@idActa", SqlDbType.VarChar));
                    insert4.Parameters["@idActa"].Value = textBox1.Text;
                    insert4.ExecuteNonQuery();
                    //limpiando textbox
                    textBoxsacerdote.Text = "";
                    textBoxdui.Text = "";
                    textBoxnombre.Text = "";
                    textBoxmadrina.Text = "";
                    textBoxmadre.Text = "";
                    textBoxpadrino.Text = "";
                    textBoxpadre.Text = "";
                    textBoxlugarnacimiento.Text = "";
                    dateConfirmado.Value = DateTime.Now;
                    datenacimiento.Value = DateTime.Now;
                    dateexpedicion.Value = DateTime.Now;

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
                    string actualizar = "update informacionConfirma set estado=@estado where Dui like ('" + textBoxdui.Text + "') ";
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
                    textBoxpadrino.Text = "";
                    textBoxmadrina.Text = "";
                    textBoxdui.Text = "";
                    textBoxlugarnacimiento.Text = "";
                    textBoxlugardeBautizo.Text = "";
                    dateConfirmado.Value = DateTime.Now;
                    dateexpedicion.Value = DateTime.Now;
                    datenacimiento.Value = DateTime.Now;
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
            this.informacionConfirmaTableAdapter.Fill(this.dataSetConfirma.informacionConfirma, textBoxdui.Text);

            this.reportViewer1.RefreshReport();
        }

        //Permite que la ventana pueda moverse 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RegistroConfirma_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
