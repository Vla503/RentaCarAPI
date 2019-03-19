using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaCars.EN;
using System.Data.Entity;

namespace RentaCars.DAL
{
    public class EstadoDAL
    {
        private ProjectContext db = new ProjectContext();

        public int AddEstado(Estado esta)
        {
            int r = 0;
            if (esta != null)
            {
                db.Estado.Add(esta);
                r = db.SaveChanges();
            }
            return r;
        }
        public List<Estado> StateList()
        #region Mostrar Estado
        {
            var List = from Estado
                       in db.Estado
                       select Estado;
            return List.ToList();
        }
        #endregion
        public int UpdateState(Estado st)
        #region Modificar Estado
        {
            int r = 0;
            if (st != null)
            {
                db.Entry(st).State = EntityState.Modified;
                r = db.SaveChanges();
            }

            return r;
        }
        #endregion
        public Estado FindState(int id)
        #region Buscar Estado
        {
            Estado estado = db.Estado.Find(id);
            return estado;
        }
        #endregion
    }
}
