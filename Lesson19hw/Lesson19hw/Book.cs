using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19hw
{
    public class Book
    {
        private static int _id;
        public string Name { get; set; }
        public int Id
        {
            get; internal set;
        }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public Book(string name)
        {
            ++_id;
            Id = _id;
            Name = name;
            Code = CorrectCode(name, Id);
        }
        public string CorrectCode(string name, int id)
        {
            return name.Substring(0, 2).ToUpper() + id;
        }

    }
}
