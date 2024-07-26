using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15hw
{
    public class GroupNotFoundException : Exception
    {
        public GroupNotFoundException()
        {
        }

        public GroupNotFoundException(string? message) : base(message)
        {
        }
    }
}
