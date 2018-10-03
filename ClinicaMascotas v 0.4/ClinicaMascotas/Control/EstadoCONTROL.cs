using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaMascotas.DAO;
using System.Data;

namespace ClinicaMascotas.Control
{
    public class EstadoCONTROL
    {
        EstadoDAO oestadoDAO = new EstadoDAO();

        public DataSet GetAllEstado()
        {
            DataSet ds = new DataSet();
            ds = oestadoDAO.getDataEstado();
            return ds;
        }
        public DataSet GetEstado(object obj)
        {
            DataSet ds = new DataSet();
            ds = oestadoDAO.getDataEstado(obj);
            return ds;
        }
        public int crearEstado(object obj)
        {
            int i = oestadoDAO.RegistrarEstado(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }
        public int modificarEstado(object obj)
        {
            int i = oestadoDAO.ModificarEstado(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }
        public int eliminaEstado(object obj)
        {
            int i = oestadoDAO.eliminaEstado(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
