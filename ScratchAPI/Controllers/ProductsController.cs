using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ScratchAPI.Controllers
{

    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {

        [Route("all")]
        public HttpResponseMessage GetAll() => Request.CreateResponse(HttpStatusCode.OK, new List<Product>
        {
            new Product {Name = "Coke" },
            new Product {Name = "Coffee" }
        });

        [Route("drinks")]
        public IEnumerable<Product> GetDrinks() => new Product[] { new Product { Name = "Coke" } };

        [Route("{name:alpha}")]
        public HttpResponseMessage GetByName(string name)
        {
            var items = new List<Product>
            {
                new Product {Name = "Coke"},
                new Product {Name = "Coffee"}

            };

            return Request.CreateResponse(HttpStatusCode.OK, items.First(x => x.Name == name));
        }
    }

    public class Product
    {
        public string Name { get; set; }
    }
}
