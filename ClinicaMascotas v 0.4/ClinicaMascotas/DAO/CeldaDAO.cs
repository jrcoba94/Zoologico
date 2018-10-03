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
    class CeldaDAO
    {
        Conexion conn = new Conexion();
        DataSet dscelda = null;
        string sql;
        SqlCommand cmd;
        SqlDataAdapter da;

        public CeldaDAO()
        {
        }

        public int RegistrarCelda(object obj)
        {
            CeldaBO data = (CeldaBO)obj;
            cmd = new SqlCommand();
            dscelda = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "INSERT INTO celda VALUES (" + data.CeldaID + ", '" + data.Turno + "', '" + data.FechaIgreso.Trim() + "', '" + data.FechaAlta.Trim() + "','" + data.MascotaID + "')";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int ModificarCelda(object obj)
        {
            CeldaBO data = (CeldaBO)obj;
            cmd = new SqlCommand();
            dscelda = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "UPDATE celda SET nombreC = " + data.NombreC + "', turno = '" + 
                data.Turno + "', fecha_ingreso = '" + data.FechaIgreso + 
                "', fecha_alta = '" + data.FechaAlta + "' WHERE clientes = " + data.CeldaID;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            conn.cerrarConexion();
            cmd.Parameters.Clear();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaCelda(object obj)
        {
            CeldaBO data = (CeldaBO)obj;
            cmd = new SqlCommand();
            dscelda = new DataSet();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "DELETE FROM celda WHERE celdaID = '" + data.CeldaID + "'";
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            conn.cerrarConexion();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public DataSet devuelveCelda(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            CeldaBO data = (CeldaBO)obj;
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();

            if (data.CeldaID > 0)
            {
                cadenaWhere = cadenaWhere + "CeldaID=@CeldaID and";
                cmd.Parameters.Add("@CeldaID", SqlDbType.Int);
                cmd.Parameters["@CeldaID"].Value = data.CeldaID;
                edo = true;
            }
            if (data.NombreC != null)
            {

                cadenaWhere = cadenaWhere + "NombreC=@NombreC and";
                cmd.Parameters.Add("@NombreC", SqlDbType.VarChar);
                cmd.Parameters["@NombreC"].Value = data.NombreC;
                edo = true;
            }
            if (data.Turno > 0)
            {
                cadenaWhere = cadenaWhere + "Turno=@Turno and";
                cmd.Parameters.Add("@Turno", SqlDbType.Decimal);
                cmd.Parameters["@Turno"].Value = data.Turno;
                edo = true;
            }
            if (data.FechaIgreso != null)
            {
                cadenaWhere = cadenaWhere + "FechaIgreso=@FechaIgreso and";
                cmd.Parameters.Add("@FechaIgreso", SqlDbType.VarChar);
                cmd.Parameters["@FechaIgreso"].Value = data.FechaIgreso;
                edo = true;
            }
            if (data.FechaAlta != null)
            {
                cadenaWhere = "FechaAlta=@FechaAlta and";
                cmd.Parameters.Add("@FechaAlta", SqlDbType.VarChar);
                cmd.Parameters["@FechaAlta"].Value = data.FechaAlta;
                edo = true;
            }

            if (data.MascotaID > 0)
            {
                cadenaWhere = cadenaWhere + "Mascotas_mascotasID=@Mascotas_mascotasID and";
                cmd.Parameters.Add("@Mascotas_mascotasID", SqlDbType.Int);
                cmd.Parameters["@Mascotas_mascotasID"].Value = data.MascotaID;
                edo = true;
            }

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select * from celda" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dscelda);
            conn.cerrarConexion();
            return dscelda;

        }

        public DataTable MostrarDatos() //para mostrar en el DataGrid
        {
            string sql = "Select * from celda";
            SqlDataAdapter lista = new SqlDataAdapter(sql, conn.establecerConexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            conn.cerrarConexion();
            return datos;
        }
        
        //public DataSet getDataconsult1A()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1401";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult2A()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1402";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult3A()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1403";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult4A()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1404";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult5A()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1405";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult1B()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1406";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult2B()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1407";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult3B()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1408";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult4B()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1409";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult5B()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1410";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult1C()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1411";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult2C()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1412";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult3C()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1413";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult4C()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1414";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
        //public DataSet getDataconsult5C()
        //{
        //    cmd = new SqlCommand();
        //    dscelda = new DataSet();
        //    da = new SqlDataAdapter();
        //    cmd.Connection = conn.establecerConexion();
        //    conn.abrirConexion();
        //    sql = "SELECT * FROM celda WHERE celdaID = 1415";//crear un id en form
        //    cmd.CommandText = sql;
        //    DataSet ds = new DataSet();
        //    da.SelectCommand = cmd;
        //    da.Fill(dscelda);
        //    return dscelda;
        //}
    }
}