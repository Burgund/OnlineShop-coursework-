using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;

namespace shopAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public JsonResult Get()
        {
            var result = new JsonResult();

            result.Data = new
            {
                name = "product1",
                price = "499"
            };

            return result;
        }

        // GET: api/Products/5
        public JsonResult Get(int id)
        {
            var result = new JsonResult();

            result.Data = new
            {
                name = "product2",
                price = "599"
            };

            return result;
        }
  

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
