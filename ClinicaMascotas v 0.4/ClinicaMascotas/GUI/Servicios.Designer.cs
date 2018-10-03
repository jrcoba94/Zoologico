namespace ClinicaMascotas.GUI
{
    partial class Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCeldaAsignada = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbRadiografia = new System.Windows.Forms.CheckBox();
            this.chbUltrasonido = new System.Windows.Forms.CheckBox();
            this.chbObservacion = new System.Windows.Forms.CheckBox();
            this.chbCirugía = new System.Windows.Forms.CheckBox();
            this.chbVacunas = new System.Windows.Forms.CheckBox();
            this.chbLimpieza = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvServicio = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbConsulS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbxVeterinario = new System.Windows.Forms.ComboBox();
            this.veterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmascotasDataSet2 = new ClinicaMascotas.cmascotasDataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMascotaIDs = new System.Windows.Forms.ComboBox();
            this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmascotasDataSet1 = new ClinicaMascotas.cmascotasDataSet1();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mascotasTableAdapter = new ClinicaMascotas.cmascotasDataSet1TableAdapters.mascotasTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.veterinarioTableAdapter = new ClinicaMascotas.cmascotasDataSet2TableAdapters.veterinarioTableAdapter();
            this.cmascotasDataSet3 = new ClinicaMascotas.cmascotasDataSet3();
            this.celdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celdaTableAdapter = new ClinicaMascotas.cmascotasDataSet3TableAdapters.celdaTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celdaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status :";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "",
            "Pendiente",
            "Terminado"});
            this.cmbStatus.Location = new System.Drawing.Point(18, 172);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(168, 21);
            this.cmbStatus.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Celda asignada :";
            // 
            // cmbCeldaAsignada
            // 
            this.cmbCeldaAsignada.DataSource = this.celdaBindingSource;
            this.cmbCeldaAsignada.DisplayMember = "nombreC";
            this.cmbCeldaAsignada.FormattingEnabled = true;
            this.cmbCeldaAsignada.Location = new System.Drawing.Point(18, 30);
            this.cmbCeldaAsignada.Name = "cmbCeldaAsignada";
            this.cmbCeldaAsignada.Size = new System.Drawing.Size(87, 21);
            this.cmbCeldaAsignada.TabIndex = 3;
            this.cmbCeldaAsignada.ValueMember = "celdaID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.chbRadiografia);
            this.groupBox1.Controls.Add(this.chbUltrasonido);
            this.groupBox1.Controls.Add(this.chbObservacion);
            this.groupBox1.Controls.Add(this.chbCirugía);
            this.groupBox1.Controls.Add(this.chbVacunas);
            this.groupBox1.Controls.Add(this.chbLimpieza);
            this.groupBox1.Location = new System.Drawing.Point(18, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de servicio";
            // 
            // chbRadiografia
            // 
            this.chbRadiografia.AutoSize = true;
            this.chbRadiografia.Location = new System.Drawing.Point(14, 87);
            this.chbRadiografia.Name = "chbRadiografia";
            this.chbRadiografia.Size = new System.Drawing.Size(82, 17);
            this.chbRadiografia.TabIndex = 5;
            this.chbRadiografia.Text = "Radiografía";
            this.chbRadiografia.UseVisualStyleBackColor = true;
            // 
            // chbUltrasonido
            // 
            this.chbUltrasonido.AutoSize = true;
            this.chbUltrasonido.Location = new System.Drawing.Point(124, 36);
            this.chbUltrasonido.Name = "chbUltrasonido";
            this.chbUltrasonido.Size = new System.Drawing.Size(79, 17);
            this.chbUltrasonido.TabIndex = 4;
            this.chbUltrasonido.Text = "Ultrasonido";
            this.chbUltrasonido.UseVisualStyleBackColor = true;
            // 
            // chbObservacion
            // 
            this.chbObservacion.AutoSize = true;
            this.chbObservacion.Location = new System.Drawing.Point(14, 63);
            this.chbObservacion.Name = "chbObservacion";
            this.chbObservacion.Size = new System.Drawing.Size(86, 17);
            this.chbObservacion.TabIndex = 3;
            this.chbObservacion.Text = "Observación";
            this.chbObservacion.UseVisualStyleBackColor = true;
            // 
            // chbCirugía
            // 
            this.chbCirugía.AutoSize = true;
            this.chbCirugía.Location = new System.Drawing.Point(123, 87);
            this.chbCirugía.Name = "chbCirugía";
            this.chbCirugía.Size = new System.Drawing.Size(60, 17);
            this.chbCirugía.TabIndex = 2;
            this.chbCirugía.Text = "Cirugía";
            this.chbCirugía.UseVisualStyleBackColor = true;
            // 
            // chbVacunas
            // 
            this.chbVacunas.AutoSize = true;
            this.chbVacunas.Location = new System.Drawing.Point(124, 63);
            this.chbVacunas.Name = "chbVacunas";
            this.chbVacunas.Size = new System.Drawing.Size(68, 17);
            this.chbVacunas.TabIndex = 1;
            this.chbVacunas.Text = "Vacunas";
            this.chbVacunas.UseVisualStyleBackColor = true;
            // 
            // chbLimpieza
            // 
            this.chbLimpieza.AutoSize = true;
            this.chbLimpieza.Location = new System.Drawing.Point(14, 36);
            this.chbLimpieza.Name = "chbLimpieza";
            this.chbLimpieza.Size = new System.Drawing.Size(67, 17);
            this.chbLimpieza.TabIndex = 0;
            this.chbLimpieza.Text = "Limpieza";
            this.chbLimpieza.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 35);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Opciones de servicios";
            // 
            // dgvServicio
            // 
            this.dgvServicio.BackgroundColor = System.Drawing.Color.White;
            this.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicio.Location = new System.Drawing.Point(17, 134);
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.Size = new System.Drawing.Size(590, 203);
            this.dgvServicio.TabIndex = 7;
            this.dgvServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicio_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(710, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbConsulS
            // 
            this.cmbConsulS.FormattingEnabled = true;
            this.cmbConsulS.Items.AddRange(new object[] {
            "",
            "Servicios",
            "Pendientes",
            "Terminados"});
            this.cmbConsulS.Location = new System.Drawing.Point(85, 52);
            this.cmbConsulS.Name = "cmbConsulS";
            this.cmbConsulS.Size = new System.Drawing.Size(121, 21);
            this.cmbConsulS.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Consultar :";
            // 
            // btnCancelarS
            // 
            this.btnCancelarS.Location = new System.Drawing.Point(24, 96);
            this.btnCancelarS.Name = "btnCancelarS";
            this.btnCancelarS.Size = new System.Drawing.Size(116, 23);
            this.btnCancelarS.TabIndex = 11;
            this.btnCancelarS.Text = "Cancelar Servicio";
            this.btnCancelarS.UseVisualStyleBackColor = true;
            this.btnCancelarS.Click += new System.EventHandler(this.btnCancelarS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mascota  :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbxVeterinario);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.cbxMascotaIDs);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbStatus);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCeldaAsignada);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvServicio);
            this.splitContainer1.Panel2.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.cmbConsulS);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelarS);
            this.splitContainer1.Size = new System.Drawing.Size(887, 355);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.SplitterIncrement = 7;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 14;
            // 
            // cbxVeterinario
            // 
            this.cbxVeterinario.DataSource = this.veterinarioBindingSource;
            this.cbxVeterinario.DisplayMember = "nombre";
            this.cbxVeterinario.FormattingEnabled = true;
            this.cbxVeterinario.Location = new System.Drawing.Point(18, 78);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(168, 21);
            this.cbxVeterinario.TabIndex = 19;
            this.cbxVeterinario.ValueMember = "veterinarioID";
            // 
            // veterinarioBindingSource
            // 
            this.veterinarioBindingSource.DataMember = "veterinario";
            this.veterinarioBindingSource.DataSource = this.cmascotasDataSet2;
            // 
            // cmascotasDataSet2
            // 
            this.cmascotasDataSet2.DataSetName = "cmascotasDataSet2";
            this.cmascotasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Veterinario :";
            // 
            // cbxMascotaIDs
            // 
            this.cbxMascotaIDs.DataSource = this.mascotasBindingSource;
            this.cbxMascotaIDs.DisplayMember = "nombreM";
            this.cbxMascotaIDs.FormattingEnabled = true;
            this.cbxMascotaIDs.Location = new System.Drawing.Point(18, 123);
            this.cbxMascotaIDs.Name = "cbxMascotaIDs";
            this.cbxMascotaIDs.Size = new System.Drawing.Size(168, 21);
            this.cbxMascotaIDs.TabIndex = 17;
            this.cbxMascotaIDs.ValueMember = "mascotasID";
            // 
            // mascotasBindingSource
            // 
            this.mascotasBindingSource.DataMember = "mascotas";
            this.mascotasBindingSource.DataSource = this.cmascotasDataSet1;
            // 
            // cmascotasDataSet1
            // 
            this.cmascotasDataSet1.DataSetName = "cmascotasDataSet1";
            this.cmascotasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(226, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(805, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mascotasTableAdapter
            // 
            this.mascotasTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 23);
            this.panel3.TabIndex = 18;
            // 
            // veterinarioTableAdapter
            // 
            this.veterinarioTableAdapter.ClearBeforeFill = true;
            // 
            // cmascotasDataSet3
            // 
            this.cmascotasDataSet3.DataSetName = "cmascotasDataSet3";
            this.cmascotasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celdaBindingSource
            // 
            this.celdaBindingSource.DataMember = "celda";
            this.celdaBindingSource.DataSource = this.cmascotasDataSet3;
            // 
            // celdaTableAdapter
            // 
            this.celdaTableAdapter.ClearBeforeFill = true;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.veterinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celdaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCeldaAsignada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbRadiografia;
        private System.Windows.Forms.CheckBox chbUltrasonido;
        private System.Windows.Forms.CheckBox chbObservacion;
        private System.Windows.Forms.CheckBox chbCirugía;
        private System.Windows.Forms.CheckBox chbVacunas;
        private System.Windows.Forms.CheckBox chbLimpieza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvServicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbConsulS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbxMascotaIDs;
        private cmascotasDataSet1 cmascotasDataSet1;
        private System.Windows.Forms.BindingSource mascotasBindingSource;
        private cmascotasDataSet1TableAdapters.mascotasTableAdapter mascotasTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxVeterinario;
        private System.Windows.Forms.Label label6;
        private cmascotasDataSet2 cmascotasDataSet2;
        private System.Windows.Forms.BindingSource veterinarioBindingSource;
        private cmascotasDataSet2TableAdapters.veterinarioTableAdapter veterinarioTableAdapter;
        private cmascotasDataSet3 cmascotasDataSet3;
        private System.Windows.Forms.BindingSource celdaBindingSource;
        private cmascotasDataSet3TableAdapters.celdaTableAdapter celdaTableAdapter;
    }
}