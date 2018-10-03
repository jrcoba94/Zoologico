using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaMascotas.DAO;
using System.Data;

namespace ClinicaMascotas.Control
{
    class MascotaCONTROL
    {
        MascotaDAO oMascotaDAO;

        public int guardar_Mascota(object obj)
        {
            oMascotaDAO = new MascotaDAO();
            int i = oMascotaDAO.guardarMascota(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;

        }

        public DataTable lista()
        {
            DataTable listado = new DataTable();
            listado = oMascotaDAO.MostrarDatos();
            return listado;

        }

        public DataSet devuelveMascota(object obj)
        {
            DataSet ds = new DataSet();
            ds = oMascotaDAO.devuelveMascota(obj);
            return ds;
        }
    }
}
