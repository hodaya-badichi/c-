﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Project.Controllers
{
    [RoutePrefix("api/Employee")]
    [EnableCors(origins: "http://localhost:8200/", headers: "*", methods: "*")]
    public class TravleController : ApiController
    {
        [HttpGet]
        [Route("travlesOfEmp/{id}")]
        public IHttpActionResult TrvlesOfEmployee([FromUri] string id)
        {
<<<<<<< HEAD
    
=======
>>>>>>> 318f8ce07cf3a0e9e0cded04481984ce18c09d89
            return Ok(Bl.TravleBl.TrvlesOfEmployee(id));
        }
    }
}
