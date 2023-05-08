namespace ProyectoParroquia
{
    partial class RegistroPrimeraComunion
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
            this.informacionPrimeraComunionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrimeraComunion = new ProyectoParroquia.DataSetPrimeraComunion();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxlugarnacimiento = new System.Windows.Forms.TextBox();
            this.textBoxdui = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.datenacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxsacerdote = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxpadre = new System.Windows.Forms.TextBox();
            this.textBoxmadre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonacta = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttonregistrar = new System.Windows.Forms.Button();
            this.buttonregreso = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.informacionPrimeraComunionTableAdapter = new ProyectoParroquia.DataSetPrimeraComunionTableAdapters.informacionPrimeraComunionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.informacionPrimeraComunionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimeraComunion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // informacionPrimeraComunionBindingSource
            // 
            this.informacionPrimeraComunionBindingSource.DataMember = "informacionPrimeraComunion";
            this.informacionPrimeraComunionBindingSource.DataSource = this.dataSetPrimeraComunion;
            // 
            // dataSetPrimeraComunion
            // 
            this.dataSetPrimeraComunion.DataSetName = "DataSetPrimeraComunion";
            this.dataSetPrimeraComunion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxlugarnacimiento);
            this.groupBox1.Controls.Add(this.textBoxdui);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.datenacimiento);
            this.groupBox1.Controls.Add(this.textBoxsacerdote);
            this.groupBox1.Controls.Add(this.textBoxnombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(513, 266);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Bautizado";
            // 
            // textBoxlugarnacimiento
            // 
            this.textBoxlugarnacimiento.Location = new System.Drawing.Point(249, 178);
            this.textBoxlugarnacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxlugarnacimiento.Name = "textBoxlugarnacimiento";
            this.textBoxlugarnacimiento.Size = new System.Drawing.Size(248, 26);
            this.textBoxlugarnacimiento.TabIndex = 12;
            // 
            // textBoxdui
            // 
            this.textBoxdui.Location = new System.Drawing.Point(251, 101);
            this.textBoxdui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxdui.Name = "textBoxdui";
            this.textBoxdui.Size = new System.Drawing.Size(249, 26);
            this.textBoxdui.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(203, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 10;
            this.label13.Text = "DUI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Lugar de nacimiento:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.HotPink;
            this.dateTimePicker2.Location = new System.Drawing.Point(251, 215);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(248, 26);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // datenacimiento
            // 
            this.datenacimiento.Location = new System.Drawing.Point(249, 140);
            this.datenacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datenacimiento.Name = "datenacimiento";
            this.datenacimiento.Size = new System.Drawing.Size(248, 26);
            this.datenacimiento.TabIndex = 7;
            // 
            // textBoxsacerdote
            // 
            this.textBoxsacerdote.Location = new System.Drawing.Point(251, 66);
            this.textBoxsacerdote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxsacerdote.Name = "textBoxsacerdote";
            this.textBoxsacerdote.Size = new System.Drawing.Size(247, 26);
            this.textBoxsacerdote.TabIndex = 6;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(249, 30);
            this.textBoxnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(248, 26);
            this.textBoxnombre.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha de Primera Comunion:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sacerdote:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxpadre);
            this.groupBox2.Controls.Add(this.textBoxmadre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 407);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(513, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Padres";
            // 
            // textBoxpadre
            // 
            this.textBoxpadre.Location = new System.Drawing.Point(249, 89);
            this.textBoxpadre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpadre.Name = "textBoxpadre";
            this.textBoxpadre.Size = new System.Drawing.Size(248, 26);
            this.textBoxpadre.TabIndex = 6;
            // 
            // textBoxmadre
            // 
            this.textBoxmadre.Location = new System.Drawing.Point(249, 37);
            this.textBoxmadre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxmadre.Name = "textBoxmadre";
            this.textBoxmadre.Size = new System.Drawing.Size(248, 26);
            this.textBoxmadre.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nombre de Padre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre de Madre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registro Primera Comunion";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(536, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(37, 19);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "M03";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id Acta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estado:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(536, 57);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(53, 19);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "A";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.informacionPrimeraComunionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoParroquia.inforPrimeraComunion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(603, 78);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(829, 573);
            this.reportViewer1.TabIndex = 14;
            // 
            // buttonacta
            // 
            this.buttonacta.Location = new System.Drawing.Point(587, 677);
            this.buttonacta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonacta.Name = "buttonacta";
            this.buttonacta.Size = new System.Drawing.Size(95, 39);
            this.buttonacta.TabIndex = 19;
            this.buttonacta.Text = "Generar Acta";
            this.buttonacta.UseVisualStyleBackColor = true;
            this.buttonacta.Click += new System.EventHandler(this.buttonacta_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(455, 677);
            this.buttoneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(95, 39);
            this.buttoneliminar.TabIndex = 18;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.Location = new System.Drawing.Point(321, 677);
            this.buttonactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(95, 39);
            this.buttonactualizar.TabIndex = 17;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = true;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // buttonregistrar
            // 
            this.buttonregistrar.Location = new System.Drawing.Point(187, 677);
            this.buttonregistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonregistrar.Name = "buttonregistrar";
            this.buttonregistrar.Size = new System.Drawing.Size(95, 39);
            this.buttonregistrar.TabIndex = 16;
            this.buttonregistrar.Text = "Registrar";
            this.buttonregistrar.UseVisualStyleBackColor = true;
            this.buttonregistrar.Click += new System.EventHandler(this.buttonregistrar_Click);
            // 
            // buttonregreso
            // 
            this.buttonregreso.Location = new System.Drawing.Point(43, 677);
            this.buttonregreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonregreso.Name = "buttonregreso";
            this.buttonregreso.Size = new System.Drawing.Size(95, 39);
            this.buttonregreso.TabIndex = 15;
            this.buttonregreso.Text = "Regresar";
            this.buttonregreso.UseVisualStyleBackColor = true;
            this.buttonregreso.Click += new System.EventHandler(this.buttonregreso_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // informacionPrimeraComunionTableAdapter
            // 
            this.informacionPrimeraComunionTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroPrimeraComunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1515, 857);
            this.Controls.Add(this.buttonacta);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.buttonregistrar);
            this.Controls.Add(this.buttonregreso);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroPrimeraComunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroPrimeraComunion";
            this.Load += new System.EventHandler(this.RegistroPrimeraComunion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistroPrimeraComunion_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.informacionPrimeraComunionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimeraComunion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBoxlugarnacimiento;
        public System.Windows.Forms.TextBox textBoxdui;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker datenacimiento;
        public System.Windows.Forms.TextBox textBoxsacerdote;
        public System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBoxpadre;
        public System.Windows.Forms.TextBox textBoxmadre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonacta;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button buttonregistrar;
        private System.Windows.Forms.Button buttonregreso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DataSetPrimeraComunion dataSetPrimeraComunion;
        private System.Windows.Forms.BindingSource informacionPrimeraComunionBindingSource;
        private DataSetPrimeraComunionTableAdapters.informacionPrimeraComunionTableAdapter informacionPrimeraComunionTableAdapter;
    }
}