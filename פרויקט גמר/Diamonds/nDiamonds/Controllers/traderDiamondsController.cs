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
    [RoutePrefix("api/traderDiamonds")]
    public class traderDiamondsController : ApiController
    {
      [Route("getDiamondsOfTrader/{name}/{password}")]
    public IHttpActionResult getDiamondsOfTrader(string name,string password)
        {
            return Ok(UI.traderDiamondsUI.getListDiamondsOfTrader(name,password));
        }

        // GET: api/traderDiamonds/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/traderDiamonds
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/traderDiamonds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/traderDiamonds/5
        public void Delete(int id)
        {
        }
    }
}
