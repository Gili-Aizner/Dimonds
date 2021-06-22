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
    [RoutePrefix("api/users")]
    public class usersController : ApiController
    {
        //// GET: api/users
        //DiampndsDBEntities d = new DiampndsDBEntities();
        //[Route("Get")]
        //public IHttpActionResult Get()
        //{
        //    return Ok(StatusDTO.convertToListDTO(d.status.ToList()));
        //}


        [Route("ifExsistEnterNameAndPassword/{enterName}/{password}")]
        public IHttpActionResult ifExsistEnterNameAndPassword(string enterName, string password)
        {
            return Ok(UI.usersUI.exsistNameAndPassword(enterName, password));
        }

        // GET: api/users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/users
        public void Post([FromBody]string value)
        {

        }

        [Route("addNewTrader")]
        public void addNewTrader([FromBody]UsersDTO u)
        {
            UI.usersUI.addTrader(u);
        }

        // PUT: api/users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/users/5
        public void Delete(int id)
        {
        }
    }
}
