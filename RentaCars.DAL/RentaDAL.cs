using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using RentaCars.EN;
using System.Data.Entity;

namespace RentaCars.DAL
{
    public class RentaDAL
    {
        private ProjectContext db = new ProjectContext();
       public int agregarrenta(Renta renta)
        {
            int r = 0;
            if(renta!= null)
            {
                db.Renta.Add(renta);
                r = db.SaveChanges(); 
            }
            return r;
        }

        public List<Renta> ListRenta (string state)
        {
            var list = db.Renta
            .Where(v => v.EstadoID == 1)
            .Include(e => e.Estado);
            return list.ToList();
        }

        public int ModificarRenta (Renta renta)
        {
            int r = 0;
            if (renta != null)
            {
                db.Entry(renta).State = EntityState.Modified;
                r = db.SaveChanges();
            }
            return r;
        }

        public int DeleteRenta (int id)
        {
            int r = 0;
            Renta renta = db.Renta.Find(id);
            renta.EstadoID = 2;
            r = ModificarRenta(renta);
            return r;
        }

        public Renta findrenta(int id)
        {
            Renta renta = db.Renta.Find(id);
            return renta;
        }
    }
}
