using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_Demo.Models;

namespace Web_API_Demo.Controllers
{
    public class ItemsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult getItem(int id)
        {
            ItemsContext itemsContext = new ItemsContext();
            Items items = itemsContext.Items.Single(t => t.ID == id);

            return Ok(items);
        }

        [HttpGet]
        public IHttpActionResult getAllItems()
        {
            ItemsContext itemsContext = new ItemsContext();
            List<Items> items = itemsContext.Items.ToList();

            return Ok(items);
        }
    }
}
