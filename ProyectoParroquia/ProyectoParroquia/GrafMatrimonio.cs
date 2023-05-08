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
    public partial class GrafMatrimonio : Form
    {
        public GrafMatrimonio()
        {
            InitializeComponent();
        }

        private void GrafMatrimonio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportesEstadisticosSet.informacionMatrimonio' Puede moverla o quitarla según sea necesario.
            
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            this.informacionMatrimonioTableAdapter.Fill(this.reportesEstadisticosSet.informacionMatrimonio,dateFinal.Text,dateinicial.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateinicial_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
