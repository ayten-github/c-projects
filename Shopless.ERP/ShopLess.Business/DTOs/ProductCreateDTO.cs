using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLess.Business.DTOs
{
    public record ProductCreateDTO(string name,decimal SalePrice,decimal CostPrice);

}
