using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaMascotas.BO;
using System.Data;
using System.Data.SqlClient;

namespace ClinicaMascotas.DAO
{
    class PersonalDAO
    {
        Conexion conn;
        DataSet dsPersonal = null;
        string sql;
        SqlCommand cmd;
        SqlDataAdapter da;

        public PersonalDAO()
        {
        }

        public int RegistrarPersonal(object obj)
        {
            PersonalBO data = (PersonalBO)obj;
            cmd = new SqlCommand();
            dsPersonal = new DataSet();
            da = new SqlDataAdapter();
            conn = new Conexion();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "INSERT INTO personal(nombre,direccion,telefono,cedula)"+
                "VALUES (@nombre,@direccion,@telefono,@cedula)";
            cmd.CommandText = sql;

            cmd.Parameters.Add("@nombre", SqlDbType.VarChar); 
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar); 
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar);
            cmd.Parameters.Add("@cedula", SqlDbType.VarChar);

            cmd.Parameters["@nombre"].Value = data.Nombre; 
            cmd.Parameters["@direccion"].Value = data.DireccionP; 
            cmd.Parameters["@telefono"].Value = data.TelefonoP;
            cmd.Parameters["@cedula"].Value = data.Cedula;

            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int ModificarPersonal(object obj)
        {
            PersonalBO data = (PersonalBO)obj;
            cmd = new SqlCommand();
            dsPersonal = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "UPDATE personal SET personalID = " + data.PersonalID + "', nombre = '" + data.Nombre + 
                "', direccion = '" + data.DireccionP + "', telefono = '" + data.TelefonoP + "', cedula = '" + data.Cedula + "' WHERE personalID = " + data.PersonalID;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaPersonal(object obj)
        {
            PersonalBO data = (PersonalBO)obj;
            cmd = new SqlCommand();
            dsPersonal = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "DELETE FROM personal WHERE personalID = " + Convert.ToString(data.PersonalID).Trim();
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }


    }
}
