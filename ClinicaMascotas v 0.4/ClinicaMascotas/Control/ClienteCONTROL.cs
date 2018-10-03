using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClinicaMascotas.DAO;
using ClinicaMascotas.BO;

namespace ClinicaMascotas.Control
{
    class ClienteCONTROL
    {
        ClienteDAO oclienteDAO;

        public int crearCliente(object obj)
        {
            oclienteDAO = new ClienteDAO();
            int i = oclienteDAO.RegistrarCliente(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificarCliente(object obj)
        {
            int i = oclienteDAO.ModificarCliente(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaClientemasc()
        {
            int i = oclienteDAO.eliminaClientemasc();
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
