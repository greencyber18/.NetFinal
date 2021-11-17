using BLL;
using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/News/Headlines")]
        [HttpGet]

        public List<string> GetHeadlines()
        {
            return NewsService.GetHeadlines();
        }

        [Route("api/News/All")]
        [HttpGet]

        public List<NewsModel> GetAll()
        {
            return NewsService.Get();
        }


        [Route("api/News/Create")]
        [HttpPost]

        public void Add(NewsModel n)
        {
            NewsService.Add(n);        }
    }
}
