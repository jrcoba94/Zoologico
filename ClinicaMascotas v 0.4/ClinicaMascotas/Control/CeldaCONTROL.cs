using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaMascotas.DAO;
using System.Data;

namespace ClinicaMascotas.Control
{
    public class CeldaCONTROL
    {
        CeldaDAO oceldaDAO = new CeldaDAO();

        public int crearCelda(object obj)
        {
            int i = oceldaDAO.RegistrarCelda(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificarCelda(object obj)
        {
            int i = oceldaDAO.ModificarCelda(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaCelda(object obj)
        {
            int i = oceldaDAO.eliminaCelda(obj);
            if (i < 0)
            {
                return 0;
            }
            return 1;
        }

        public DataSet GetconsultCelda(object obj)
        {
            DataSet ds = new DataSet();
            ds = oceldaDAO.devuelveCelda(obj);
            return ds;
        }

        public DataTable GetCelda()
        {
            DataTable ds = new DataTable();
            ds = oceldaDAO.MostrarDatos();
            return ds;
        }

        //public DataSet Getconsult2A()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult2A();
        //    return ds;
        //}
        //public DataSet Getconsult3A()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult3A();
        //    return ds;
        //}
        //public DataSet Getconsult4A()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult4A();
        //    return ds;
        //}
        //public DataSet Getconsult5A()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult5A();
        //    return ds;
        //}
        //public DataSet Getconsult1B()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult1B();
        //    return ds;
        //}
        //public DataSet Getconsult2B()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult2B();
        //    return ds;
        //}
        //public DataSet Getconsult3B()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult3B();
        //    return ds;
        //}
        //public DataSet Getconsult4B()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult4B();
        //    return ds;
        //}
        //public DataSet Getconsult5B()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult5B();
        //    return ds;
        //}
        //public DataSet Getconsult1C()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult1C();
        //    return ds;
        //}
        //public DataSet Getconsult2C()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult2C();
        //    return ds;
        //}
        //public DataSet Getconsult3C()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult3C();
        //    return ds;
        //}
        //public DataSet Getconsult4C()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult4C();
        //    return ds;
        //}
        //public DataSet Getconsult5C()
        //{
        //    DataSet ds = new DataSet();
        //    ds = oceldaDAO.getDataconsult5C();
        //    return ds;
        //}
    }
}
