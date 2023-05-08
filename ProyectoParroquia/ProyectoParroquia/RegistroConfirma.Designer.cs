namespace ProyectoParroquia
{
    partial class RegistroConfirma
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
            this.informacionConfirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConfirma = new ProyectoParroquia.DataSetConfirma();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxlugardeBautizo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateexpedicion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxlugarnacimiento = new System.Windows.Forms.TextBox();
            this.textBoxdui = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateConfirmado = new System.Windows.Forms.DateTimePicker();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxpadrino = new System.Windows.Forms.TextBox();
            this.textBoxmadrina = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonacta = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttonregistrar = new System.Windows.Forms.Button();
            this.buttonregreso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.informacionConfirmaTableAdapter = new ProyectoParroquia.DataSetConfirmaTableAdapters.informacionConfirmaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.informacionConfirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConfirma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // informacionConfirmaBindingSource
            // 
            this.informacionConfirmaBindingSource.DataMember = "informacionConfirma";
            this.informacionConfirmaBindingSource.DataSource = this.dataSetConfirma;
            // 
            // dataSetConfirma
            // 
            this.dataSetConfirma.DataSetName = "DataSetConfirma";
            this.dataSetConfirma.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxlugardeBautizo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateexpedicion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxlugarnacimiento);
            this.groupBox1.Controls.Add(this.textBoxdui);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateConfirmado);
            this.groupBox1.Controls.Add(this.datenacimiento);
            this.groupBox1.Controls.Add(this.textBoxsacerdote);
            this.groupBox1.Controls.Add(this.textBoxnombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(480, 362);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Bautizado";
            // 
            // textBoxlugardeBautizo
            // 
            this.textBoxlugardeBautizo.Location = new System.Drawing.Point(195, 299);
            this.textBoxlugardeBautizo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxlugardeBautizo.Name = "textBoxlugardeBautizo";
            this.textBoxlugardeBautizo.Size = new System.Drawing.Size(248, 26);
            this.textBoxlugardeBautizo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lugar de Bautizmo:";
            // 
            // dateexpedicion
            // 
            this.dateexpedicion.CalendarTrailingForeColor = System.Drawing.Color.HotPink;
            this.dateexpedicion.Location = new System.Drawing.Point(193, 260);
            this.dateexpedicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateexpedicion.Name = "dateexpedicion";
            this.dateexpedicion.Size = new System.Drawing.Size(248, 26);
            this.dateexpedicion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha de Expedicion:";
            // 
            // textBoxlugarnacimiento
            // 
            this.textBoxlugarnacimiento.Location = new System.Drawing.Point(193, 178);
            this.textBoxlugarnacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxlugarnacimiento.Name = "textBoxlugarnacimiento";
            this.textBoxlugarnacimiento.Size = new System.Drawing.Size(248, 26);
            this.textBoxlugarnacimiento.TabIndex = 12;
            // 
            // textBoxdui
            // 
            this.textBoxdui.Location = new System.Drawing.Point(195, 101);
            this.textBoxdui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxdui.Name = "textBoxdui";
            this.textBoxdui.Size = new System.Drawing.Size(249, 26);
            this.textBoxdui.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(143, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 10;
            this.label13.Text = "DUI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Lugar de nacimiento:";
            // 
            // dateConfirmado
            // 
            this.dateConfirmado.CalendarTrailingForeColor = System.Drawing.Color.HotPink;
            this.dateConfirmado.Location = new System.Drawing.Point(193, 215);
            this.dateConfirmado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateConfirmado.Name = "dateConfirmado";
            this.dateConfirmado.Size = new System.Drawing.Size(248, 26);
            this.dateConfirmado.TabIndex = 8;
            // 
            // datenacimiento
            // 
            this.datenacimiento.Location = new System.Drawing.Point(193, 140);
            this.datenacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datenacimiento.Name = "datenacimiento";
            this.datenacimiento.Size = new System.Drawing.Size(248, 26);
            this.datenacimiento.TabIndex = 7;
            // 
            // textBoxsacerdote
            // 
            this.textBoxsacerdote.Location = new System.Drawing.Point(195, 66);
            this.textBoxsacerdote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxsacerdote.Name = "textBoxsacerdote";
            this.textBoxsacerdote.Size = new System.Drawing.Size(247, 26);
            this.textBoxsacerdote.TabIndex = 6;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(193, 30);
            this.textBoxnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(248, 26);
            this.textBoxnombre.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha de Confirmacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sacerdote:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxpadre);
            this.groupBox2.Controls.Add(this.textBoxmadre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(77, 455);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(479, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Padres";
            // 
            // textBoxpadre
            // 
            this.textBoxpadre.Location = new System.Drawing.Point(192, 92);
            this.textBoxpadre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpadre.Name = "textBoxpadre";
            this.textBoxpadre.Size = new System.Drawing.Size(248, 26);
            this.textBoxpadre.TabIndex = 6;
            // 
            // textBoxmadre
            // 
            this.textBoxmadre.Location = new System.Drawing.Point(192, 42);
            this.textBoxmadre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxmadre.Name = "textBoxmadre";
            this.textBoxmadre.Size = new System.Drawing.Size(248, 26);
            this.textBoxmadre.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nombre de Padre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre de Madre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxpadrino);
            this.groupBox3.Controls.Add(this.textBoxmadrina);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(77, 645);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(479, 159);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Padrinos";
            // 
            // textBoxpadrino
            // 
            this.textBoxpadrino.Location = new System.Drawing.Point(192, 89);
            this.textBoxpadrino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxpadrino.Name = "textBoxpadrino";
            this.textBoxpadrino.Size = new System.Drawing.Size(235, 26);
            this.textBoxpadrino.TabIndex = 6;
            // 
            // textBoxmadrina
            // 
            this.textBoxmadrina.Location = new System.Drawing.Point(193, 42);
            this.textBoxmadrina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxmadrina.Name = "textBoxmadrina";
            this.textBoxmadrina.Size = new System.Drawing.Size(235, 26);
            this.textBoxmadrina.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre de Padrino:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre de Madrina:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.informacionConfirmaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoParroquia.inforConfirma.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(608, 75);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(841, 748);
            this.reportViewer1.TabIndex = 9;
            // 
            // buttonacta
            // 
            this.buttonacta.Location = new System.Drawing.Point(588, 850);
            this.buttonacta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonacta.Name = "buttonacta";
            this.buttonacta.Size = new System.Drawing.Size(95, 39);
            this.buttonacta.TabIndex = 17;
            this.buttonacta.Text = "Generar Acta";
            this.buttonacta.UseVisualStyleBackColor = true;
            this.buttonacta.Click += new System.EventHandler(this.buttonacta_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(456, 850);
            this.buttoneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(95, 39);
            this.buttoneliminar.TabIndex = 16;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.Location = new System.Drawing.Point(323, 850);
            this.buttonactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(95, 39);
            this.buttonactualizar.TabIndex = 15;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = true;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // buttonregistrar
            // 
            this.buttonregistrar.Location = new System.Drawing.Point(188, 850);
            this.buttonregistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonregistrar.Name = "buttonregistrar";
            this.buttonregistrar.Size = new System.Drawing.Size(95, 39);
            this.buttonregistrar.TabIndex = 14;
            this.buttonregistrar.Text = "Registrar";
            this.buttonregistrar.UseVisualStyleBackColor = true;
            this.buttonregistrar.Click += new System.EventHandler(this.buttonregistrar_Click);
            // 
            // buttonregreso
            // 
            this.buttonregreso.Location = new System.Drawing.Point(44, 850);
            this.buttonregreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonregreso.Name = "buttonregreso";
            this.buttonregreso.Size = new System.Drawing.Size(95, 39);
            this.buttonregreso.TabIndex = 13;
            this.buttonregreso.Text = "Regresar";
            this.buttonregreso.UseVisualStyleBackColor = true;
            this.buttonregreso.Click += new System.EventHandler(this.buttonregreso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Registro Confirmas";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(459, 43);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(53, 19);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "A";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(459, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(37, 19);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "M04";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(401, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "Id Acta:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(401, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 18);
            this.label15.TabIndex = 19;
            this.label15.Text = "Estado:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // informacionConfirmaTableAdapter
            // 
            this.informacionConfirmaTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroConfirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1523, 919);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonacta);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonactualizar);
            this.Controls.Add(this.buttonregistrar);
            this.Controls.Add(this.buttonregreso);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroConfirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroConfirma";
            this.Load += new System.EventHandler(this.RegistroConfirma_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistroConfirma_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.informacionConfirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConfirma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        public System.Windows.Forms.DateTimePicker dateConfirmado;
        public System.Windows.Forms.DateTimePicker datenacimiento;
        public System.Windows.Forms.TextBox textBoxsacerdote;
        public System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateexpedicion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxlugardeBautizo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBoxpadre;
        public System.Windows.Forms.TextBox textBoxmadre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textBoxpadrino;
        public System.Windows.Forms.TextBox textBoxmadrina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonacta;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button buttonregistrar;
        private System.Windows.Forms.Button buttonregreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DataSetConfirma dataSetConfirma;
        private System.Windows.Forms.BindingSource informacionConfirmaBindingSource;
        private DataSetConfirmaTableAdapters.informacionConfirmaTableAdapter informacionConfirmaTableAdapter;
    }
}