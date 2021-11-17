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
    public static class ProductService
    {
        public static List<ProductModel> Get()
        {

            var config = new MapperConfiguration(c =>
             {
                 c.CreateMap<Product, ProductModel>();
 
                 });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProductModel>>(ProductRepo.Get());
            return data;
        }
        public static List<string> GetNames()
        {
            var data = ProductRepo.Get().Select(e => e.Name).ToList();
            return data;
        }

        public static void Add(ProductModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductModel, Product>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Product>(p);
            ProductRepo.Add(data);

        }
    }
}
