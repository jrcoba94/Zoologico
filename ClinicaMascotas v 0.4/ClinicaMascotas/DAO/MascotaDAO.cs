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
    class MascotaDAO
    {
        Conexion conn;
        DataSet dsMascota = null;
        string sql;
        SqlCommand cmd;
        SqlDataAdapter da;

        public MascotaDAO()
        {
        }

        public DataSet devuelveMascota(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            MascotaBO data = (MascotaBO)obj;
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();
            
            if (data.ClaveMascota > 0)
            {
                cadenaWhere = cadenaWhere + " mascotasID=@mascotasID and";
                cmd.Parameters.Add("@mascotasID", SqlDbType.Int);
                cmd.Parameters["@mascotasID"].Value = data.ClaveMascota;
                edo = true;
            }
            if (data.Nombre != null)
            {

                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = data.Nombre;
                edo = true;
            }
            if (data.Edad != null)
            {
                cadenaWhere = cadenaWhere + " Edad=@Edad and";
                cmd.Parameters.Add("@Edad", SqlDbType.VarChar);
                cmd.Parameters["@Edad"].Value = data.Nombre;
                edo = true;
            }
            if (data.Foto != null)
            {
                cadenaWhere = cadenaWhere + " Foto=@Foto and";
                cmd.Parameters.Add("@Foto", SqlDbType.Image);
                cmd.Parameters["@Foto"].Value = data.Foto;
                edo = true;
            }
            if (data.Genero != null)
            {
                cadenaWhere = "Genero=@Genero and";
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar);
                cmd.Parameters["@Genero"].Value = data.Genero;
                edo = true;
            }
            if (data.Descripcion != null)
            {
                cadenaWhere = " Descripcion=@Descripcion and";
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters["@Descripcion"].Value = data.Descripcion;
                edo = true;
            }

            if (data.Pedigre != null)
            {
                cadenaWhere = cadenaWhere + " Pedigre=@Pedigre and";
                cmd.Parameters.Add("@Pedigre", SqlDbType.VarChar);
                cmd.Parameters["@Pedigre"].Value = data.Pedigre;
                edo = true;
            }
            if (data.Chip != null)
            {
                cadenaWhere = cadenaWhere + " Chip=@Chip and";
                cmd.Parameters.Add("@Chip", SqlDbType.VarChar);
                cmd.Parameters["@Chip"].Value = data.Chip;
                edo = true;
            }
            if (data.ClienteID > 0)
            {
                cadenaWhere = cadenaWhere + "Clientes_clientesID=@Clientes_clientesID and";
                cmd.Parameters.Add("@Clientes_clientesID", SqlDbType.Int);
                cmd.Parameters["@Clientes_clientesID"].Value = data.ClienteID;
                edo = true;
            }

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }

            sql = "select a.Ciudad, a.Nombre, a.ApellidoPaterno, a.ApellidoMaterno, a.Edad, a.Escolaridad, a.Posicion, a.IDequipo, b.Tipo from Jugadores a inner join Categoria b on a.IDcategoria = b.IDcategoria" + cadenaWhere;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsMascota);
            conn.cerrarConexion();
            return dsMascota;

        }

        public int guardarMascota(object obj)
        {
            MascotaBO data = (MascotaBO)obj;
            cmd = new SqlCommand();
            dsMascota = new DataSet();
            da = new SqlDataAdapter();
            conn = new Conexion();
            cmd.Connection = conn.establecerConexion();
            conn.abrirConexion();

            sql = "Insert into Mascotas(nombreM,edad,Foto,genero,descripcion,pedigree,chip,Clientes_clientesID)"+
                "values(@nombreM,@edad,@Foto,@genero,@descripcion,@pedigree,@chip,@Clientes_clientesID)";
            cmd.CommandText = sql;

            cmd.Parameters.Add("@nombreM", SqlDbType.VarChar);
            cmd.Parameters.Add("@edad", SqlDbType.VarChar);
            cmd.Parameters.Add("@Foto", SqlDbType.Image);
            cmd.Parameters.Add("@genero", SqlDbType.VarChar);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@pedigree", SqlDbType.VarChar);
            cmd.Parameters.Add("@chip", SqlDbType.VarChar);
            cmd.Parameters.Add("@Clientes_clientesID", SqlDbType.Int);

            cmd.Parameters["@nombreM"].Value = data.Nombre;
            cmd.Parameters["@edad"].Value = data.Edad;
            cmd.Parameters["@Foto"].Value = data.Foto;
            cmd.Parameters["@genero"].Value = data.Genero;
            cmd.Parameters["@descripcion"].Value = data.Descripcion;
            cmd.Parameters["@pedigree"].Value = data.Pedigre;
            cmd.Parameters["@chip"].Value = data.Chip;
            cmd.Parameters["@Clientes_clientesID"].Value = data.ClienteID;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            data.Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@Foto"].Value = ms.GetBuffer();
            
            int i = cmd.ExecuteNonQuery();
            conn.cerrarConexion();
            cmd.Parameters.Clear();
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public DataTable MostrarDatos() //para mostrar en el DataGrid
        {
            string sql = "Select * from v_Mascota";
            SqlDataAdapter lista = new SqlDataAdapter(sql, conn.establecerConexion());
            DataTable datos = new DataTable();
            lista.Fill(datos);
            conn.cerrarConexion();
            return datos;
        }

    }
}
