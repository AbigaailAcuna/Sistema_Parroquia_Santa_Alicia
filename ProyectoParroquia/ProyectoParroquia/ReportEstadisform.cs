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
    public partial class ReportEstadisform : Form
    {
        public ReportEstadisform()
        {
            InitializeComponent();
        }

        private void BtnGrafBautizo_Click(object sender, EventArgs e)
        {
            Graficos Bau=new Graficos();
            Bau.Show();
        }

        private void btngrafprimera_Click(object sender, EventArgs e)
        {
            GrafPrimeraComunion prime=new GrafPrimeraComunion();
            prime.Show();
        }

        private void btngrafConfirmas_Click(object sender, EventArgs e)
        {
            GrafConfirmas conf = new GrafConfirmas();
            conf.Show();
        }

        private void btngrafmatrimonios_Click(object sender, EventArgs e)
        {
            GrafMatrimonio matri=new GrafMatrimonio();
            matri.Show();
        }

        private void btnConteoTotal_Click(object sender, EventArgs e)
        {
            ReportesEstadisticos conte=new ReportesEstadisticos();
            conte.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBautizo listbau = new ListBautizo();
            listbau.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListPrimera listpri = new ListPrimera();
            listpri.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListConfirma listConf = new ListConfirma();
            listConf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListMatrimonio listMat = new ListMatrimonio();
            listMat.Show();
        }
    }
}
