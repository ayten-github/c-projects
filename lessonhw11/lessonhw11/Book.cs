using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonhw11
{
    internal class Book : Product
    {
        public String Genre { get; set; }
        public Book(int id, string name, double price, int count, string genre) : base(id, name, price, count)
        {
            Genre = genre;
        }

    }
}
