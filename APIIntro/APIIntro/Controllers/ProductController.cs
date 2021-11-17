using APIIntro.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Net;


namespace APIIntro.Controllers
{
    public class ProductController : ApiController
    {
        // GET: Product
      public List<ProductModel> Get()
        {
            List<ProductModel> prods = new List<ProductModel>();
            for ( int i= 0; i < 10; i++)
            {
                prods.Add(new ProductModel() { Id = i + 1, Name = " Product " + i });

            }
            return prods;
        }

        public ProductModel Get(int id)
        {
            return new ProductModel()
            {
                Id = id,
                Name = "Pro" + id
            };
        }
    }
}