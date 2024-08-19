using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLess.Core.Models
{
    public class Product:BaseModel
    {
        public static int _id;
        public Product()
        {
            _id++;
            Id=_id;
        }
        public string Name { get; set; }
        public decimal CostPrice { get;set; }
        public decimal SalePrice { get; set; }
        
    }
}
