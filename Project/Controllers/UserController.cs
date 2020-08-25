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
    public class UserController : ApiController
    {

        [HttpGet]
        [Route("login/{id}/{password}")]
        public IHttpActionResult Login([FromUri] string id, [FromUri]string password)
        {


            return Ok(Bl.UserBl.Login(id, password));
        }
<<<<<<< HEAD
    

        [Route("register")]
        [HttpPost]
        public bool Register(UserDto user)
        {
           return Bl.UserBl.Register(user);
=======
        [HttpPut]
        [Route("register/{user}")]
        public bool AddNew([FromUri] UserDto user)
        {
           return Bl.UserBl.AddNew(user);
>>>>>>> 318f8ce07cf3a0e9e0cded04481984ce18c09d89
        }
    }
}
