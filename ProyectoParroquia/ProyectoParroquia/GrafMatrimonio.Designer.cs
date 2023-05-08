namespace ProyectoParroquia
{
    partial class GrafMatrimonio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.informacionMatrimonioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportesEstadisticosSet = new ProyectoParroquia.ReportesEstadisticosSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.informacionMatrimonioTableAdapter = new ProyectoParroquia.ReportesEstadisticosSetTableAdapters.informacionMatrimonioTableAdapter();
            this.dateinicial = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.informacionMatrimonioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesEstadisticosSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // informacionMatrimonioBindingSource
            // 
            this.informacionMatrimonioBindingSource.DataMember = "informacionMatrimonio";
            this.informacionMatrimonioBindingSource.DataSource = this.reportesEstadisticosSet;
            // 
            // reportesEstadisticosSet
            // 
            this.reportesEstadisticosSet.DataSetName = "ReportesEstadisticosSet";
            this.reportesEstadisticosSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.informacionMatrimonioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoParroquia.GrafMatrimonio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(953, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // informacionMatrimonioTableAdapter
            // 
            this.informacionMatrimonioTableAdapter.ClearBeforeFill = true;
            // 
            // dateinicial
            // 
            this.dateinicial.Location = new System.Drawing.Point(22, 74);
            this.dateinicial.Name = "dateinicial";
            this.dateinicial.Size = new System.Drawing.Size(246, 22);
            this.dateinicial.TabIndex = 1;
            this.dateinicial.ValueChanged += new System.EventHandler(this.dateinicial_ValueChanged);
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(22, 154);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(246, 22);
            this.dateFinal.TabIndex = 1;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.Location = new System.Drawing.Point(54, 212);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(172, 38);
            this.BtnGenerar.TabIndex = 2;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar fecha final:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1059, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateinicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateFinal);
            this.groupBox1.Controls.Add(this.BtnGenerar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(972, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 290);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Fechas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1030, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "\"Matrimonios\"";
            // 
            // GrafMatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1278, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GrafMatrimonio";
            this.Text = "GrafMatrimonio";
            this.Load += new System.EventHandler(this.GrafMatrimonio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacionMatrimonioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesEstadisticosSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportesEstadisticosSet reportesEstadisticosSet;
        private System.Windows.Forms.BindingSource informacionMatrimonioBindingSource;
        private ReportesEstadisticosSetTableAdapters.informacionMatrimonioTableAdapter informacionMatrimonioTableAdapter;
        private System.Windows.Forms.DateTimePicker dateinicial;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}