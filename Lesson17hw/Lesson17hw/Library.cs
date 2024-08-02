using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17hw
{
    public class Library
    {
        private Book[] books=Array.Empty<Book>();
        public void Add(Book book)
        {
            Array.Resize(ref books, books.Length+ 1);
            books[books.Length] = book;

        }
        public Book[]? FindAllBooksByName(string name) 
        {
            Book[] searched = null; 
            foreach (var item in books)
            {
                if (item.Name == name) searched=books;
                if (searched == null)
                {
                    throw new NullReferenceException("kitabin adini daxil etememisiz");
                }
                
            }
            return searched;
        }
        public Book FindBookByCode(string code) {

            Book searched = null;
            foreach (var item in books) {
                if (item.Code == code) searched = item;
                if(code==null)
                {

                    throw new NullReferenceException("code daxil edinn");
                }
            }
            return searched;
        }
        public Book[] FindAllBooksByPageCountRange(int min,int max) 
        {
            Book[] searched = null;
            foreach (var item in books)
            {
               
                if (item.PageCount >= min && item.PageCount <= max)  searched = books;
                if (min == null && max == null)
                {
                    throw new NullReferenceException("min ve max daxil etmelisiniz");                }
            }
            return searched;
        }
        public void RemoveBookByCode( string code)
        {
            foreach (var item in books)
            {
                if (item.Code == code)
                {
                    books = null;
                }
                
            }

        }
        
    }
}
