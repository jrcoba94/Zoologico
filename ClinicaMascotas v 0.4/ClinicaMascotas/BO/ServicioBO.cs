using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMascotas.BO
{
    public class ServicioBO
    {
        int servicioID;
        string status;
        string descripcion;
        int celdaID;
        int veterinarioID;

        public int ServicioID
        {
            get { return servicioID; }
            set { servicioID = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int CeldaID
        {
            get { return celdaID; }
            set { celdaID = value; }
        }
        public int VeterinarioID
        {
            get { return veterinarioID; }
            set { veterinarioID = value; }
        }
    }
}
