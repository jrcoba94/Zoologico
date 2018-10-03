using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMascotas.BO
{
    public class PersonalBO
    {
        int personalID;
        string nombre;
        string direccion;
        string telefono;
        string cedula;

        public int PersonalID
        {
            get { return personalID; }
            set { personalID = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string DireccionP
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string TelefonoP
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
    }
}
