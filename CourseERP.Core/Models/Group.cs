using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Core.Models
{
    public class Group:BaseModel
    {
        public string Code {get;set;}
        public int StudentCapacity { get; set; }    
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public override string ToString()
        {
            return $"{Code}---{Id}";
        }
    }
}
