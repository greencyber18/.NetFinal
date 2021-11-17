using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static e_comEntities db;
        static ProductRepo()
        {
            db = new e_comEntities();
        }

        public static List<Product> Get()
        {
            return db.Products.ToList();
        }

        public static Product Get(int id)
        {
            return db.Products.FirstOrDefault(e => e.Id == id);
        }

        public static void Edit(Product p)
        {
            var ds = db.Products.FirstOrDefault(e=>e.Id==p.Id);
            db.Entry(ds).CurrentValues.SetValues(p);
            db.SaveChanges();
        }
        public static void delete (int id)
        {
            var ds = db.Products.FirstOrDefault(e => e.Id == id);
            db.Products.Remove(ds);
        }
        public static void Add(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }
    }
}
