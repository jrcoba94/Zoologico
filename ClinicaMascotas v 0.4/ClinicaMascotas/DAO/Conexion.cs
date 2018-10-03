using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ClinicaMascotas.DAO
{
    class Conexion
    {
        SqlConnection con;

        public SqlConnection establecerConexion()
        {
            string cadena = "Data source = .; Initial catalog = cmascotas; Integrated Security = True";
            con = new SqlConnection(cadena);
            return con;
        }

        public void abrirConexion()
        {
            con.Open();
        }

        public void cerrarConexion()
        {
            con.Close();
        }
    }
}
