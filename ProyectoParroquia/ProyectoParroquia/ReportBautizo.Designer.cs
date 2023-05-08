namespace ProyectoParroquia
{
    partial class ReportBautizo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.informacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDui = new System.Windows.Forms.TextBox();
            this.BtnDui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bautizoDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bautizoDataset = new ProyectoParroquia.BautizoDataset();
            this.informacionTableAdapter = new ProyectoParroquia.BautizoDatasetTableAdapters.informacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.informacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bautizoDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bautizoDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.informacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoParroquia.InformeBautizo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(114, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(597, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // informacionBindingSource
            // 
            this.informacionBindingSource.DataMember = "informacion";
            this.informacionBindingSource.DataSource = this.bautizoDatasetBindingSource;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(284, 12);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(100, 20);
            this.txtDui.TabIndex = 1;
            // 
            // BtnDui
            // 
            this.BtnDui.Location = new System.Drawing.Point(405, 12);
            this.BtnDui.Name = "BtnDui";
            this.BtnDui.Size = new System.Drawing.Size(75, 23);
            this.BtnDui.TabIndex = 2;
            this.BtnDui.Text = "Generar";
            this.BtnDui.UseVisualStyleBackColor = true;
            this.BtnDui.Click += new System.EventHandler(this.BtnDui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar el Dui del Bautizado";
            // 
            // bautizoDatasetBindingSource
            // 
            this.bautizoDatasetBindingSource.DataSource = this.bautizoDataset;
            this.bautizoDatasetBindingSource.Position = 0;
            // 
            // bautizoDataset
            // 
            this.bautizoDataset.DataSetName = "BautizoDataset";
            this.bautizoDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informacionTableAdapter
            // 
            this.informacionTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBautizo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDui);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBautizo";
            this.Text = "ReportBautizo";
            this.Load += new System.EventHandler(this.ReportBautizo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bautizoDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bautizoDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bautizoDatasetBindingSource;
        private BautizoDataset bautizoDataset;
        private System.Windows.Forms.BindingSource informacionBindingSource;
        private BautizoDatasetTableAdapters.informacionTableAdapter informacionTableAdapter;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Button BtnDui;
        private System.Windows.Forms.Label label1;
    }
}