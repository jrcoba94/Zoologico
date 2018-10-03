using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaMascotas.DAO;
using System.Data;

namespace ClinicaMascotas.Control
{
    class PersonalCONTROL
    {
        PersonalDAO opersonalDAO;

        public int crearPersonal(object obj)
        {
            opersonalDAO = new PersonalDAO();
            int i = opersonalDAO.RegistrarPersonal(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificarPersonal(object obj)
        {
            int i = opersonalDAO.ModificarPersonal(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaPersonal(object obj)
        {
            int i = opersonalDAO.eliminaPersonal(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }

        
    }
}