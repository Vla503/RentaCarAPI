using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar
using RentaCars.EN;
using RentaCars.DAL;

namespace RentaCars.BL
{
    public class RentaBL
    {
        private RentaDAL DAL = new RentaDAL();
        public int agregarrenta (Renta renta)
        {
            return DAL.agregarrenta(renta);
        }
        public List<Renta> ListRenta (string state)
        {
            return DAL.ListRenta(state);
            
        }

        public int ModificarRenta (Renta renta)
        {
            return DAL.ModificarRenta(renta);
        } 
        public int DeleteRenta (int id)
        {
            return DAL.DeleteRenta(id);
        }
        public Renta findRenta(int id)
        {
            return DAL.findrenta(id);
        }
    }
}
