using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesso13hwpart2
{
    public class Car
    {
        private static int _id=0;
        public int Id
        {
            get
            {
                return _id;
            }
            set {
                _id++;
                Id = _id;
            }
        }
        public string Brand;
        public string Model;
        public string Type;
        public override string ToString()
        {
            return $"Id {Id} Brand{Brand} Model{Model} Type{Type} ";
        }
    }
}
