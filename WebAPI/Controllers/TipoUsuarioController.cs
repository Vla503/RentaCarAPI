using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RentaCars.EN;
using RentaCars.BL;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TipoUsuarioController : ApiController
    {
        private Tipo_UsuarioBL TBL = new Tipo_UsuarioBL();
        // GET: api/TipoUsuario
        public IEnumerable<TipoUsuario> Get()
        {
            return TBL.Tipo_UsuarioList("Activo");
        }

        // GET: api/TipoUsuario/5
        public TipoUsuario Get(int id)
        {
            TipoUsuario TU = TBL.FindTipo_Usuario(id);
            if (TU == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NoContent));
            }
            return TBL.FindTipo_Usuario(id);
        }

        // POST: api/TipoUsuario
        public HttpResponseMessage Post([FromBody]TipoUsuario TU)
        {
            if (ModelState.IsValid)
            {
                TBL.InserTipo_Usuario(TU);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, TBL);
                response.Headers.Location = new Uri(Url.Link("DefauldtApi", new { id = TU.TipoUsuarioID }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT: api/TipoUsuario/5
        public HttpResponseMessage Put(int id, [FromBody]TipoUsuario TU)
        {
            if (ModelState.IsValid)
            {
                if (id > 0)
                {
                    TU.TipoUsuarioID = id;
                    TBL.UpdateTipo_Usuario(TU);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotModified));
                }
            }
            else
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest));
            }
        }

        // DELETE: api/TipoUsuario/5
        public HttpResponseMessage Delete(int id)
        {
            if (ModelState.IsValid)
            {
                TBL.DeleteTipo_Usuario(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest));
            }
        }
    }
}
