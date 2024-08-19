using ShopLess.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLess.Business.Interfaces
{
    public interface IProductService
    {
        public void Create(ProductCreateDTO product);
        public ProductGetDTO GetById(int id);
        public List<ProductGetDTO> GetAll();
        public void Delete(int id);


    }
}
