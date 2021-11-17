using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsRepo
    {
      public  static NewsPortalEntities db;

        static NewsRepo()
        {
            db = new NewsPortalEntities();
        }

        public static List<News>Get()
        {
            return db.News.ToList();
        }

        public static News Get(int Id)
        {
            return db.News.FirstOrDefault(e => e.ID == Id);
        }

        public void Edit ( News n)
        {
            var ds = db.News.FirstOrDefault(e => e.ID == n.ID);
            db.Entry(ds).CurrentValues.SetValues(n);
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            var ds = db.News.FirstOrDefault(e => e.ID == Id);
            db.News.Remove(ds);
        }

        public static void Add(News n)
        {
            db.News.Add(n);
            db.SaveChanges();

        }

    }
}
