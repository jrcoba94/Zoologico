using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMascotas.Control;
using ClinicaMascotas.BO;

namespace ClinicaMascotas.GUI
{
    public partial class GestionC : Form
    {
        CeldaCONTROL oceldactrl;
        CeldaBO ocelda;

        public GestionC()
        {
            InitializeComponent();
            Listar();
        }

        private void gvCelda_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cmascotasDataSet1.mascotas' Puede moverla o quitarla según sea necesario.
            this.mascotasTableAdapter.Fill(this.cmascotasDataSet1.mascotas);

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnVcelda_Click(object sender, EventArgs e)
        {

        }

        public void Listar()
        {
            oceldactrl = new CeldaCONTROL();
            gvCelda.DataSource = oceldactrl.GetCelda();
        }
    }
}
