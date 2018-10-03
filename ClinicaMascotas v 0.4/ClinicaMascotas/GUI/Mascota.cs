using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using ClinicaMascotas.BO;
using ClinicaMascotas.Control;

namespace ClinicaMascotas.GUI
{
    public partial class Mascota : Form
    {
        MascotaBO omBO = new MascotaBO();
        MascotaCONTROL omCTL = new MascotaCONTROL();
        string genero;

        public Mascota()
        {
            InitializeComponent();
        }

        private void ptbFotoMascota_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (ofdImagenMascota.ShowDialog() == DialogResult.OK)
                {
                    string Foto = ofdImagenMascota.FileName;
                    ptbFotoMascota.Image = Image.FromFile(Foto);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Formato no válido");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMascota();
            limpiarcampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea salir de la vetana", "Salir", MessageBoxButtons.OKCancel);
            Close();
        }

        public void GuardarMascota()
        {
            if (
             ptbFotoMascota.Image == null || txtDescripcionColor.Text.Length == 0 || txtDescripcionPeso.Text.Length == 0 ||
             txtDescripcionTamaño.Text.Length == 0 || txtEdadMascota.Text.Length == 0 || txtNombreMascota.Text.Length == 0 ||
             mtbPedigree.Text.Length == 0 || mtbChip.Text.Length == 0)
            {
                MessageBox.Show("Campos vacíos, verifique", "Sistema");
            }
            else
            {
                int i = 0;
                omBO.Nombre = txtNombreMascota.Text;
                omBO.Edad = txtEdadMascota.Text;
                omBO.Foto = ptbFotoMascota;
                omBO.Genero = Genero();
                omBO.Descripcion = (txtDescripcionColor.Text.Trim()) + (txtDescripcionPeso.Text.Trim() + " " + "kg") + (txtDescripcionTamaño.Text.Trim() + " " + "cm");
                omBO.Pedigre = mtbPedigree.Text;
                omBO.Chip = mtbChip.Text;
                omBO.ClienteID = Convert.ToInt32(cbxCliente.SelectedValue);

                i = omCTL.guardar_Mascota(omBO);
                if (i == 0)
                {
                    MessageBox.Show("Error registros no guardados");
                }
                else
                {
                    MessageBox.Show("Registros guardado con éxito");
                    MessageBox.Show("Desea registrar otra mascota","Registro",MessageBoxButtons.OKCancel);
                }
            }
        }

        public string Genero()
        {
            if (rdbMacho.Checked == true)
            {
                genero = "Macho";
            }
            else
            {
                if (rdbHembra.Checked == true)
                {
                    genero = "Hembra";
                }
            }
            return genero;
        }

        public void limpiarcampos()
        {
            ptbFotoMascota.Image = null;
            txtNombreMascota.Text = "";
            txtEdadMascota.Text = "";
            txtDescripcionTamaño.Text = "";
            txtDescripcionPeso.Text = "";
            txtDescripcionColor.Text = "";
            mtbChip.Text = "";
            mtbPedigree.Text = "";
        }

        private void Mascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cmascotasDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.cmascotasDataSet.clientes);

        }
    }
}
