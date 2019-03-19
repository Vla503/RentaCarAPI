using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaCars.EN;
using RentaCars.DAL;

namespace RentaCars.BL
{
    public class EstadoBL
    {
        private EstadoDAL DAL = new EstadoDAL();

        public int AddEstado(Estado esta)
        {
            return DAL.AddEstado(esta);
        }
        public List<Estado> StateList()
        {
            return DAL.StateList();
        }

        public int UpdateState(Estado st)
        {
            return DAL.UpdateState(st);
        }

        public Estado FindState(int id)
        {
            return DAL.FindState(id);
        }
    }

}
