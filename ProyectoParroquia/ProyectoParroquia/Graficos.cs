using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParroquia
{
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.informacionBautizo' Puede moverla o quitarla según sea necesario.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.informacionBautizoTableAdapter.Fill(this.dataSet1.informacionBautizo,  FechaFinal.Text, FechaInicial.Text);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
