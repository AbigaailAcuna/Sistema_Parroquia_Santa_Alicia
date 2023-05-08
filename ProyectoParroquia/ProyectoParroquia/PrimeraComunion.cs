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

namespace ProyectoParroquia
{
    public partial class PrimeraComunion : Form
    {
        public PrimeraComunion()
        {
            InitializeComponent();
            
        }
        
        
        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //llamamos a la conexión
                Conexion abrir = new Conexion();
                abrir.conectar();
                SqlCommand cmd = abrir.Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //realizamos la búsqueda
                cmd.CommandText = "select Nombre,Dui,NombreSacerdote,NombrePadre,NombreMadre,LugarNacimiento,fechanacimiento,fecharegistro,estado,idActa from informacionPrimeraComunion where idActa like 'M03' and estado='A' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                abrir.cerrar();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la ejecución" + error);
            }

        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            if (radioButtondui.Checked == false && radioButtonnombre.Checked == false)
            {
                MessageBox.Show("Debe seleccionar alguna opción para efectuar la búsqueda", "ERROR EN BÚSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (radioButtondui.Checked == true)
                {
                    try
                    {
                        Conexion abrir = new Conexion();
                        abrir.conectar();
                        SqlCommand cmd = abrir.Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select Nombre,Dui,NombreSacerdote,NombrePadre,NombreMadre,LugarNacimiento,fechanacimiento,fecharegistro,estado,idActa from informacionPrimeraComunion where Dui like ('" + textBoxBusqueda.Text + "') and idActa like 'M03' and estado='A'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        abrir.cerrar();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error en la ejecucion" + error);
                    }
                }
                else if (radioButtonnombre.Checked == true) 
                {
                    try
                    {
                        Conexion abrir = new Conexion();
                        abrir.conectar();
                        SqlCommand cmd = abrir.Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        //realizamos la búsqueda
                        cmd.CommandText = "select Nombre,Dui,NombreSacerdote,NombrePadre,NombreMadre,LugarNacimiento,fechanacimiento,fecharegistro,estado,idActa from informacionPrimeraComunion where Nombre like ('" + textBoxBusqueda.Text + "') and idActa like 'M03' and estado='A'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        abrir.cerrar();
                    }
                    catch (Exception error) 
                    {
                        MessageBox.Show("Seleccione una opción válida"+error);

                    }

                }
                else
                {
                    MessageBox.Show("Seleccione una opción válida");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            radioButtonnombre.Checked = false;
            radioButtondui.Checked = false;
            textBoxBusqueda.Text = "";
            //limpiamos el dtw
            DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion abrir = new Conexion();
                abrir.conectar();
                SqlCommand cmd = abrir.Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (radioButtondui.Checked == true)
                {
                    //realizamos la búsqueda
                    cmd.CommandText = "select Nombre,Dui,NombreSacerdote,NombrePadre,NombreMadre,LugarNacimiento,fechanacimiento,fecharegistro,estado,idActa from informacionPrimeraComunion where Dui like ('" + textBoxBusqueda.Text + "') and idActa like 'M03' and estado='A' ";

                }
                else if (radioButtonnombre.Checked == true)
                {
                    //realizamos la búsqueda
                    cmd.CommandText = "select Nombre,Dui,NombreSacerdote,NombrePadre,NombreMadre,LugarNacimiento,fechanacimiento,fecharegistro,estado,idActa from informacionPrimeraComunion where Nombre like ('" + textBoxBusqueda.Text + "') and idActa like 'M03' and estado='A' ";
                }
                else
                {
                    cmd.CommandText = "select Nombre,Dui,NombreSacerdote,NombrePadre,NombreMadre,LugarNacimiento,fechanacimiento,fecharegistro,estado,idActa from informacionPrimeraComunion where idActa like 'M03' and estado='A'";
                }

                //realizamos la búsqueda
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                abrir.cerrar();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la ejecución" + error);
            }

        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            RegistroPrimeraComunion primeracom=new RegistroPrimeraComunion();
            primeracom.MdiParent=this.MdiParent;
            primeracom.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RegistroPrimeraComunion primera = new RegistroPrimeraComunion();
                primera.Show();
                primera.textBoxnombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                primera.textBoxdui.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                primera.textBoxsacerdote.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                primera.textBoxpadre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                primera.textBoxmadre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                primera.textBoxlugarnacimiento.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                primera.datenacimiento.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                primera.dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception error) 
            {
                MessageBox.Show("Error en la ejecución, " + error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GrafPrimeraComunion primera = new GrafPrimeraComunion();
            primera.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListPrimera listpri= new ListPrimera();
            listpri.Show();
        }
    }
}
