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
    public partial class ListMatrimonio : Form
    {
        public ListMatrimonio()
        {
            InitializeComponent();
        }

        private void ListMatrimonio_Load(object sender, EventArgs e)
        {

            
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            this.informacionMatrimonioTableAdapter.Fill(reportesEstadisticosSet.informacionMatrimonio, dateFinal.Text, dateInicial.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
