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
    public partial class ReportBautizo : Form
    {
        public ReportBautizo()
        {
            InitializeComponent();
        }

        private void ReportBautizo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bautizoDataset.informacion' Puede moverla o quitarla según sea necesario.
            
        }

        private void BtnDui_Click(object sender, EventArgs e)
        {
            this.informacionTableAdapter.Fill(this.bautizoDataset.informacion,txtDui.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
