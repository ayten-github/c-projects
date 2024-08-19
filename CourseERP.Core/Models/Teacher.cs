using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Core.Models
{
    public class Teacher:BaseModel
    {
        public string FullName { get; set; }
        public int Age { get;set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"{FullName}--{Id}";
        }
    }
}
