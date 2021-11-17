using API2.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API2.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<ProductModel> Get()
        {
            List<ProductModel> prods = new List<ProductModel>();
            for (int i = 0; i < 10; i++)
            {
                prods.Add(new ProductModel() { Id = i + 1, Name = " Product " + i });

            }
            return prods;
        }

        [HttpPost]
        public ProductModel Get(int id)
        {
            return new ProductModel()
            {
                Id = id,
                Name = "Pro" + id
            };
        }

        public string post()
        {
            return "post";
        }
    }
}
