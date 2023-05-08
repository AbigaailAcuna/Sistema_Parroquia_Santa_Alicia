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
    public partial class GrafConfirmas : Form
    {
        public GrafConfirmas()
        {
            InitializeComponent();
        }

        private void GrafConfirmas_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportesEstadisticosSet.informacionConfirma' Puede moverla o quitarla según sea necesario.
            this.informacionConfirmaTableAdapter.Fill(this.reportesEstadisticosSet.informacionConfirma, dateFinal.Text, dateInicial.Text);

            this.reportViewer1.RefreshReport();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
