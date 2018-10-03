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
    public partial class Servicios : Form
    {
        int Clave;

        public Servicios()
        {
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea salir de la ventana", "Salir", MessageBoxButtons.OKCancel);
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (cmbConsulS.Text == "Servicios")
                //{

                //    Control.ServicioCONTROL oserv = new Control.ServicioCONTROL();
                //    oserv.GetAllservicio();
                //    dgvServicio.DataSource = oserv.GetAllservicio().Tables[0];

                //}
                //if (cmbConsulS.Text == "Pendientes")
                //{
                //    Control.ServicioCONTROL oserv = new Control.ServicioCONTROL();
                //    oserv.GetServiciopendiente();
                //    dgvServicio.DataSource = oserv.GetServiciopendiente().Tables[0];
                //}
                //if (cmbConsulS.Text == "Terminados")
                //{
                //    Control.ServicioCONTROL oserv = new Control.ServicioCONTROL();
                //    oserv.GetServicioterminado();
                //    dgvServicio.DataSource = oserv.GetServicioterminado().Tables[0];
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. La operacion no se pudo realizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarS_Click(object sender, EventArgs e)
        {
            cancelarservi();
        }
        public void cancelarservi()
        {
            try
            {
                if (cmbConsulS.Text == "Servicios")
                {
                    int i = 0;
                    ServicioBO oact = new ServicioBO();
                    ServicioCONTROL oactualizar = new ServicioCONTROL();
                    oact.ServicioID = Convert.ToInt32(cbxMascotaIDs.SelectedValue);
                    i = oactualizar.cancelarServicio(oact);
                    if (i == 0)
                    {
                        MessageBox.Show("ERROR. El servicio no se pudo cancelar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El servicio se ha cancelado", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. La operacion no se pudo realizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nuevoservicio();
        }
        public void nuevoservicio()
        {
            chbCirugía.Text = "cirugia";
            chbLimpieza.Text = "limpieza";
            chbObservacion.Text = "observacion";
            chbRadiografia.Text = "radiografia";
            chbUltrasonido.Text = "ultrasonido";
            chbVacunas.Text = "vacunas";
            
            try
            {
                int i = 0;
                BO.ServicioBO oser = new BO.ServicioBO();
                ServicioCONTROL oservicio = new ServicioCONTROL();
                oser.VeterinarioID = Convert.ToInt32(cbxVeterinario.SelectedValue);
                oser.Status = cmbStatus.Text.Trim();
                oser.Descripcion = chbCirugía.Text;
                oser.Descripcion = chbLimpieza.Text;
                oser.Descripcion = chbObservacion.Text;
                oser.Descripcion = chbRadiografia.Text;
                oser.Descripcion = chbUltrasonido.Text;
                oser.Descripcion = chbVacunas.Text;
                if (cmbCeldaAsignada.Text == "1A")
                {
                    oser.CeldaID = 1401;
                }
                if (cmbCeldaAsignada.Text == "2A")
                {
                    oser.CeldaID = 1402;
                }
                if (cmbCeldaAsignada.Text == "3A")
                {
                    oser.CeldaID = 1403;
                }
                if (cmbCeldaAsignada.Text == "4A")
                {
                    oser.CeldaID = 1404;
                }
                if (cmbCeldaAsignada.Text == "5A")
                {
                    oser.CeldaID = 1405;
                }
                if (cmbCeldaAsignada.Text == "1B")
                {
                    oser.CeldaID = 1406;
                }
                if (cmbCeldaAsignada.Text == "2B")
                {
                    oser.CeldaID = 1407;
                }
                if (cmbCeldaAsignada.Text == "3B")
                {
                    oser.CeldaID = 1408;
                }
                if (cmbCeldaAsignada.Text == "4B")
                {
                    oser.CeldaID = 1409;
                }
                if (cmbCeldaAsignada.Text == "5B")
                {
                    oser.CeldaID = 1410;
                }
                if (cmbCeldaAsignada.Text == "1C")
                {
                    oser.CeldaID = 1411;
                }
                if (cmbCeldaAsignada.Text == "2C")
                {
                    oser.CeldaID = 1412;
                }
                if (cmbCeldaAsignada.Text == "3C")
                {
                    oser.CeldaID = 1413;
                }
                if (cmbCeldaAsignada.Text == "4C")
                {
                    oser.CeldaID = 1414;
                }
                if (cmbCeldaAsignada.Text == "5C")
                {
                    oser.CeldaID = 1415;
                }
                i = oservicio.crearServicio(oser);

                if (i == 0)
                {
                    Servicios opNuevoP;
                    opNuevoP = new Servicios();
                    opNuevoP.Show();
                    MessageBox.Show("Error al guardar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    opNuevoP.Close();
                }
                else
                {
                    RegistrarPersonal opNuevoP;
                    opNuevoP = new RegistrarPersonal();
                    opNuevoP.Show();
                    MessageBox.Show("Datos guardados exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. La operacion no se pudo realizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCellCollection fila = dgvServicio.Rows[e.RowIndex].Cells;
                Clave = int.Parse(fila[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cmascotasDataSet3.celda' Puede moverla o quitarla según sea necesario.
            this.celdaTableAdapter.Fill(this.cmascotasDataSet3.celda);
            // TODO: esta línea de código carga datos en la tabla 'cmascotasDataSet2.veterinario' Puede moverla o quitarla según sea necesario.
            this.veterinarioTableAdapter.Fill(this.cmascotasDataSet2.veterinario);
            // TODO: esta línea de código carga datos en la tabla 'cmascotasDataSet1.mascotas' Puede moverla o quitarla según sea necesario.
            this.mascotasTableAdapter.Fill(this.cmascotasDataSet1.mascotas);

        }
    }
}