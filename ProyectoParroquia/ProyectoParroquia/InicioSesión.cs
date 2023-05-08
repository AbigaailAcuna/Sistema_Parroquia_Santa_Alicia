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
using System.Runtime.InteropServices;

namespace ProyectoParroquia
{
    public partial class InicioSesión : Form
    {
        public InicioSesión()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            bool validado = true;
            if (textBoxusuario.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxusuario, "Por favor digite su usuario");
            }
            if (textBoxcontraseña.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxcontraseña, "Por favor digite su contraseña");
            }

            return validado;
        }


        private void InicioSesión_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                //verificamos validaciones
                if (validar() == true)
                {
                    //creamos objeto
                    encargado Usu = new encargado();
                    //verifacamos existencia
                    if (Usu.verificarusuario(textBoxusuario.Text.ToUpper()))
                    {
                        if (Usu.verificarcontraseña(textBoxcontraseña.Text.ToUpper()))
                        {
                            Menu abrir = new Menu();
                            abrir.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado");
                    }


                }
                else
                {
                    MessageBox.Show("No puede dejar campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la ejecución, " + error);
            }

        }
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.Show();
        }

        private void InicioSesión_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creditos cre = new Creditos();
                cre.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
