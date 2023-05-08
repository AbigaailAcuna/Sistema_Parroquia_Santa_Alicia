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
    public partial class ListBautizo : Form
    {
        public ListBautizo()
        {
            InitializeComponent();
        }

        private void ListBautizo_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.informacionBautizoTableAdapter.Fill(reportesEstadisticosSet.informacionBautizo, FechaFinal.Text, FechaInicial.Text);
                this.reportViewer1.RefreshReport();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
