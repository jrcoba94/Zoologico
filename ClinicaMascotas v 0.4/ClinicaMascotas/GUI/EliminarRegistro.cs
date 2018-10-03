using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMascotas.DAO;
using ClinicaMascotas.BO;
using ClinicaMascotas.Control;

namespace ClinicaMascotas.f2
{
    public partial class EliminarRegistro : Form
    {
        public EliminarRegistro()
        {
            InitializeComponent();
            ClienteCONTROL client = new ClienteCONTROL();
            MascotaCONTROL mascot = new MascotaCONTROL();
            PersonalCONTROL person = new PersonalCONTROL();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            string nombre = txtNombre.Text + txtApellidoPatern.Text + txtApellidoMatern.Text;
            if (cmbOpciones.Text == "Personal")
            {
                
                if (clave == txtClave.Text)
                {
                    try
                    {
                        BO.PersonalBO oper = new BO.PersonalBO();
                        PersonalCONTROL opersonal = new PersonalCONTROL();
                        oper.PersonalID = Convert.ToInt32(txtClave.Text);

//                        dgvLista.DataSource = opersonal.Getclaveper(oper).Tables[0];
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR. Operacion fallida");
                    }
                }
                if (nombre == txtNombre.Text + txtApellidoPatern.Text + txtApellidoMatern.Text)
                {
                    try
                    {
                        BO.PersonalBO oper = new BO.PersonalBO();
                        PersonalCONTROL opersonal = new PersonalCONTROL();
                        oper.Nombre = txtNombre.Text + txtApellidoPatern.Text + txtApellidoMatern.Text;

//                        dgvLista.DataSource = opersonal.Getnameper(oper).Tables[0];
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR. Operacion fallida");
                    }
                }
                if (cmbOpciones.Text == "Cliente")
                {

                    if (clave == txtClave.Text)
                    {
                        
                        try
                        {

                            BO.ClienteBO ocli = new BO.ClienteBO();
                            ClienteCONTROL ocliente = new ClienteCONTROL();
                            ocli.ClienteID = Convert.ToInt32(txtClave.Text);

//                            dgvLista.DataSource = ocliente.cliclave(ocli).Tables[0];
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("ERROR. Operacion fallida");
                        }
                    }
                    if (nombre == txtNombre.Text + txtApellidoPatern.Text + txtApellidoMatern.Text)
                    {
                        try
                        {
                            BO.ClienteBO ocli = new BO.ClienteBO();
                            ClienteCONTROL ocliente = new ClienteCONTROL();
                            ocli.Nombre = txtNombre.Text + txtApellidoPatern.Text + txtApellidoMatern.Text;

//                            dgvLista.DataSource = ocliente.cliname(ocli).Tables[0];
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("ERROR. Operacion fallida");
                        }
                    }
                    if (cmbOpciones.Text == "Veterinario")
                    {
                        if (clave == txtClave.Text)
                        {
                            try
                            {
                                BO.VeterinarioBO ovet = new BO.VeterinarioBO();
                                VeterinarioCONTROL oveterinario = new VeterinarioCONTROL();
                                ovet.VeterinarioID = Convert.ToInt32(txtClave.Text);

//                                dgvLista.DataSource = oveterinario.clavevet(ovet).Tables[0];
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("ERROR. Operacion fallida");
                            }
                        }
                        if (nombre == txtNombre.Text + txtApellidoPatern.Text + txtApellidoMatern.Text)
                        {
                            try
                            {
                                BO.VeterinarioBO ovet = new BO.VeterinarioBO();
                                VeterinarioCONTROL oveterinario = new VeterinarioCONTROL();
                                ovet.Nombre = txtNombre.Text + txtApellidoPatern.Text + txtApellidoMatern.Text;

//                                dgvLista.DataSource = oveterinario.namevet(ovet).Tables[0];
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("ERROR. Operacion fallida");
                            }
                        }
                    }
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbOpciones.Text == "Cliente")
            {
                ClienteCONTROL cliente = new ClienteCONTROL();
//                dgvLista.DataSource = cliente.GetAllcliente().Tables[0];
            }
            dialogeliminar();
        }
        public void dialogeliminar()
        {
            DialogResult dr = MessageBox.Show("¿Desea Eliminar los siguientes datos?.", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    eliminarCfil();

                    break;
                case DialogResult.No:

                    break;
            }
        }
        public void eliminarCfil()
        {
            try
            {

                if (cmbOpciones.Text == "Personal")
                {
                    int i = 0;
                    BO.PersonalBO oPer = new BO.PersonalBO();
                    Control.PersonalCONTROL opers = new Control.PersonalCONTROL();
                    oPer.PersonalID = Convert.ToInt32(txtClave.Text.Trim());
                    i = opers.eliminaPersonal(oPer);
                    if (i == 0)
                    {
                        MessageBox.Show("La inoformación no se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La información se elimino con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. Operacion fallida");
            }
            try
            {
                if (cmbOpciones.Text == "Veterinario")
                {
                    int i = 0;
                    BO.VeterinarioBO oPer = new BO.VeterinarioBO();
                    Control.VeterinarioCONTROL opers = new Control.VeterinarioCONTROL();
                    oPer.VeterinarioID = Convert.ToInt32(txtClave.Text.Trim());
                    i = opers.eliminaVeterinario(oPer);
                    if (i == 0)
                    {
                        MessageBox.Show("La inoformación no se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La información se elimino con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. Operacion fallida");
            }
            try
            {
                if (cmbOpciones.Text == "Cliente")
                {
                    int i = 0;
                    BO.ClienteBO oPer = new BO.ClienteBO();
                    Control.ClienteCONTROL opers = new Control.ClienteCONTROL();
                    oPer.ClienteID = Convert.ToInt32(txtClave.Text.Trim());
//                    i = opers.eliminaCliente(oPer);
                    if (i == 0)
                    {
                        MessageBox.Show("La inoformación no se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La información se elimino con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. Operacion fallida");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //actualizarDatos();
            ClienteCONTROL cliente = new ClienteCONTROL();
            MascotaCONTROL mascota = new MascotaCONTROL();
            PersonalCONTROL personal = new PersonalCONTROL();
            VeterinarioCONTROL veterinario = new VeterinarioCONTROL();
        }
        //public void actualizarDatos()
        //{
        //    DialogResult dr = MessageBox.Show("¿Desea ACTUALIZAR los siguientes datos?.", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    switch (dr)
        //    {
        //        case DialogResult.Yes:
        //            actualDatos();

        //            break;
        //        case DialogResult.No:

        //            break;
        //    }
        //}
        //public void actualDatos()
        //{
        //    try
        //    {
        //        if (cmbOpciones.Text == "Personal")
        //        {
        //            int i = 0;
        //            BO.PersonalBO oact = new BO.PersonalBO();
        //            Control.PersonalCONTROL oactualizar = new Control.PersonalCONTROL();
        //            oact.PersonalID = Convert.ToInt32(txtClave.Text);
        //            i = oactualizar.modificarPersonal(oact);
        //            if (i == 0)
        //            {
        //                MessageBox.Show("Error al modificar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Los datos se actualizaron", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("ERROR. Operacion fallida");
        //    }
        //    try
        //    {
        //        if (cmbOpciones.Text == "Mascota")
        //        {
        //            int i = 0;
        //            BO.MascotaBO oact = new BO.MascotaBO();
        //            Control.MascotaCONTROL oactualizar = new Control.MascotaCONTROL();
        //            oact.ClaveMascota = Convert.ToInt32(txtClave.Text);
        //            i = oactualizar.modificarMascota(oact);
        //            if (i == 0)
        //            {
        //                MessageBox.Show("Error al modificar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Los datos se actualizaron", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("ERROR. Operacion fallida");
        //    }
        //    try
        //    {
        //        if (cmbOpciones.Text == "Cliente")
        //        {
        //            int i = 0;
        //            BO.ClienteBO oact = new BO.ClienteBO();
        //            Control.ClienteCONTROL oactualizar = new Control.ClienteCONTROL();
        //            oact.ClienteID = Convert.ToInt32(txtClave.Text);
        //            i = oactualizar.modificarCliente(oact);
        //            if (i == 0)
        //            {
        //                MessageBox.Show("Error al modificar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Los datos se actualizaron", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("ERROR. Operacion fallida");
        //    }
        //    try
        //    {
        //        if (cmbOpciones.Text == "Veterinario")
        //        {
        //            int i = 0;
        //            BO.VeterinarioBO oact = new BO.VeterinarioBO();
        //            Control.VeterinarioCONTROL oactualizar = new Control.VeterinarioCONTROL();
        //            oact.VeterinarioID = Convert.ToInt32(txtClave.Text);
        //            i = oactualizar.modificarVeterinario(oact);
        //            if (i == 0)
        //            {
        //                MessageBox.Show("Error al modificar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Los datos se actualizaron", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("ERROR. Operacion fallida");
        //    }
        //    try
        //    {
        //        if (cmbOpciones.Text == "Personal")
        //        {
        //            int i = 0;
        //            BO.PersonalBO oact = new BO.PersonalBO();
        //            Control.PersonalCONTROL oactualizar = new Control.PersonalCONTROL();
        //            oact.PersonalID = Convert.ToInt32(txtClave.Text);
        //            i = oactualizar.modificarPersonal(oact);
        //            if (i == 0)
        //            {
        //                MessageBox.Show("Error al modificar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Los datos se actualizaron", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("ERROR. Operacion fallida");
        //    }
        //}

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cmbOpciones.Text == "Cliente")
            {
                try
                {
                    ClienteCONTROL cliente = new ClienteCONTROL();
//                    dgvLista.DataSource = cliente.GetAllcliente().Tables[0];
                }
                catch
                {
                    MessageBox.Show("ERROR. Operacion fallida");
                }
            }
            if (cmbOpciones.Text == "Veterinario")
            {
                try
                {
                    VeterinarioCONTROL veterinario = new VeterinarioCONTROL();
//                    dgvLista.DataSource = veterinario.GetAllveterinario().Tables[0];
                }
                catch
                {
                    MessageBox.Show("ERROR. Operacion fallida");
                }
            }
            if (cmbOpciones.Text == "Mascota")
            {
                try
                {
                    MascotaCONTROL mascotas = new MascotaCONTROL();
                    dgvLista.DataSource = mascotas.lista();
                }
                catch
                {
                    MessageBox.Show("ERROR. Operacion fallida");
                }
            }
            if (cmbOpciones.Text == "Personal")
            {
                try
                {
                    PersonalCONTROL personal = new PersonalCONTROL();
//                    dgvLista.DataSource = personal.GetAllper().Tables[0];
                }
                catch
                {
                    MessageBox.Show("ERROR. Operacion fallida");
                }
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection fila = dgvLista.Rows[e.RowIndex].Cells;
                txtClave.Text = fila[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtApellidoPatern.Text = "";
            txtApellidoMatern.Text = "";
            cmbOpciones.Text = "";
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (cmbOpciones.Text == "Cliente")
            {
                ClienteCONTROL cliente = new ClienteCONTROL();
//                dgvLista.DataSource = cliente.GetAllcliente().Tables[0];
            }
            if (cmbOpciones.Text == "Veterinario")
            {
                VeterinarioCONTROL veterinario = new VeterinarioCONTROL();
  //              dgvLista.DataSource = veterinario.GetAllveterinario().Tables[0];
            }
            if (cmbOpciones.Text == "Mascota")
            {
                MascotaCONTROL mascotas = new MascotaCONTROL();
                dgvLista.DataSource = mascotas.lista();
            }
            if (cmbOpciones.Text == "Personal")
            {
                PersonalCONTROL personal = new PersonalCONTROL();
    //            dgvLista.DataSource = personal.GetAllper().Tables[0];
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea salir de la ventana", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            Close();
        }

        private void dgvLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = new DataTable();
            
        }
    }
}