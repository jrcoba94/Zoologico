using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMascotas.BO
{
    public class ClienteBO
    {
        int clienteID;
        string nombre;
        string fechaNacimiento;
        string edad;
        string genero;
        string telefono;
        string direccion;
        string codigoPostal;
        string ciudad;
        string correoElectronico;
        string estado;

        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string FechaN
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
