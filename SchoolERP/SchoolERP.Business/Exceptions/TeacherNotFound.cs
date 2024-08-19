using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Exceptions
{
    public class TeacherNotFound:Exception
    {
        public TeacherNotFound()
        {
            
        }
        public TeacherNotFound(string? message) :base(message) 
        {
            
        }
    }
}
