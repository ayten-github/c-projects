using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19hw
{
    public class Library
    {
        List<Book> libraries=new List<Book> ();
        public void AddBook(Book book)
        {
            
            libraries.Add(book);
            //Helper.Add(book, ref libraries);
        }
        public List<Book> FindAllBooksByName(string name) {
            List<Book> lib = new List<Book>();
            foreach (var item in libraries)
            {
                if(item.Name.Equals(name))
                {
                    lib.Add(item);
                }
                
            }
            return lib;
        }
        public Book? FindBookByCode(string code)
        {
            Book searched = null;
            
            foreach (var item in libraries)
            {
                if (item.Code == code) searched = item;
            }
            if (searched == null) throw new NullReferenceException("code daxil edin.");
            return searched;
        }
        public void RemoveBookByCode(string value)
        {
            Book? searched = libraries.FirstOrDefault(x => x.Code == value);
            if (searched == null) throw new NullReferenceException();
            libraries.Remove(searched);
        }
    }
}
