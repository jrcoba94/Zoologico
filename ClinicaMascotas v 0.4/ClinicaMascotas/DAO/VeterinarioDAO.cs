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
    public class VeterinarioDAO
    {
        Conexion conn;
        DataSet dsveterinario = null;
        string sql;
        SqlCommand cmd;
        SqlDataAdapter da;

        public VeterinarioDAO()
        {
        }

        public int RegistrarVeterinario(object obj)
        {
            VeterinarioBO data = (VeterinarioBO)obj;
            cmd = new SqlCommand();
            dsveterinario = new DataSet();
            da = new SqlDataAdapter();
            conn = new Conexion();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "INSERT INTO veterinario(nombre,direccion,telefono,cedula)"+
                "VALUES (@nombre,@direccion,@telefono,@cedula)";
            cmd.CommandText = sql;

            cmd.Parameters.Add("@nombre", SqlDbType.VarChar); 
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar); 
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar);
            cmd.Parameters.Add("@cedula", SqlDbType.VarChar);

            cmd.Parameters["@nombre"].Value = data.Nombre; 
            cmd.Parameters["@direccion"].Value = data.Direccion; 
            cmd.Parameters["@telefono"].Value = data.Telefono;
            cmd.Parameters["@cedula"].Value = data.Cedula;
            
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int ModificarVeterinario(object obj)
        {
            VeterinarioBO data = (VeterinarioBO)obj;
            cmd = new SqlCommand();
            dsveterinario = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "UPDATE veterinario SET veterinarioID = " + data.VeterinarioID + "', nombre = '" + data.Nombre + "', direccion = '" + data.Direccion.Trim() +
                "', telefono = '" + data.Telefono + "', cedula = '" + data.Cedula + "' WHERE veterinarioID = " + data.VeterinarioID;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaVeterinario(object obj)
        {
            VeterinarioBO data = (VeterinarioBO)obj;
            cmd = new SqlCommand();
            dsveterinario = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "DELETE FROM veterinario WHERE veterinarioID = " + Convert.ToString(data.VeterinarioID).Trim();
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