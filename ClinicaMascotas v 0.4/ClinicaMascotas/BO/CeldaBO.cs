using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMascotas.BO
{
    public class CeldaBO
    {
        int celdaID;
        int turno;
        string fechaIngreso;
        string fechaAlta;
        int mascotaID;
        string nombreC;

        public string NombreC
        {
            get { return nombreC; }
            set { nombreC = value; }
        }

        public int CeldaID
        {
            get { return celdaID; }
            set { celdaID = value; }
        }
        public int Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public string FechaIgreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        public string FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        public int MascotaID
        {
            get { return mascotaID; }
            set { mascotaID = value; }
        }
    }
}