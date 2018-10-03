using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMascotas.GUI;
using ClinicaMascotas.f2;
using ClinicaMascotas.SecondForms;
using ClinicaMascotas.DAO;
using ClinicaMascotas.Control;
using ClinicaMascotas.BO;
using ClinicaMascotas.Class;

namespace ClinicaMascotas
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            ServicioCONTROL s = new ServicioCONTROL();

        }
        double resultado = 0;

        int precio;

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroNuevo newmdichild = new RegistroNuevo();
            newmdichild.Show();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPersonal newmdichild = new RegistrarPersonal();
            newmdichild.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarRegistro newmdichild = new EliminarRegistro();
            newmdichild.Show();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicios newmdichild = new Servicios();
            newmdichild.Show();
        }

        private void celdasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Celdas newmdichld = new Celdas();
            newmdichld.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscS();
            ServicioCONTROL servicio = new ServicioCONTROL();
        }
        public void buscS()
        {
            try
            {
                int claveserv = Convert.ToInt32(txtClaveCeld.Text);
                BO.ServicioBO oser = new BO.ServicioBO();
                Control.ServicioCONTROL oservi = new Control.ServicioCONTROL();
                oser.ServicioID = claveserv;
                //dgvMascSer.DataSource = oservi.GetservicioE(oser).Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. Operacion fallida");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstbListaCobro.Items.Add("Servicio" + "   " + "precio" + "   " + "pago" + "   " + "total" + "   " + "cambio");
            lstbListaCobro.Items.Add(cmbServi.Text + "---" + precio + "---" + txtPago.Text + "---" + lblTotal.Text + "---" + lblCambio.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string cantidad = txtPago.Text;
                CalcularServicio cal = new CalcularServicio();
                if (cmbServi.Text == "cirugia")
                {
                    precio = 1500;
                }
                if (cmbServi.Text == "limpieza")
                {
                    precio = 500;
                }
                if (cmbServi.Text == "observacion")
                {
                    precio = 60;
                }
                if (cmbServi.Text == "radiografia")
                {
                    precio = 1800;
                }
                if (cmbServi.Text == "ultrasonido")
                {
                    precio = 1500;
                }
                if (cmbServi.Text == "vacunas")
                {
                    precio = 50;
                }
                resultado = resultado + cal.precio(Convert.ToDouble(cantidad), Convert.ToDouble(precio));
                lblTotal.Text = precio.ToString();
                lblCambio.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR al ejecutar operacion");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}