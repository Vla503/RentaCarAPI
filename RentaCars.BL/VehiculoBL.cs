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
    public class VehiculoBL
    {
        private VehiculoDAL DAL = new VehiculoDAL();
  
        public int InserVehiculo(Vehiculo Auto)
        {
            return DAL.AddVehiculo(Auto);
        }
        public List<Vehiculo> VehiculoList(string state)
        {
            return DAL.VehiculoList(state);
        }
        public int UpdateVehiculo(Vehiculo Auto)
        {
            return DAL.UpdateVehiculo(Auto);
        }
        public int DeleteVehiculo(int id)
        {
            return DAL.DeleteVehiculo(id);
        }
        public Vehiculo FindVehiculo(int id)
        {
            return DAL.FindVehiculo(id);
        }
    }
}
