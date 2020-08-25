using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Dto;
namespace Project.Controllers
{
    [RoutePrefix("api/Employee")]
   [EnableCors(origins: "http://localhost:8100", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("login/{id}/{ps}")]
        public IHttpActionResult Login([FromUri] string id, [FromUri]string ps)
        {
            return Ok(Bl.EmployeeBl.Login(id, ps));
        }

        [HttpPost]
       [Route("AddNew")]
        public IHttpActionResult AddNew([FromUri] EmployeeDto emp)
        {
            if( Bl.EmployeeBl.AddNew(emp))
                return Ok();
            else
                return BadRequest();
        }

    }
}
