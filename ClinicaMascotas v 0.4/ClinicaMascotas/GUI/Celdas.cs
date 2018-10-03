using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaMascotas.BO;
using ClinicaMascotas.Control;
using ClinicaMascotas.DAO;
using System.Data;
using System.Data.SqlClient;
using ClinicaMascotas.GUI;

namespace ClinicaMascotas.SecondForms
{
    public partial class Celdas : Form
    {
        public Celdas()
        {
            InitializeComponent();
        }

        public void verimagen(int Mid) // Reconvertimos la imagen
        {
            Conexion con = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.establecerConexion();
            con.abrirConexion();
            string sql = "select foto from mascotas where mascotasID ='" + Mid + "'";
            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            DataSet ds = new DataSet("foto");
            da.Fill(ds, "foto");

            //crear un arreglo baits
            byte[] dato = new byte[0];
            DataRow dr = ds.Tables["foto"].Rows[0];
            dato = (byte[])dr["foto"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
            pbxFotom.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        private void btn1A_Click(object sender, EventArgs e)
        {
            detCelda("A1");
        }

        private void btn2A_Click(object sender, EventArgs e)
        {
            detCelda("A2");
        }

        private void btn3A_Click(object sender, EventArgs e)
        {
            detCelda("A3");
        }

        private void btn4A_Click(object sender, EventArgs e)
        {
            detCelda("A4");
        }

        private void btn5A_Click(object sender, EventArgs e)
        {
            detCelda("A5");
        }

        private void btn1B_Click(object sender, EventArgs e)
        {
            detCelda("B1");
        }

        private void btn2B_Click(object sender, EventArgs e)
        {
            detCelda("B2");
        }

        private void btn3B_Click(object sender, EventArgs e)
        {
            detCelda("B3");
        }

        private void btn4B_Click(object sender, EventArgs e)
        {
            detCelda("B4");
        }

        private void btn5B_Click(object sender, EventArgs e)
        {
            detCelda("B5");
        }

        private void btn1C_Click(object sender, EventArgs e)
        {
            detCelda("C1");
        }

        private void btn2C_Click(object sender, EventArgs e)
        {
            detCelda("C2");
        }

        private void btn3C_Click(object sender, EventArgs e)
        {
            detCelda("C3");
        }

        private void btn4C_Click(object sender, EventArgs e)
        {
            detCelda("C4");
        }

        private void btn5C_Click(object sender, EventArgs e)
        {
            detCelda("C5");
        }

        public void detCelda(string celda)
        {
            CeldaCONTROL celdas;
            switch (celda)
            {
                case "A1":
                    try
                    {
                        celdas = new CeldaCONTROL();
                        DataTable dt = new DataTable();
                        dt = celdas.GetCelda();

                        txtClaveC.Text = dt.Rows[0]["celdaID"].ToString();
                        txtTurno.Text = dt.Rows[0]["turno"].ToString();
                        mtbFechain.Text = dt.Rows[0]["fecha_ingreso"].ToString();
                        mtbFechaal.Text = dt.Rows[0]["Fecha_alta"].ToString();
                        int ID = Convert.ToInt32(dt.Rows[0]["Mascotas_mascotaID"].ToString());
                        verimagen(ID);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("La operacion no se pudo realizar la celda se encuentra vacía", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGcelda_Click(object sender, EventArgs e)
        {
            GestionC gc = new GestionC();
            gc.Show();
        }
    }
}
