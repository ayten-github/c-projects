using ShopLess.Business.DTOs;
using ShopLess.Business.Implementations;
using ShopLess.Business.Interfaces;
using System.Threading.Channels;

namespace ShopLess.CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService prSerevi=new ProductService();
            ProductCreateDTO product1 = new ProductCreateDTO("IPhone16", 5000, 4000);
            ProductCreateDTO product2 = new ProductCreateDTO("SamsungS24", 6000, 5500);
            ProductCreateDTO product3 = new ProductCreateDTO("A53", 5000, 4000);
            prSerevi.Create(product1);
            prSerevi.Create(product2);
            prSerevi.Create(product3);
            Console.WriteLine(prSerevi.GetById(1));
            prSerevi.GetAll().ForEach(x => Console.WriteLine(x.name));

        }
    }
}
