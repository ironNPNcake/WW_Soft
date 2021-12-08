using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataCollector.Controllers
{
    public class ServiceController : ApiController
    {
        public bool Test()
        { 
            return true;
        }
        public IHttpActionResult Get()
        {
            return Ok("asd");
        }
    }
}
