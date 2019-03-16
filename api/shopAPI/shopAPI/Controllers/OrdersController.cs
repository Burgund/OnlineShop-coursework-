using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace shopAPI.Controllers
{
    public class OrdersController : ApiController
    {
        // GET: api/Orders
        public JsonResult Get()
        {
            //test hardcoded data, should be an ShopDataAccess entity
            var result = new JsonResult();

            result.Data = new
            {
                customer = "User123",
                product = "Intel i7",
                price = "899.99"
            };

            return result;
        }

        // GET: api/Orders/5
        public JsonResult Get(int id)
        {
            //test hardcoded data, should be an ShopDataAccess entity
            var result = new JsonResult();

            result.Data = new
            {
                customer = "User123",
                product = "Intel i7",
                price = "899.99"
            };

            return result;
        }

        // POST: api/Orders
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
