using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13hwtask1
{
    public class NotAviableExeption : Exception
    {
        public NotAviableExeption()
        {
        }

        public NotAviableExeption(string? message) : base(message)
        {

        }
    }
}
