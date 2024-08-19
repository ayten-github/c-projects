using ShopLess.Business.DTOs;
using ShopLess.Business.Interfaces;
using ShopLess.Core.Models;
using ShopLess.Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLess.Business.Implementations
{
    public class ProductService : IProductService
    {
        public void Create(ProductCreateDTO product)
        {
            ShopData.products.Add(new Product() { Name=product.name,CostPrice=product.CostPrice,SalePrice=product.SalePrice});
        }

        public void Delete(int id)
        {
            Product? searched=ShopData.products.FirstOrDefault(x => x.Id==id);
            if (searched == null) throw new NullReferenceException("not found");
            ShopData.products.Remove(searched);
        }

        public List<ProductGetDTO> GetAll()
        {
            List<ProductGetDTO> product = new List<ProductGetDTO>();
            foreach (var item in ShopData.products)
            {
                product.Add(new ProductGetDTO(item.Name, item.SalePrice) );
            }
            return product;

        }

        public ProductGetDTO GetById(int id)
        {
            Product? searched = ShopData.products.FirstOrDefault(x => x.Id == id);
            if (searched == null) throw new NullReferenceException("not found");
           return new ProductGetDTO(searched.Name, searched.SalePrice);

        }
    }
}
