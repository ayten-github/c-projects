using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonhw11
{
    public class Product
    {
        
        private double _price;
        private int _count;
        public int  Id { get; set; }
        public string Name { get; set; }
        public double Price {
            get {
                return _price;
            } set
            {
                if (value > 0) _price=value;
            }
                }
        public int Count { get {

                return _count;
            } set { 
            if(value>5) _count=value;
            } 
        }

        public Product(int id,string name,double price,int count) {
            Id = id;
            Name = name;
            Price = price;
            Count = count;
        
        }   
    }
}
