using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesso13hwpart2
{
    public class Car
    {
        public string Name;
        public string Brand { get; set; }
        public string Model{ get; set; }
        public CarType Type{ get; set; }
        //public Car(string name, CarType type) {
        //    name = name;
        //    Type = type;
        
        //}
        public override string ToString()
        {
            return $"Name:{Name} Brand {Brand} ,Model {Model} ,Type :{Type} ";
        }
    }
}
