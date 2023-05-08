using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoParroquia
{
    public partial class formularioMatrimonio : Form
    {
        private SqlCommand insert3;
        private SqlCommand insert4;
        private SqlCommand insert5;
        public formularioMatrimonio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validar()
        {
            bool validado = true;
            if (txtNombreNovio.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtPadreNovio, "Por favor digite el nombre del padre del novio");
            }
            if (txtEdadNovio.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtEdadNovio, "Por favor digite la edad del novio");
            }
            if(txtPadreNovio.Text=="")
            {
                validado = false;
                errorProvider1.SetError(txtPadreNovio, "Por favor digite el nombre del padre del novio");
            }
            if (txtMadreNovio.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtMadreNovio, "Por favor digite el nombre de la madre del novio");
            }
            if (txtNombreNovia.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtPadreNovio, "Por favor digite el nombre del padre del novio");
            }
            if (txtEdadNovia.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtEdadNovio, "Por favor digite la edad del novio");
            }
            if (txtPadreNovia.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtPadreNovio, "Por favor digite el nombre del padre del novio");
            }
            if (txtMadreNovia.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtMadreNovio, "Por favor digite el nombre de la madre del novio");
            }
            if (txtDUI.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtDUI, "Por favor digite el DUI del responsable");
            }

            return validado;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar() == true)
                {
                    //llamamos a la clase conexion
                    Conexion connection = new Conexion();
                    connection.conectar();
                    //hacemos insert
                    string insertRegistroMatrimonio;
                    insertRegistroMatrimonio = "insert into informacionMatrimonio" +
                        "(fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia, DuiNovio,DuiNovia,estado,idActa)";
                    insertRegistroMatrimonio += "values(@fechaBoda, @edadNovio, @edadNovia, @nombreSacerdote, @nombreNovio, @nombreNovia, @padreNovio, @madreNovio, @padreNovia, @madreNovia, @Dui,@DuiNovia,@estado,@idActa)";
                    insert3 = new SqlCommand(insertRegistroMatrimonio, connection.Conn);
                    //fechaboda ARREGLAR
                    insert3.Parameters.Add(new SqlParameter("@fechaBoda", SqlDbType.Date));
                    insert3.Parameters["@fechaBoda"].Value = fechaBoda.Value;
                    //edadNovio
                    insert3.Parameters.Add(new SqlParameter("@edadNovio", SqlDbType.Int));
                    insert3.Parameters["@edadNovio"].Value = txtEdadNovio.Text;
                    //edadNovia
                    insert3.Parameters.Add(new SqlParameter("@edadNovia", SqlDbType.Int));
                    insert3.Parameters["@edadNovia"].Value = txtEdadNovia.Text;
                    //nombreSacerdote
                    insert3.Parameters.Add(new SqlParameter("@nombreSacerdote", SqlDbType.VarChar));
                    insert3.Parameters["@nombreSacerdote"].Value = txtEncargado.Text;
                    //nombreNovio
                    insert3.Parameters.Add(new SqlParameter("@nombreNovio", SqlDbType.VarChar));
                    insert3.Parameters["@nombreNovio"].Value = txtNombreNovio.Text;
                    //nombreNovia
                    insert3.Parameters.Add(new SqlParameter("@nombreNovia", SqlDbType.VarChar));
                    insert3.Parameters["@nombreNovia"].Value = txtNombreNovia.Text;
                    //padreNovio
                    insert3.Parameters.Add(new SqlParameter("@padreNovio", SqlDbType.VarChar));
                    insert3.Parameters["@padreNovio"].Value = txtPadreNovio.Text;
                    //madreNovio
                    insert3.Parameters.Add(new SqlParameter("@madreNovio", SqlDbType.VarChar));
                    insert3.Parameters["@madreNovio"].Value = txtMadreNovio.Text;
                    //padreNovia
                    insert3.Parameters.Add(new SqlParameter("@padreNovia", SqlDbType.VarChar));
                    insert3.Parameters["@padreNovia"].Value = txtPadreNovia.Text;
                    //madreNovia
                    insert3.Parameters.Add(new SqlParameter("@madreNovia", SqlDbType.VarChar));
                    insert3.Parameters["@madreNovia"].Value = txtMadreNovia.Text;
                    //Dui
                    insert3.Parameters.Add(new SqlParameter("@Dui", SqlDbType.VarChar));
                    insert3.Parameters["@Dui"].Value =txtDUI.Text;
                    insert3.Parameters.Add(new SqlParameter("@DuiNovia", SqlDbType.VarChar));
                    insert3.Parameters["@DuiNovia"].Value = txtDuiNovia.Text;
                    //
                    insert3.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar));
                    insert3.Parameters["@estado"].Value = textBox2.Text;
                    //
                    insert3.Parameters.Add(new SqlParameter("@idActa", SqlDbType.VarChar));
                    insert3.Parameters["@idActa"].Value = textBox1.Text;

                    insert3.ExecuteNonQuery();




                    //limpiando textbox
                    txtNombreNovio.Text = "";
                    txtEdadNovio.Text = "";
                    txtPadreNovio.Text = "";
                    txtMadreNovio.Text = "";
                    txtNombreNovia.Text = "";
                    txtEdadNovia.Text = "";
                    txtPadreNovia.Text = "";
                    txtMadreNovia.Text = "";
                    fechaBoda.Value = DateTime.Now;
                    txtDUI.Text = "";
                    txtDuiNovia.Text = "";


                    txtEncargado.Focus();
                    MessageBox.Show("Registro con acta de Matrimonio agregado con éxito");
                    connection.cerrar();




                }
                else
                {
                    MessageBox.Show("Ingrese la informacion correcta", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Error en la ejecucion, " + error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está entrando a menú de eliminación", "Advertencia",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(result == DialogResult.OK)
            {
                try
                {
                    textBox2.Text="NA";

                    //Llamamos a la conexión
                    Conexion connection = new Conexion();
                    connection.conectar();
                    string actualizar = "update informacionMatrimonio set estado=@estado where DuiNovio like('" + txtDUI.Text + "')";
                    insert5 = new SqlCommand(actualizar, connection.Conn);
                    insert5.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar));
                    insert5.Parameters["@estado"].Value =textBox2.Text;
                    insert5.ExecuteNonQuery();

                    MessageBox.Show("Eliminacion del registro con acta de Matrimonio modificado con exito");
                    connection.cerrar();


                    //limpiando textbox
                    txtNombreNovio.Text = "";
                    txtEdadNovio.Text = "";
                    txtPadreNovio.Text = "";
                    txtMadreNovio.Text = "";
                    txtNombreNovia.Text = "";
                    txtEdadNovia.Text = "";
                    txtPadreNovia.Text = "";
                    txtMadreNovia.Text = "";
                    fechaBoda.Value = DateTime.Now;
                    txtDUI.Text = "";
                    txtDuiNovia.Text = "";
                }
                catch(Exception error)
                {
                    MessageBox.Show("Error en la ejercucion, " + error);
                }
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta entrando a menu de actualizacion", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(result==DialogResult.OK)
            {
                try
                {
                    //llamamos a la conexión
                    Conexion connection = new Conexion();
                    connection.conectar();
                    string actualizar = "update informacionMatrimonio set fechaBoda=@fechaBoda, edadNovio=@edadNovio, edadNovia=@edadNovia, nombreSacerdote=@nombreSacerdote, nombreNovio=@nombreNovio, nombreNovia=@nombreNovia, padreNovio=@padreNovio, madreNovio=@madreNovio, padreNovia=@padreNovia, madreNovia=@madreNovia where DuiNovio like('" + txtDUI.Text + "')";
                    insert4 = new SqlCommand(actualizar, connection.Conn);
                    insert4.Parameters.Add(new SqlParameter("@fechaBoda", SqlDbType.Date));
                    insert4.Parameters["@fechaBoda"].Value = fechaBoda.Value;
                    insert4.Parameters.Add(new SqlParameter("@edadNovio", SqlDbType.VarChar));
                    insert4.Parameters["@edadNovio"].Value = txtEdadNovio.Text;
                    insert4.Parameters.Add(new SqlParameter("@edadNovia", SqlDbType.VarChar));
                    insert4.Parameters["@edadNovia"].Value = txtEdadNovia.Text;
                    insert4.Parameters.Add(new SqlParameter("@nombreSacerdote", SqlDbType.VarChar));
                    insert4.Parameters["@nombreSacerdote"].Value = txtEncargado.Text;
                    insert4.Parameters.Add(new SqlParameter("@nombreNovio", SqlDbType.VarChar));
                    insert4.Parameters["@nombreNovio"].Value = txtNombreNovio.Text;
                    insert4.Parameters.Add(new SqlParameter("@nombreNovia", SqlDbType.VarChar));
                    insert4.Parameters["@nombreNovia"].Value = txtNombreNovia.Text;
                    insert4.Parameters.Add(new SqlParameter("@padreNovio", SqlDbType.VarChar));
                    insert4.Parameters["@padreNovio"].Value = txtPadreNovio.Text;
                    insert4.Parameters.Add(new SqlParameter("@madreNovio", SqlDbType.VarChar));
                    insert4.Parameters["@madreNovio"].Value = txtMadreNovio.Text;
                    insert4.Parameters.Add(new SqlParameter("@padreNovia", SqlDbType.VarChar));
                    insert4.Parameters["@padreNovia"].Value = txtPadreNovia.Text;
                    insert4.Parameters.Add(new SqlParameter("@madreNovia", SqlDbType.VarChar));
                    insert4.Parameters["@madreNovia"].Value = txtMadreNovia.Text;

                   
                    insert4.ExecuteNonQuery();
                    //limpiando textbox
                    txtEncargado.Text = "";
                    txtEdadNovio.Text = "";
                    txtEdadNovia.Text = "";
                    txtMadreNovia.Text = "";
                    txtMadreNovio.Text = "";
                    txtNombreNovia.Text = "";
                    txtNombreNovio.Text = "";
                    txtPadreNovia.Text = "";
                    txtPadreNovio.Text = "";
                    txtDuiNovia.Text = "";
                    txtDUI.Text = "";

                    fechaBoda.Value = DateTime.Now;
                 
                    txtEncargado.Focus();
                    MessageBox.Show("Actualización del registro con acta de Matrimonio modificado con éxito");
                    connection.cerrar();
                }
                catch(Exception error)
                {
                    MessageBox.Show("Error en la ejecucion, " + error);
                }
            }
            else
            {
               
            }
        }

        private void formularioMatrimonio_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEncargado.Text = "";
            txtEdadNovio.Text = "";
            txtEdadNovia.Text = "";
            txtMadreNovia.Text = "";
            txtMadreNovio.Text = "";
            txtNombreNovia.Text = "";
            txtNombreNovio.Text = "";
            txtPadreNovia.Text = "";
            txtPadreNovio.Text = "";
            txtDuiNovia.Text = "";
            txtDUI.Text = "";
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMatrimonio.informacionMatrimonio' Puede moverla o quitarla según sea necesario.
            this.informacionMatrimonioTableAdapter.Fill(this.dataSetMatrimonio.informacionMatrimonio, txtDUI.Text);

            this.reportViewer1.RefreshReport();
        }

        //Permite que la ventana pueda moverse 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void formularioMatrimonio_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
