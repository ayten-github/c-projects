using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Core.Models
{
    public class Teacher:BaseModel
    {
        private static int _id;
        public Teacher()
        {
            _id++;
            Id=_id;
        }
        public double Salary { get;set; }
        public List<Student> Students = new List<Student>();
        public override string ToString()
        {
            return $"{Name}--{Salary}";
        }

    }
}
