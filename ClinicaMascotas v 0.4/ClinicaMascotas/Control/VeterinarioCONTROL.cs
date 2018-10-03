using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClinicaMascotas.DAO;

namespace ClinicaMascotas.Control
{
    class VeterinarioCONTROL
    {
        VeterinarioDAO oVeterinarioDAO;

        public int crearVeterinario(object obj)
        {
            oVeterinarioDAO = new VeterinarioDAO();
            int i = oVeterinarioDAO.RegistrarVeterinario(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int modificarVeterinario(object obj)
        {
            int i = oVeterinarioDAO.ModificarVeterinario(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }
        public int eliminaVeterinario(object obj)
        {
            int i = oVeterinarioDAO.eliminaVeterinario(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }


    }
}
