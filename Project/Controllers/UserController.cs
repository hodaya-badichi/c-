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
    [RoutePrefix("api/Users")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        
        [HttpGet]
        [Route("login/{id}/{password}")]
        public IHttpActionResult Login([FromUri] string id, [FromUri]string password)
        {
            return Ok(Bl.UserBl.Login(id, password));
        }
        [HttpPut]
        [Route("register/{user}")]
        public bool AddNew([FromUri] UserDto user)
        {
           return Bl.UserBl.AddNew(user);
        }
    }
}
