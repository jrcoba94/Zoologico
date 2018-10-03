using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClinicaMascotas.BO;

namespace ClinicaMascotas.DAO
{
    class ServicioDAO
    {
        Conexion conn;
        DataSet dsServicio = null;
        string sql;
        SqlCommand cmd;
        SqlDataAdapter da;
        
        public ServicioDAO()
        {
        }

        public int RegistrarServicio(object obj)
        {
            ServicioBO data = (ServicioBO)obj;
            cmd = new SqlCommand();
            dsServicio = new DataSet();
            da = new SqlDataAdapter();
            conn = new Conexion();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "INSERT INTO servicio (status,descripcion,Celda_celdaID,Veterinario_veterinarioID)"+
                "VALUES (@status,@descripcion,@Celda_celdaID,@Veterinario_veterinarioID)";
            cmd.CommandText = sql;

            cmd.Parameters.Add("@status", SqlDbType.VarChar);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@Celda_celdaID", SqlDbType.Int);
            cmd.Parameters.Add("@Veterinario_veterinarioID", SqlDbType.Int);

            cmd.Parameters["@status"].Value = data.Status;
            cmd.Parameters["@descripcion"].Value = data.Descripcion;
            cmd.Parameters["@Celda_celdaID"].Value = data.CeldaID;
            cmd.Parameters["@Veterinario_veterinarioID"].Value = data.VeterinarioID;

            int i = cmd.ExecuteNonQuery();

            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int ModificarServicio(object obj)
        {
            ServicioBO data = (ServicioBO)obj;
            cmd = new SqlCommand();
            dsServicio = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "UPDATE servicio SET servicioID = " + data.ServicioID + "', status = '" + data.Status + "', descripcion = '" + data.Descripcion + "', Celda_celdaID = '" + data.CeldaID + "', Veterinario_veterinarioID = '" + data.VeterinarioID + "' WHERE servicio = " + data.ServicioID;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int cancelarServicio(object obj)
        {
            ServicioBO data = (ServicioBO)obj;
            cmd = new SqlCommand();
            dsServicio = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "UPDATE servicio SET status='cancelado' WHERE servicioID = " + Convert.ToString(data.ServicioID);
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