using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIWeb.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/Names")]
        [HttpGet]

       public List<string> GetNames()
        {
            return ProductService.GetNames();
                
           

            
        }
    }
}
