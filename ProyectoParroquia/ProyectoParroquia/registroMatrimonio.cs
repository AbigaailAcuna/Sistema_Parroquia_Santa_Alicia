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
    public partial class registroMatrimonio : Form
    {
        public registroMatrimonio()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            formularioMatrimonio registroMatrimonio= new formularioMatrimonio();
            registroMatrimonio.MdiParent = this.MdiParent;
            registroMatrimonio.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar controles
            rbDui.Checked = false;
            rbNombre.Checked = false;
            txtBusqueda.Text = "";

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
                if(rbDui.Checked==true&&RdNovio.Checked==true)
                {
                    //realizamos busqueda
                    cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where DuiNovio like ('" + txtBusqueda.Text + "') and idActa like 'M01' and estado='A'";
                }else if(rbNombre.Checked==true&&RdNovio.Checked==true)
                {
                    //realizamos busqueda
                    cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where nombreNovio like('" + txtBusqueda.Text + "') and idActa like 'M01' and estado='A'";
                }
                //novia
                else if (rbDui.Checked == true && RdNovia.Checked == true)
                {
                    //realizamos busqueda
                    cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where DuiNovia like ('" + txtBusqueda.Text + "') and idActa like 'M01' and estado='A'";
                }
                else if (rbNombre.Checked == true && RdNovia.Checked == true)
                {
                    //realizamos busqueda
                    cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where nombreNovia like('" + txtBusqueda.Text + "') and idActa like 'M01' and estado='A'";
                }
                else
                {
                    cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where idActa like 'M01' and estado='A'";
                }
                //realizzamos la busqueda
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                abrir.cerrar();
            }
            catch(Exception error)
            {
                MessageBox.Show("Error en la ejecucion" + error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                formularioMatrimonio ma=new formularioMatrimonio();
                formularioMatrimonio matrimonio = new formularioMatrimonio();
               
                matrimonio.Show();
                matrimonio.txtDUI.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                matrimonio.txtDuiNovia.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                
                matrimonio.txtEncargado.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                matrimonio.txtEdadNovia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                matrimonio.txtEdadNovio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                matrimonio.txtNombreNovio.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                matrimonio.txtNombreNovia.Text=dataGridView1.CurrentRow.Cells[7].Value.ToString();
                matrimonio.txtPadreNovio.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                matrimonio.txtPadreNovia.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                matrimonio.fechaBoda.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                matrimonio.txtMadreNovia.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                matrimonio.txtMadreNovio.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();



            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la ejercucion , " + error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                //llamamos a la conexión
                Conexion abrir = new Conexion();
                abrir.conectar();
                SqlCommand cmd = abrir.Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //realizamos la búsqueda
                cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where idActa like 'M01' and estado='A' ";
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

        private void registroMatrimonio_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (rbDui.Checked == false && rbNombre.Checked == false)
            {
                MessageBox.Show("Debe seleccionar alguna opción para efectuar la búsqueda", "ERROR EN BÚSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (RdNovia.Checked == false && RdNovio.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar alguna opción 'novio' o 'novia' para efectuar la búsqueda", "ERROR EN BÚSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (rbDui.Checked == true&&RdNovio.Checked==true)
                    {
                        try
                        {
                            //llamamos a la conexión
                            Conexion abrir = new Conexion();
                            abrir.conectar();
                            SqlCommand cmd = abrir.Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            //realizamos la búsqueda
                            cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where DuiNovio like ('" + txtBusqueda.Text + "') and idActa like 'M01' and estado='A'";
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

                    }//if dui
                    else if (rbNombre.Checked == true&& RdNovio.Checked==true)
                    {
                        try
                        {
                            //llamamos a la conexión
                            Conexion abrir = new Conexion();
                            abrir.conectar();
                            SqlCommand cmd = abrir.Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            //realizamos la búsqueda
                            cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where nombreNovio like('" + txtBusqueda.Text + "') and idActa like 'M01' and estado='A'";
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
                    //novia
                    else if (rbDui.Checked == true && RdNovia.Checked == true)
                    {
                        try
                        {
                            //llamamos a la conexión
                            Conexion abrir = new Conexion();
                            abrir.conectar();
                            SqlCommand cmd = abrir.Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            //realizamos la búsqueda
                            cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where DuiNovia like ('" + txtBusqueda.Text + "') and idActa like 'M01' and estado='A'";
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

                    }//if dui
                    else if (rbNombre.Checked == true && RdNovia.Checked == true)
                    {
                        try
                        {
                            //llamamos a la conexión
                            Conexion abrir = new Conexion();
                            abrir.conectar();
                            SqlCommand cmd = abrir.Conn.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            //realizamos la búsqueda
                            cmd.CommandText = "select DuiNovio,DuiNovia,fechaBoda, edadNovio, edadNovia, nombreSacerdote, nombreNovio, nombreNovia, padreNovio, madreNovio, padreNovia, madreNovia from informacionMatrimonio where nombreNovia like('" + txtBusqueda.Text + "') and idActa like 'M01' and estado='A'";
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

                    else
                    {
                        MessageBox.Show("Seleccione una opción válida");
                    }
                }
            }

        }

        private void RdNovio_CheckedChanged(object sender, EventArgs e)
        {
            if (RdNovio.Checked == true) 
            {
                RdNovia.Checked = false;
            }

        }

        private void RdNovia_CheckedChanged(object sender, EventArgs e)
        {
            if (RdNovia.Checked == true) 
            {
                RdNovio.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GrafMatrimonio matri = new GrafMatrimonio();
            matri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListMatrimonio listMatri = new ListMatrimonio();
            listMatri.Show();
        }
    }
}
