using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Project.Controllers
{
    [RoutePrefix("api/Employee")]
   [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("login/{id}/{ps}")]
        public IHttpActionResult Login([FromUri] string id, [FromUri]string ps)
        {
            return Ok(Bl.EmployeeBl.Login(id, ps));
        }
    }
}
