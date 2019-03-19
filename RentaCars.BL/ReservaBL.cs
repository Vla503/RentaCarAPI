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
    public class ReservaBL
    {
        private ReservaDAL DAL = new ReservaDAL();

        public int AddReserva(Reserva Alqui)
        {
            return DAL.AddReserva(Alqui);
        }
        public List<EN.Reserva> ReservaList(string state)
        {
            return DAL.ReservaList(state);
        }
        public int UpdateReserva(EN.Reserva Alqui)
        {
            return DAL.UpdateReserva(Alqui);
        }
        public int DeleteReserva(int id)
        {
            return DAL.DeleteReserva(id);
        }
        public  Reserva FindReserva(int id)
        {
            return DAL.FindReserva(id);
        }
    }
}
