using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using UI;

namespace nDiamonds.Controllers
{
    [RoutePrefix("api/diamondStatus")]
    public class diamondStatusController : ApiController
    {
        // GET: api/diamondStatus
        [Route("endStatus/{professionalId}/{diamondName}/{date}")]
        public IHttpActionResult endStatus(int professionalId,string diamondName,DateTime date)
        {
            return Ok(UI.diamondsStatusUI.getDiamondOfEndingStatus(professionalId, diamondName, date));
        }

        // GET: api/diamondStatus/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/diamondStatus
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/diamondStatus/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/diamondStatus/5
        public void Delete(int id)
        {
        }
    }
}
