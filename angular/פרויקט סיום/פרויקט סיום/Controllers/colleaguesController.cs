using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UI;
namespace פרויקט_סיום.Controllers
{
 [RoutePrefix("api/colleagues")]
    public class colleaguesController : ApiController
    {
        // GET: api/colleagues
        [Route("GetColleagues")]
        [HttpGet]

        public IHttpActionResult GetColleagues()
        {
            return Ok(UI.Class1.getcolleagues());
        }
        [Route("addColleagues")]
        [HttpGet]
        // GET: api/colleagues/5
        public bool addColleagues(string password, string name)
        {
           return UI.Class1.isExist(password, name);
        }

        // POST: api/colleagues
        public void Post([FromBody]string value)
        {
        }
      
        // PUT: api/colleagues/5
        

        // DELETE: api/colleagues/5
        public void Delete(int id)
        {
        }
    }
}
