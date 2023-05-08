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
    public partial class Confirmas : Form
    {
        public Confirmas()
        {
            InitializeComponent();
        }

        private void Confirmas_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                //llamamos a la conexión
                Conexion abrir = new Conexion();
                abrir.conectar();
                SqlCommand cmd = abrir.Conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //realizamos la búsqueda
                cmd.CommandText = "select Nombre, Dui, NombreSacerdote,NombrePadre,NombreMadre,NombreMadrinadeConfirma,NombrePadrinodeConfirma,LugarNacimiento,LugardeBautismo,fechanacimiento,fechaConfirmacion,fechaExpedicion from informacionConfirma where idActa like 'M04' and estado='A' ";
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

        private void btnFiltro_Click(object sender, EventArgs e)
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
                        //llamamos a la conexión
                        Conexion abrir = new Conexion();
                        abrir.conectar();
                        SqlCommand cmd = abrir.Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        //realizamos la búsqueda
                        cmd.CommandText = "select Nombre, Dui, NombreSacerdote,NombrePadre,NombreMadre,NombreMadrinadeConfirma,NombrePadrinodeConfirma,LugarNacimiento,LugardeBautismo,fechanacimiento,fechaConfirmacion,fechaExpedicion from informacionConfirma where Dui like ('" + textBoxBusqueda.Text + "') and idActa like 'M04' and estado='A' ";
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
                else if (radioButtonnombre.Checked == true)
                {
                    try
                    {
                        //llamamos a la conexión
                        Conexion abrir = new Conexion();
                        abrir.conectar();
                        SqlCommand cmd = abrir.Conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        //realizamos la búsqueda
                        cmd.CommandText = "select Nombre, Dui, NombreSacerdote,NombrePadre,NombreMadre,NombreMadrinadeConfirma,NombrePadrinodeConfirma,LugarNacimiento,LugardeBautismo,fechanacimiento,fechaConfirmacion,fechaExpedicion from informacionConfirma where Nombre like ('" + textBoxBusqueda.Text + "') and idActa like 'M04' and estado='A'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroConfirma confir=new RegistroConfirma();
            confir.MdiParent=this.MdiParent;
            confir.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiamos controles 
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
                    cmd.CommandText = "select Nombre, Dui, NombreSacerdote,NombrePadre,NombreMadre,NombreMadrinadeConfirma,NombrePadrinodeConfirma,LugarNacimiento,LugardeBautismo,fechanacimiento,fechaConfirmacion,fechaExpedicion from informacionConfirma where Dui like ('" + textBoxBusqueda.Text + "') and idActa like 'M04' and estado='A' ";

                }
                else if (radioButtonnombre.Checked == true)
                {
                    //realizamos la búsqueda
                    cmd.CommandText = "select Nombre, Dui, NombreSacerdote,NombrePadre,NombreMadre,NombreMadrinadeConfirma,NombrePadrinodeConfirma,LugarNacimiento,LugardeBautismo,fechanacimiento,fechaConfirmacion,fechaExpedicion from informacionConfirma where Nombre like ('" + textBoxBusqueda.Text + "') and idActa like 'M04' and estado='A'  ";
                }
                else
                {
                    cmd.CommandText = "select Nombre, Dui, NombreSacerdote,NombrePadre,NombreMadre,NombreMadrinadeConfirma,NombrePadrinodeConfirma,LugarNacimiento,LugardeBautismo,fechanacimiento,fechaConfirmacion,fechaExpedicion from informacionConfirma where idActa like 'M04' and estado='A' ";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                RegistroConfirma confir = new RegistroConfirma();
                confir.Show();
                confir.textBoxnombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                confir.textBoxdui.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                confir.textBoxsacerdote.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                confir.textBoxpadre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                confir.textBoxmadre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                confir.textBoxmadrina.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                confir.textBoxpadrino.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                confir.textBoxlugarnacimiento.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                confir.textBoxlugardeBautizo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                confir.datenacimiento.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
                confir.dateConfirmado.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                confir.dateexpedicion.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                


            }

            catch (Exception error)
            {
                MessageBox.Show("Error en la ejecución, " + error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            GrafConfirmas conf =new GrafConfirmas();
            conf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListConfirma listconf =new ListConfirma();
            listconf.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
