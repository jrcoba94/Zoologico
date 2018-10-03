using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMascotas.BO
{
    class MascotaBO
    {
        int mascotaID;
        string nombreM;
        string edad;
        string genero;
        string descripcion;
        string pedigree;
        string chip;
        int clienteID;
        PictureBox foto;    

        public int ClaveMascota
        {
            get { return mascotaID; }
            set { mascotaID = value; }
        }
        public string Nombre
        {
            get { return nombreM; }
            set { nombreM = value; }
        }
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public PictureBox Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Pedigre
        {
            get { return pedigree; }
            set { pedigree = value; }
        }
        public string Chip
        {
            get { return chip; }
            set { chip = value; }
        }
        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }
    }
}
