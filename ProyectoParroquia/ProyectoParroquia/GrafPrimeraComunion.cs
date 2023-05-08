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
    public partial class GrafPrimeraComunion : Form
    {
        public GrafPrimeraComunion()
        {
            InitializeComponent();
        }

        private void GrafPrimeraComunion_Load(object sender, EventArgs e)
        {
            
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reportesEstadisticosSet.informacionPrimeraComunion' Puede moverla o quitarla según sea necesario.
            this.informacionPrimeraComunionTableAdapter.Fill(this.reportesEstadisticosSet.informacionPrimeraComunion,dateFinal.Text,dateInicial.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
