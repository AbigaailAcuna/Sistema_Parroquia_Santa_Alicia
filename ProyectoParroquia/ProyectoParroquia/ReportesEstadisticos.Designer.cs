namespace ProyectoParroquia
{
    partial class ReportesEstadisticos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource16 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.informacionBautizoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportesEstadisticosSet = new ProyectoParroquia.ReportesEstadisticosSet();
            this.informacionMatrimonioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.informacionConfirmaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.informacionPrimeraComunionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.informacionBautizoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informacionMatrimonioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informacionMatrimonioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parroquia1DataSet = new ProyectoParroquia.Parroquia1DataSet();
            this.informacionPrimeraComunionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informacionBautizoTableAdapter = new ProyectoParroquia.ReportesEstadisticosSetTableAdapters.informacionBautizoTableAdapter();
            this.informacionMatrimonioTableAdapter = new ProyectoParroquia.ReportesEstadisticosSetTableAdapters.informacionMatrimonioTableAdapter();
            this.informacionMatrimonioTableAdapter1 = new ProyectoParroquia.Parroquia1DataSetTableAdapters.informacionMatrimonioTableAdapter();
            this.informacionPrimeraComunionTableAdapter = new ProyectoParroquia.ReportesEstadisticosSetTableAdapters.informacionPrimeraComunionTableAdapter();
            this.dateInicial = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.informacionConfirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informacionConfirmaTableAdapter = new ProyectoParroquia.ReportesEstadisticosSetTableAdapters.informacionConfirmaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.informacionBautizoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesEstadisticosSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionMatrimonioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionConfirmaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionPrimeraComunionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionBautizoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionMatrimonioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionMatrimonioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parroquia1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionPrimeraComunionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionConfirmaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // informacionBautizoBindingSource1
            // 
            this.informacionBautizoBindingSource1.DataMember = "informacionBautizo";
            this.informacionBautizoBindingSource1.DataSource = this.reportesEstadisticosSet;
            // 
            // reportesEstadisticosSet
            // 
            this.reportesEstadisticosSet.DataSetName = "ReportesEstadisticosSet";
            this.reportesEstadisticosSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informacionMatrimonioBindingSource2
            // 
            this.informacionMatrimonioBindingSource2.DataMember = "informacionMatrimonio";
            this.informacionMatrimonioBindingSource2.DataSource = this.reportesEstadisticosSet;
            // 
            // informacionConfirmaBindingSource1
            // 
            this.informacionConfirmaBindingSource1.DataMember = "informacionConfirma";
            this.informacionConfirmaBindingSource1.DataSource = this.reportesEstadisticosSet;
            // 
            // informacionPrimeraComunionBindingSource1
            // 
            this.informacionPrimeraComunionBindingSource1.DataMember = "informacionPrimeraComunion";
            this.informacionPrimeraComunionBindingSource1.DataSource = this.reportesEstadisticosSet;
            // 
            // informacionBautizoBindingSource
            // 
            this.informacionBautizoBindingSource.DataMember = "informacionBautizo";
            this.informacionBautizoBindingSource.DataSource = this.reportesEstadisticosSet;
            // 
            // informacionMatrimonioBindingSource
            // 
            this.informacionMatrimonioBindingSource.DataMember = "informacionMatrimonio";
            this.informacionMatrimonioBindingSource.DataSource = this.reportesEstadisticosSet;
            // 
            // informacionMatrimonioBindingSource1
            // 
            this.informacionMatrimonioBindingSource1.DataMember = "informacionMatrimonio";
            this.informacionMatrimonioBindingSource1.DataSource = this.parroquia1DataSet;
            // 
            // parroquia1DataSet
            // 
            this.parroquia1DataSet.DataSetName = "Parroquia1DataSet";
            this.parroquia1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informacionPrimeraComunionBindingSource
            // 
            this.informacionPrimeraComunionBindingSource.DataMember = "informacionPrimeraComunion";
            this.informacionPrimeraComunionBindingSource.DataSource = this.reportesEstadisticosSet;
            // 
            // informacionBautizoTableAdapter
            // 
            this.informacionBautizoTableAdapter.ClearBeforeFill = true;
            // 
            // informacionMatrimonioTableAdapter
            // 
            this.informacionMatrimonioTableAdapter.ClearBeforeFill = true;
            // 
            // informacionMatrimonioTableAdapter1
            // 
            this.informacionMatrimonioTableAdapter1.ClearBeforeFill = true;
            // 
            // informacionPrimeraComunionTableAdapter
            // 
            this.informacionPrimeraComunionTableAdapter.ClearBeforeFill = true;
            // 
            // dateInicial
            // 
            this.dateInicial.Location = new System.Drawing.Point(12, 68);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(247, 22);
            this.dateInicial.TabIndex = 1;
            this.dateInicial.ValueChanged += new System.EventHandler(this.dateInicial_ValueChanged);
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(18, 146);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(247, 22);
            this.dateFinal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource13.Name = "DataSet1";
            reportDataSource13.Value = this.informacionBautizoBindingSource1;
            reportDataSource14.Name = "DataSet2";
            reportDataSource14.Value = this.informacionMatrimonioBindingSource2;
            reportDataSource15.Name = "DataSet3";
            reportDataSource15.Value = this.informacionConfirmaBindingSource1;
            reportDataSource16.Name = "DataSet4";
            reportDataSource16.Value = this.informacionPrimeraComunionBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource16);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoParroquia.ReportesEstadisticos1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(915, 492);
            this.reportViewer1.TabIndex = 3;
            // 
            // informacionConfirmaBindingSource
            // 
            this.informacionConfirmaBindingSource.DataMember = "informacionConfirma";
            this.informacionConfirmaBindingSource.DataSource = this.reportesEstadisticosSet;
            // 
            // informacionConfirmaTableAdapter
            // 
            this.informacionConfirmaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateInicial);
            this.groupBox1.Controls.Add(this.dateFinal);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(933, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 259);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conteo de actas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar fecha inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar fecha final:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1015, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(972, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "\"Conteo de Actas\"";
            // 
            // ReportesEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1228, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesEstadisticos";
            this.Text = "ReportesEstadisticos";
            this.Load += new System.EventHandler(this.ReportesEstadisticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacionBautizoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesEstadisticosSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionMatrimonioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionConfirmaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionPrimeraComunionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionBautizoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionMatrimonioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionMatrimonioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parroquia1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionPrimeraComunionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informacionConfirmaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReportesEstadisticosSet reportesEstadisticosSet;
        private System.Windows.Forms.BindingSource informacionBautizoBindingSource;
        private ReportesEstadisticosSetTableAdapters.informacionBautizoTableAdapter informacionBautizoTableAdapter;
        private System.Windows.Forms.BindingSource informacionMatrimonioBindingSource;
        private ReportesEstadisticosSetTableAdapters.informacionMatrimonioTableAdapter informacionMatrimonioTableAdapter;
        private Parroquia1DataSet parroquia1DataSet;
        private System.Windows.Forms.BindingSource informacionMatrimonioBindingSource1;
        private Parroquia1DataSetTableAdapters.informacionMatrimonioTableAdapter informacionMatrimonioTableAdapter1;
        private System.Windows.Forms.BindingSource informacionPrimeraComunionBindingSource;
        private ReportesEstadisticosSetTableAdapters.informacionPrimeraComunionTableAdapter informacionPrimeraComunionTableAdapter;
        private System.Windows.Forms.DateTimePicker dateInicial;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource informacionBautizoBindingSource1;
        private System.Windows.Forms.BindingSource informacionMatrimonioBindingSource2;
        private System.Windows.Forms.BindingSource informacionConfirmaBindingSource1;
        private System.Windows.Forms.BindingSource informacionPrimeraComunionBindingSource1;
        private System.Windows.Forms.BindingSource informacionConfirmaBindingSource;
        private ReportesEstadisticosSetTableAdapters.informacionConfirmaTableAdapter informacionConfirmaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}