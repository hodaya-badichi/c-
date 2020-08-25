using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Project.Controllers
{
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
    }
}
