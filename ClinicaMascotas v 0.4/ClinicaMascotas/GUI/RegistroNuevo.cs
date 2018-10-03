using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMascotas.BO;
using ClinicaMascotas.Control;
using ClinicaMascotas.DAO;
using System.IO;
using ClinicaMascotas.GUI;

namespace ClinicaMascotas.f2
{
    public partial class RegistroNuevo : Form
    {
        ClienteBO oClienteBO = new ClienteBO();
        ClienteCONTROL oCliente = new ClienteCONTROL();
        string genero;

        public RegistroNuevo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            addNuevoRegistro();
        }

        public void addNuevoRegistro()
        {
            try
            {
                int i = 0;
                string nombre = txtNombre.Text +" "+ txtApellidoPaterno.Text +" "+ txtApellidoMaterno.Text;
                string direccion = txtDireccion.Text +" Col. "+ txtColonia.Text;
                oClienteBO.Nombre = nombre;
                oClienteBO.FechaN = mtbFechaNC.Text;
                oClienteBO.Edad = txtEdad.Text;
                oClienteBO.Genero = GeneroCli();
                oClienteBO.Telefono = mtbTelefono.Text;
                oClienteBO.CorreoElectronico = txtCorreoElectronico.Text;
                oClienteBO.Direccion = direccion;
                oClienteBO.CodigoPostal = mtbCodigoPostal.Text;
                oClienteBO.Estado = cmbEstado.Text;
                oClienteBO.Ciudad = txtCiudad.Text;
                i = oCliente.crearCliente(oClienteBO);
                limpiarcampos();
                if (i == 0)
                {
                    RegistroNuevo opRegistroNuevo;
                    opRegistroNuevo = new RegistroNuevo();
                    opRegistroNuevo.Show();
                    MessageBox.Show("Error al guardar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    opRegistroNuevo.Close();
                }
                else
                {
                    RegistroNuevo opRegistroNuevo2;
                    opRegistroNuevo2 = new RegistroNuevo();
                    opRegistroNuevo2.Show();
                    MessageBox.Show("Datos guardados exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. La operacion no se pudo realizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea salir de la vetana", "Salir", MessageBoxButtons.YesNoCancel);
            Close();
        }

        private void btnRmascota_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota();
            RegistroNuevo rn = new RegistroNuevo();
            m.Show();
            rn.Close();
        }

        public void limpiarcampos()
        {
            txtNombre.Text = "";
            txtApellidoMaterno.Text = "";
            txtApellidoPaterno.Text = "";
            txtCiudad.Text = "";
            txtColonia.Text = "";
            txtCorreoElectronico.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            mtbCodigoPostal.Text = "";
            mtbFechaNC.Text = "";
            mtbTelefono.Text = "";
            rdbMasculino.Checked = false;
            rdbFemenino.Checked = false;
        }

        public string GeneroCli()
        {
            if (rdbMasculino.Checked == true)
            {
                genero = "Masculino";
            }
            else
            {
                if (rdbFemenino.Checked == true)
                {
                    genero = "Femenino";
                }
            }
            return genero;
        }
    }
}