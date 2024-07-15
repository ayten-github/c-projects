using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwlesson8
{
    public class market
    {
        public string Name;
        public int EmptyStock;
        public int SoldProduct;
        public int ProductCostPrice;
        public int AddingProduct;
        public double Income;
        public market(int emptyStock, int soldProduct, int productCostPrice, int addingProduct, double income) 
        {
            EmptyStock = emptyStock;
            SoldProduct = soldProduct;
            ProductCostPrice = productCostPrice;
            AddingProduct = addingProduct;
            Income = income;
        }

        public void Sell(int solprod) {
            EmptyStock += solprod;
            SoldProduct += solprod;

        }
        public void AddProduct(int ComeProduct) {
            if (EmptyStock >= ComeProduct)
            {
                EmptyStock -= ComeProduct;
                AddingProduct -= ComeProduct;
                Console.WriteLine(EmptyStock);
                Console.WriteLine(AddingProduct);
            }
            else if (EmptyStock <ComeProduct&& EmptyStock>=1) {
                EmptyStock = ComeProduct;
                EmptyStock -= ComeProduct;
                AddingProduct-= ComeProduct;
                Console.WriteLine(EmptyStock);
                Console.WriteLine(AddingProduct);
            }
            else Console.WriteLine("bosh yer yoxdur");
        }
    }
}
