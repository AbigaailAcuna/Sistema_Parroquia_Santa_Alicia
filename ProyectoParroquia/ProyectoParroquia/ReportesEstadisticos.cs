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
    public partial class ReportesEstadisticos : Form
    {
        public ReportesEstadisticos()
        {
            InitializeComponent();
        }

        private void ReportesEstadisticos_Load(object sender, EventArgs e)
        {

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.informacionBautizoTableAdapter.Fill(reportesEstadisticosSet.informacionBautizo, dateFinal.Text, dateInicial.Text);
            this.informacionMatrimonioTableAdapter.Fill(reportesEstadisticosSet.informacionMatrimonio, dateFinal.Text, dateInicial.Text);
            this.informacionConfirmaTableAdapter.Fill(reportesEstadisticosSet.informacionConfirma, dateFinal.Text, dateInicial.Text);
            this.informacionPrimeraComunionTableAdapter.Fill(reportesEstadisticosSet.informacionPrimeraComunion, dateFinal.Text, dateInicial.Text);
            this.reportViewer1.RefreshReport();

        }

        private void dateInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
