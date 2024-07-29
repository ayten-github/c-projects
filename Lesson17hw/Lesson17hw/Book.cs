using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17hw
{
    public class Book
    {
        private static int _id;
        public string Name { get; set; }
        public int Id { get {

                return _id;

            } internal set {
                ++_id;
                Id = _id;
            }
        }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public Book()
        {


        }
        public string CorrectCode(string code)
        {
            string cor;
            cor = code.Substring(0, 2).ToUpper();
            return cor + code;
        }

    }
}
