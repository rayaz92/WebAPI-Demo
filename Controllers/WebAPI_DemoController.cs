using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_Demo.Models;


namespace Web_API_Demo.Controllers
{
    public class WebAPI_DemoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult getTest(int s)
        {
            int res = s;
            if (res == 0)
            {
                return NotFound();
            }
            return Ok(101);
        }

        
        public IHttpActionResult GetNumber(int id)
        {
            int res = id;
            if (res == 0)
            {
                return NotFound();
            }
            return Ok(id);
        }
    }
}
