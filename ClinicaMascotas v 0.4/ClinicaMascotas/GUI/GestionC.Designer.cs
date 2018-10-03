namespace ClinicaMascotas.GUI
{
    partial class GestionC
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaIn = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAl = new System.Windows.Forms.DateTimePicker();
            this.cbxMascota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gvCelda = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVcelda = new System.Windows.Forms.Button();
            this.cmascotasDataSet1 = new ClinicaMascotas.cmascotasDataSet1();
            this.cmascotasDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasTableAdapter = new ClinicaMascotas.cmascotasDataSet1TableAdapters.mascotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAsignar);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbxMascota);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaAl);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaIn);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnVcelda);
            this.splitContainer1.Panel2.Controls.Add(this.btnActualizar);
            this.splitContainer1.Panel2.Controls.Add(this.gvCelda);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(639, 254);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.SplitterIncrement = 8;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 30);
            this.panel1.TabIndex = 0;
            // 
            // dtpFechaIn
            // 
            this.dtpFechaIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIn.Location = new System.Drawing.Point(21, 90);
            this.dtpFechaIn.Name = "dtpFechaIn";
            this.dtpFechaIn.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaIn.TabIndex = 2;
            // 
            // dtpFechaAl
            // 
            this.dtpFechaAl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAl.Location = new System.Drawing.Point(21, 146);
            this.dtpFechaAl.Name = "dtpFechaAl";
            this.dtpFechaAl.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaAl.TabIndex = 3;
            // 
            // cbxMascota
            // 
            this.cbxMascota.DataSource = this.mascotasBindingSource;
            this.cbxMascota.DisplayMember = "nombreM";
            this.cbxMascota.FormattingEnabled = true;
            this.cbxMascota.Location = new System.Drawing.Point(21, 35);
            this.cbxMascota.Name = "cbxMascota";
            this.cbxMascota.Size = new System.Drawing.Size(121, 21);
            this.cbxMascota.TabIndex = 4;
            this.cbxMascota.ValueMember = "mascotasID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mascota :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha ingreso :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Alta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opciones";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(19, 196);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(63, 23);
            this.btnAsignar.TabIndex = 8;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(96, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gvCelda
            // 
            this.gvCelda.BackgroundColor = System.Drawing.Color.White;
            this.gvCelda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvCelda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCelda.Location = new System.Drawing.Point(18, 85);
            this.gvCelda.Name = "gvCelda";
            this.gvCelda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvCelda.Size = new System.Drawing.Size(404, 150);
            this.gvCelda.TabIndex = 1;
            this.gvCelda.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvCelda_RowHeaderMouseClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(18, 56);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnVcelda
            // 
            this.btnVcelda.Location = new System.Drawing.Point(107, 56);
            this.btnVcelda.Name = "btnVcelda";
            this.btnVcelda.Size = new System.Drawing.Size(106, 23);
            this.btnVcelda.TabIndex = 10;
            this.btnVcelda.Text = "Vacíar celda";
            this.btnVcelda.UseVisualStyleBackColor = true;
            this.btnVcelda.Click += new System.EventHandler(this.btnVcelda_Click);
            // 
            // cmascotasDataSet1
            // 
            this.cmascotasDataSet1.DataSetName = "cmascotasDataSet1";
            this.cmascotasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmascotasDataSet1BindingSource
            // 
            this.cmascotasDataSet1BindingSource.DataSource = this.cmascotasDataSet1;
            this.cmascotasDataSet1BindingSource.Position = 0;
            // 
            // mascotasBindingSource
            // 
            this.mascotasBindingSource.DataMember = "mascotas";
            this.mascotasBindingSource.DataSource = this.cmascotasDataSet1BindingSource;
            // 
            // mascotasTableAdapter
            // 
            this.mascotasTableAdapter.ClearBeforeFill = true;
            // 
            // GestionC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 254);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "GestionC";
            this.ShowIcon = false;
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.GestionC_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMascota;
        private System.Windows.Forms.DateTimePicker dtpFechaAl;
        private System.Windows.Forms.DateTimePicker dtpFechaIn;
        private System.Windows.Forms.Button btnVcelda;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView gvCelda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource cmascotasDataSet1BindingSource;
        private cmascotasDataSet1 cmascotasDataSet1;
        private System.Windows.Forms.BindingSource mascotasBindingSource;
        private cmascotasDataSet1TableAdapters.mascotasTableAdapter mascotasTableAdapter;
    }
}