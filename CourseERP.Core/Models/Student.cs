using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Core.Models
{
    public class Student: BaseModel
    {
        public String FullName { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FullName}--{Id}";
        }

    }
}
