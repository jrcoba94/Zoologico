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
    public class ClienteDAO
    {
        Conexion conn;
        DataSet dscliente = null;
        string sql;
        SqlCommand cmd;
        SqlDataAdapter da;

        public ClienteDAO() { }

        public int RegistrarCliente(object obj)
        {
            ClienteBO data = (ClienteBO)obj;
            cmd = new SqlCommand();
            dscliente = new DataSet();
            da = new SqlDataAdapter();
            conn = new Conexion();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            
            sql = "Insert into clientes(nombre,fecha_nacimiento,edad,genero,telefono,direccion,codigo_postal,ciudad,correo_electronico,Estado)" + 
                "values (@Nombre,@Fecha_nacimiento,@Edad,@Genero,@Telefono,@Direccion,@Codigo_postal,@Ciudad,@Correo_electronico,@Estado)";
            cmd.CommandText = sql;

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Fecha_nacimiento", SqlDbType.VarChar);
            cmd.Parameters.Add("@Edad", SqlDbType.VarChar);
            cmd.Parameters.Add("@Genero", SqlDbType.VarChar);
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar);
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
            cmd.Parameters.Add("@Codigo_postal", SqlDbType.VarChar);
            cmd.Parameters.Add("@Ciudad", SqlDbType.VarChar);
            cmd.Parameters.Add("@Correo_electronico", SqlDbType.VarChar);
            cmd.Parameters.Add("@Estado", SqlDbType.VarChar);

            cmd.Parameters["@Nombre"].Value = data.Nombre;
            cmd.Parameters["@Fecha_nacimiento"].Value = data.FechaN;
            cmd.Parameters["@Edad"].Value = data.Edad;
            cmd.Parameters["@Genero"].Value = data.Genero;
            cmd.Parameters["@Telefono"].Value = data.Telefono;
            cmd.Parameters["@Direccion"].Value = data.Direccion;
            cmd.Parameters["@Codigo_postal"].Value = data.CodigoPostal;
            cmd.Parameters["@Ciudad"].Value = data.Ciudad;
            cmd.Parameters["@Correo_electronico"].Value = data.CorreoElectronico;
            cmd.Parameters["@Estado"].Value = data.Estado;

            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int ModificarCliente(object obj)
        {
            ClienteBO data = (ClienteBO)obj;
            //cmd = new MySqlCommand();
            cmd = new SqlCommand();
            dscliente = new DataSet();
            //da = new MySqlDataAdapter();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "UPDATE clientes SET clientesID = " + data.ClienteID + "', Nombre = '" + data.Nombre + "', fecha_nacimiento = '" + data.FechaN + "', edad = '" + data.Edad + "', genero = '" + data.Genero.Trim() +
                "' , telefono = '" + data.Telefono + "', direccion = '" + data.Direccion + "', codigo_postal = '" + data.CodigoPostal +
                "', ciudad = '" + data.Ciudad + "', correo_electronico = '" + data.CorreoElectronico.Trim() + "', Estado_idEstado = '" + data.Estado + "' WHERE clientesID = " + data.ClienteID;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaClientemasc()
        {
            //cmd = new MySqlCommand();
            cmd = new SqlCommand();
            dscliente = new DataSet();
            //da = new MySqlDataAdapter();
            da = new SqlDataAdapter();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            sql = "DELETE FROM mascotas,clientes WHERE mascotas.clientesID=clientes.clientesID";
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
