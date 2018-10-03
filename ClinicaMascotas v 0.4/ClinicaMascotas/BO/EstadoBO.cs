using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMascotas.BO
{
    public class EstadoBO
    {
        private int estadoID;
        private string nombre;

        public int EstadoID
        {
            get { return estadoID; }
            set { estadoID = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
