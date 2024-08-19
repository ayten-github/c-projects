using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Exceptions
{
    public class StudentNotFound:Exception
    {
        public StudentNotFound()
        {
            
        }
        public StudentNotFound(string? message) :base(message) 
        {
            
        }
    }
}
