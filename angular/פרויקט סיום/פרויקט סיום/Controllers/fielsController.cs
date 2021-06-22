using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace פרויקט_סיום.Controllers
{
    public class fielsController : ApiController
    {
        // GET: api/fiels
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/fiels/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/fiels
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/fiels/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/fiels/5
        public void Delete(int id)
        {
        }
    }
}
