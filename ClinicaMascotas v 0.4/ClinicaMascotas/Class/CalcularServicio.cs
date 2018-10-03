using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMascotas.Class
{
    public class CalcularServicio
    {
        double precioT;
        
        public CalcularServicio()
        {
        }
        public double precio(double a, double b)
        {
            precioT = a - b;
           
            return precioT;
        }

        public double descuento(double total)
        {
            {
                if (precioT == 4000)
                {
                    precioT = precioT / .5;
                }
                if (precioT == 8000)
                {
                    precioT = precioT / .9;
                }
            }

            return precioT;
        }
    } 
}
