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
    public class ReservaDAL
    {
        //Instancia a la clase Contexto del Proyecto
        private ProjectContext db = new ProjectContext();
        //Funcion de agregar
        public int AddReserva(Reserva Alqui)
        {
            int r = 0;
            if (Alqui != null)
            {

                db.Reserva.Add(Alqui);
                r = db.SaveChanges();
            }
            return r;
        }
        //funcion que devuelve datos
        public List<EN.Reserva> ReservaList(string state)
        {
            var List = from Re
                        in db.Reserva
                       where Re.Estado.Nombre == "Activo"
                       select Re;
            return List.ToList();
        }
        //Funcion de modificacion
        public int UpdateReserva(Reserva Alqui)
        {
            int r = 0;
            if (Alqui != null)
            {
                db.Entry(Alqui).State = EntityState.Modified;
                r = db.SaveChanges();
            }
            return r;
        }
        //Funcion de eliminar
        public int DeleteReserva(int id)
        {
            int r = 0;
            EN.Reserva alqui = db.Reserva.Find(id);
            alqui.EstadoID = 2;
            r = UpdateReserva(alqui);
            return r;
        }
        //Funcion de buscar por ID
        public Reserva FindReserva(int id)
        {
            Reserva alqui = db.Reserva.Find(id);
            return alqui;
        }
    }
}
