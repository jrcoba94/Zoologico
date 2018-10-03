namespace ClinicaMascotas.GUI
{
    partial class Mascota
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.mtbPedigree = new System.Windows.Forms.MaskedTextBox();
            this.mtbChip = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDescripcionColor = new System.Windows.Forms.TextBox();
            this.txtDescripcionTamaño = new System.Windows.Forms.TextBox();
            this.txtDescripcionPeso = new System.Windows.Forms.TextBox();
            this.rdbMacho = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.rdbHembra = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEdadMascota = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbFotoMascota = new System.Windows.Forms.PictureBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new ClinicaMascotas.cmascotasDataSetTableAdapters.clientesTableAdapter();
            this.ofdImagenMascota = new System.Windows.Forms.OpenFileDialog();
            this.cmascotasDataSet = new ClinicaMascotas.cmascotasDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoMascota)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Cliente :";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DataSource = this.clientesBindingSource;
            this.cbxCliente.DisplayMember = "nombre";
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(34, 91);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(365, 21);
            this.cbxCliente.TabIndex = 51;
            this.cbxCliente.ValueMember = "clientesID";
            // 
            // mtbPedigree
            // 
            this.mtbPedigree.Location = new System.Drawing.Point(136, 197);
            this.mtbPedigree.Mask = "99a999aa9";
            this.mtbPedigree.Name = "mtbPedigree";
            this.mtbPedigree.Size = new System.Drawing.Size(98, 20);
            this.mtbPedigree.TabIndex = 50;
            // 
            // mtbChip
            // 
            this.mtbChip.Location = new System.Drawing.Point(34, 197);
            this.mtbChip.Mask = "999999";
            this.mtbChip.Name = "mtbChip";
            this.mtbChip.Size = new System.Drawing.Size(71, 20);
            this.mtbChip.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(31, 181);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 13);
            this.label25.TabIndex = 48;
            this.label25.Text = "Numero Chip :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtDescripcionColor);
            this.groupBox1.Controls.Add(this.txtDescripcionTamaño);
            this.groupBox1.Controls.Add(this.txtDescripcionPeso);
            this.groupBox1.Controls.Add(this.rdbMacho);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.rdbHembra);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtEdadMascota);
            this.groupBox1.Location = new System.Drawing.Point(34, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 125);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripcion";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Color :";
            // 
            // txtDescripcionColor
            // 
            this.txtDescripcionColor.Location = new System.Drawing.Point(31, 77);
            this.txtDescripcionColor.Name = "txtDescripcionColor";
            this.txtDescripcionColor.Size = new System.Drawing.Size(112, 20);
            this.txtDescripcionColor.TabIndex = 4;
            // 
            // txtDescripcionTamaño
            // 
            this.txtDescripcionTamaño.Location = new System.Drawing.Point(169, 78);
            this.txtDescripcionTamaño.Name = "txtDescripcionTamaño";
            this.txtDescripcionTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionTamaño.TabIndex = 5;
            // 
            // txtDescripcionPeso
            // 
            this.txtDescripcionPeso.Location = new System.Drawing.Point(301, 79);
            this.txtDescripcionPeso.Name = "txtDescripcionPeso";
            this.txtDescripcionPeso.Size = new System.Drawing.Size(111, 20);
            this.txtDescripcionPeso.TabIndex = 6;
            // 
            // rdbMacho
            // 
            this.rdbMacho.AutoSize = true;
            this.rdbMacho.Location = new System.Drawing.Point(161, 25);
            this.rdbMacho.Name = "rdbMacho";
            this.rdbMacho.Size = new System.Drawing.Size(58, 17);
            this.rdbMacho.TabIndex = 7;
            this.rdbMacho.TabStop = true;
            this.rdbMacho.Text = "Macho";
            this.rdbMacho.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(298, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Peso :";
            // 
            // rdbHembra
            // 
            this.rdbHembra.AutoSize = true;
            this.rdbHembra.Location = new System.Drawing.Point(254, 25);
            this.rdbHembra.Name = "rdbHembra";
            this.rdbHembra.Size = new System.Drawing.Size(62, 17);
            this.rdbHembra.TabIndex = 8;
            this.rdbHembra.TabStop = true;
            this.rdbHembra.Text = "Hembra";
            this.rdbHembra.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(167, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Tamaño :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Edad :";
            // 
            // txtEdadMascota
            // 
            this.txtEdadMascota.Location = new System.Drawing.Point(70, 24);
            this.txtEdadMascota.Name = "txtEdadMascota";
            this.txtEdadMascota.Size = new System.Drawing.Size(45, 20);
            this.txtEdadMascota.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "No. Certificado :";
            // 
            // ptbFotoMascota
            // 
            this.ptbFotoMascota.BackColor = System.Drawing.Color.White;
            this.ptbFotoMascota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbFotoMascota.Location = new System.Drawing.Point(569, 91);
            this.ptbFotoMascota.Name = "ptbFotoMascota";
            this.ptbFotoMascota.Size = new System.Drawing.Size(219, 270);
            this.ptbFotoMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFotoMascota.TabIndex = 44;
            this.ptbFotoMascota.TabStop = false;
            this.ptbFotoMascota.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ptbFotoMascota_MouseDoubleClick);
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(33, 145);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(203, 20);
            this.txtNombreMascota.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 43);
            this.panel2.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Datos De La Mascota";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 41);
            this.panel1.TabIndex = 53;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(719, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(624, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // ofdImagenMascota
            // 
            this.ofdImagenMascota.FileName = "openFileDialog1";
            // 
            // cmascotasDataSet
            // 
            this.cmascotasDataSet.DataSetName = "cmascotasDataSet";
            this.cmascotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.cmascotasDataSet;
            // 
            // Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 443);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.mtbPedigree);
            this.Controls.Add(this.mtbChip);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbFotoMascota);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar mascota";
            this.Load += new System.EventHandler(this.Mascota_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoMascota)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmascotasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.MaskedTextBox mtbPedigree;
        private System.Windows.Forms.MaskedTextBox mtbChip;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDescripcionColor;
        private System.Windows.Forms.TextBox txtDescripcionTamaño;
        private System.Windows.Forms.TextBox txtDescripcionPeso;
        private System.Windows.Forms.RadioButton rdbMacho;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton rdbHembra;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEdadMascota;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbFotoMascota;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private cmascotasDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.OpenFileDialog ofdImagenMascota;
        private cmascotasDataSet cmascotasDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    }
}