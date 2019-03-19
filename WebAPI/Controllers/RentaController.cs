using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//agregar
using RentaCars.EN;
using RentaCars.BL;

namespace WebAPI.Controllers
{
    public class RentaController : ApiController
    {
        private RentaBL renta = new RentaBL();
        // GET: api/Renta
        public IEnumerable<Renta> Get()
        {
            return renta.ListRenta("Activo");
        }
        // GET: api/Renta/5

        public Renta Get(int id)
        {
            return renta.findRenta(id);
        }

        // POST: api/Renta
        public void Post([FromBody] Renta rent)
        {
            renta.agregarrenta(rent);
        }

        // PUT: api/Renta/5
        public void Put(int id, [FromBody]Renta rent)
        {
            rent.RentaID = id;
            renta.ModificarRenta(rent);
        }

        // DELETE: api/Renta/5
        public void Delete(int id)
        {
            renta.DeleteRenta(id);
        }
    }
}
