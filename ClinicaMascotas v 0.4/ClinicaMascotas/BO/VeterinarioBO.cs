using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMascotas.BO
{
    public class VeterinarioBO
    {
        int veterinarioID;
        string nombre;
        string direccion;
        string telefono;
        int cedula;

        public int VeterinarioID
        {
            get { return veterinarioID; }
            set { veterinarioID = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
    }
}
