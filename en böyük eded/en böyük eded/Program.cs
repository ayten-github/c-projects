using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace en_böyük_eded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] myNumber = { 1, 2, 5, 7, 9 };
            // int mymax=myNumber[0];
            //for (int i = 0; i < myNumber.Length; i++) {
            //     if (mymax < myNumber[i]) mymax=myNumber[i];
            // }
            // Console.WriteLine(mymax);

            // TASK 1.2
            //var product1 = new { Id = 12, Name = "book", Price = 120, StockCount = 117 };
            //var product2 = new { Id = 8, Name = "notebook", Price = 80, StockCount = 190 };
            //var product3 = new { Id = 9, Name = "pen", Price = 25, StockCount = 241 };
            //var product4 = new { Id = 11, Name = "booksticker", Price = 110, StockCount = 100 };
            //var arr = new[] { product1, product2, product3, product4 };
            //int count = 0,allprice =0;
            //foreach (var i in arr)
            //{
            //    if (i.Id%2==1)
            //    {
            //        count++;
            //        allprice += i.Price;
            //    }
            //}

            //double average = allprice / count;
            //Console.WriteLine(average);

            //TASK 1.3
           string s = "Programming";
         
for (int i = 0; i < s.Length; i++)
{ 
bool flag = true;
int count = 0;

    for (int j = 0; j < i; j++)
    {
        if (s[j] == s[i])
        {
            flag = false;
            break;
        }
    }
    if (flag) { 
    for (int k = 0; k < s.Length; k++)
        {
            if (s[k] == s[i])
            {
                count++;
            }
        } 
        Console.Write(count);
        Console.WriteLine(s[i]);
    }
        

}



        }
    }
}
