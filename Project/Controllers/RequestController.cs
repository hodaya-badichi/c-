<<<<<<< HEAD
﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
=======
﻿using System;
>>>>>>> 318f8ce07cf3a0e9e0cded04481984ce18c09d89
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Project.Controllers
{
<<<<<<< HEAD
    [RoutePrefix("api/Request")]
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RequestController : ApiController
    {
        [HttpGet]
        [Route("getRequests")]
        public Dto.RequestDto[]  getRequests()
        {
            return Bl.ReqeustBl.GetRequests();
        }
=======
    [RoutePrefix("api/Users")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RequestController : ApiController
    {
>>>>>>> 318f8ce07cf3a0e9e0cded04481984ce18c09d89
    }
}
