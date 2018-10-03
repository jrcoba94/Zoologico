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
    class EstadoDAO
    {
        Conexion conn = new Conexion();
        DataSet dsEstado = null;
        string sql;
        SqlCommand cmd;
        SqlDataAdapter da;

        public EstadoDAO()
        {
        }

        public DataSet getDataEstado(object obj)
        {
            EstadoBO data = (EstadoBO)obj;
            cmd = new SqlCommand();
            dsEstado = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "SELECT * FROM estado WHERE estadoID = " + Convert.ToString(data.EstadoID).Trim();//crear un id en form
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(dsEstado);
            return dsEstado;
        }
        public DataSet getDataEstado()
        {
            cmd = new SqlCommand();
            dsEstado = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "SELECT * FROM estado ORDER BY estadoID";
            cmd.CommandText = sql;
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(dsEstado);
            return dsEstado;
        }

        public int RegistrarEstado(object obj)
        {
            EstadoBO data = (EstadoBO)obj;
            cmd = new SqlCommand();
            dsEstado = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "INSERT INTO estado VALUES (" + data.EstadoID + ", '" + data.Nombre.Trim() + "')";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int ModificarEstado(object obj)
        {
            EstadoBO data = (EstadoBO)obj;
            cmd = new SqlCommand();
            dsEstado = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "UPDATE estado SET estadoID = " + data.EstadoID + "', NombreE = '" + data.Nombre + "' WHERE estado = " + data.EstadoID;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaEstado(object obj)
        {
            EstadoBO data = (EstadoBO)obj;
            cmd = new SqlCommand();
            dsEstado = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "DELETE FROM estado WHERE estadoID = " + Convert.ToString(data.EstadoID).Trim();
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int devuelveEstado()
        {
            BO.EstadoBO data = new BO.EstadoBO();
            int result;
            cmd = new SqlCommand();
            dsEstado = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "SELECT estado.estadoID FROM cmascotas";
            cmd.CommandText = sql;
            result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            return result;
        }
    }
}