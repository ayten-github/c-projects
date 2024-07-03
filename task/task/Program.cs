namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product1 = new { Id = 12, Name = "book", Price = 120, StockCount = 117 };
            var product2 = new { Id = 8, Name = "notebook", Price = 80, StockCount = 190 };
            var product3 = new { Id = 9, Name = "pen", Price = 25, StockCount = 241 };
            var product4 = new { Id = 11, Name = "booksticker", Price = 110, StockCount = 100 };
            var arr = new[] { product1, product2, product3, product4 };
            int count = 0;
            double allprice = 0;
            foreach (var i in arr)
            {
                if (i.Id % 2 == 1)
                {
                    count++;
                    allprice += i.Price;
                }
            }

            double average = allprice / count;
            Console.WriteLine(average);
        }
    }
    }
