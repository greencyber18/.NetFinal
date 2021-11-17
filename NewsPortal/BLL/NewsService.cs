using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class NewsService
    {
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Category, CategoryModel>();
                c.CreateMap<React, ReactModel>();
                c.CreateMap<User, UserModel>();
                c.CreateMap<Comment, CommentModel>();
 

                });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(NewsRepo.Get());
            return data;
        }

        public static List<string> GetHeadlines()
        {
            
            var data = NewsRepo.Get().Select(e => e.Headline).ToList();
            return data;
        }

        public static void Add(NewsModel n)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<News, NewsModel>();
              


            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            NewsRepo.Add(data);
        }


    }
}
