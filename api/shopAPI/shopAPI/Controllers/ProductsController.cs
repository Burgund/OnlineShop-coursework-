using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using shopAPI.src;

namespace shopAPI.Controllers
{
    public class ProductsController : ApiController
    {
        string[,] products = new string[5, 2];
        ArrayManager filler = new ArrayManager();

        // GET: api/Products
        public string[,] Get()
        {
            products = filler.fillArray(products);
            return products;
        }

        // GET: api/Products/5
        public string[] Get(int id)
        {
            //test hardcoded data, should be an ShopDataAccess entity
            //var result = new JsonResult();

            //result.Data = new
            //{
            //    name = "product2",
            //    price = "599"
            //};

            products = filler.fillArray(products);
            string[] result = filler.sliceDimension(products, id);
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
