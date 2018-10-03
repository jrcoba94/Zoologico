using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaMascotas.DAO;
using System.Data;

namespace ClinicaMascotas.Control
{
    public class ServicioCONTROL
    {
        ServicioDAO oservicioDAO;

        public int crearServicio(object obj)
        {
            oservicioDAO = new ServicioDAO();
            int i = oservicioDAO.RegistrarServicio(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }
        public int modificarServicio(object obj)
        {
            int i = oservicioDAO.ModificarServicio(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }
        public int cancelarServicio(object obj)
        {
            int i = oservicioDAO.cancelarServicio(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }


    }
}
