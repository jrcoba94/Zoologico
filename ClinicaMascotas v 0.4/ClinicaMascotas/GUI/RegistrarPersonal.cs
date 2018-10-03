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

namespace ClinicaMascotas.GUI
{
    public partial class RegistrarPersonal : Form
    {
        PersonalBO ope;
        PersonalCONTROL oPersonal;
        VeterinarioBO ove;
        VeterinarioCONTROL oVeterinario;

        public RegistrarPersonal()
        {
            InitializeComponent();
        }

        private void btnGuardarE_Click(object sender, EventArgs e)
        {
            addNuevoPersonal();
        }
        public void addNuevoPersonal()
        {
            string Puesto1 = "Veterinario";
            string puesto2 = "General";
            try
            {
                if (cmbPuesto.Text == Puesto1)
                {
                    int i = 0;
                    ove = new VeterinarioBO();
                    oVeterinario = new VeterinarioCONTROL();
                    
                    ove.Nombre = (txtNombre.Text);
                    ove.Direccion = txtDireccion.Text;
                    ove.Telefono = mtbTelefono.Text;
                    ove.Cedula = Convert.ToInt32(mtbCedula.Text);
                    i = oVeterinario.crearVeterinario(ove);

                    if (i == 0)
                    {
                        RegistrarPersonal opNuevoP;
                        opNuevoP = new RegistrarPersonal();
                        MessageBox.Show("Error al guardar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RegistrarPersonal opNuevoP;
                        opNuevoP = new RegistrarPersonal();
                        MessageBox.Show("Datos guardados exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                if (cmbPuesto.Text == puesto2)
                {
                    int i1 = 0;
                    ope = new PersonalBO();
                    oPersonal = new Control.PersonalCONTROL();
                    
                    ope.Nombre = txtNombre.Text;
                    ope.DireccionP = txtDireccion.Text;
                    ope.TelefonoP = mtbTelefono.Text;
                    ope.Cedula = mtbCedula.Text;
                    i1 = oPersonal.crearPersonal(ope);
                    if (i1 == 0)
                    {
                        RegistrarPersonal opNuevoPers2;
                        opNuevoPers2 = new RegistrarPersonal();
                        MessageBox.Show("Error al guardar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RegistrarPersonal opNuevoPers2;
                        opNuevoPers2 = new RegistrarPersonal();
                        MessageBox.Show("Datos guardados exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. La operacion no se pudo realizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea salir de la ventana", "Salir", MessageBoxButtons.OKCancel);
            Close();
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnActualizarT_Click(object sender, EventArgs e)
        {
            //PersonalCONTROL ACper = new PersonalCONTROL();
            //dgvLista1.DataSource=ACper.GetAllpersonal().Tables[0];
            //VeterinarioCONTROL ACvet = new VeterinarioCONTROL();
            //dgvLista.DataSource=ACvet.GetAllveterinario().Tables[0];
        }

        private void btnVerR_Click(object sender, EventArgs e)
        {
            //PersonalCONTROL personal = new PersonalCONTROL();
            //dgvLista1.DataSource = personal.GetAllpersonal().Tables[0];
            //VeterinarioCONTROL veterinario = new VeterinarioCONTROL();
            //dgvLista.DataSource = veterinario.GetAllveterinario().Tables[0];
        }

        public void Limpiar()
        {
            cmbPuesto.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            mtbCedula.Text = "";
            mtbTelefono.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
