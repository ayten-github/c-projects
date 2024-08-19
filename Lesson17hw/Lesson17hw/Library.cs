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
            books[books.Length-1] = book;

        }
        public Book[] FindAllBooksByName(string name) 
        {
            Book[] newBook= new Book[0]; 
            foreach (var item in books)
            {
                if (item.Name == name)
                {
                    Array.Resize(ref newBook, newBook.Length + 1);
                    newBook[newBook.Length - 1] = item;
                }
               

            }
            return newBook ;
        }
        public Book? FindBookByCode(string code) {

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

            Book[] searched = new Book[0];

            if (min == null && max == null)
            {
                throw new NullReferenceException("min ve max daxil etmelisiniz");
            
        }
            foreach (var item in books)
            {

                if (item.PageCount >= min && item.PageCount <= max)
                {
                    Array.Resize(ref searched, searched.Length + 1);
                    searched[searched.Length - 1] = item;
                }
            }
            return searched;
        }
        public void RemoveBookByCode( Book book,ref Book[] books)
        {
            int arraysize = 0;
            foreach (var item in books)
            {
                if(item.Equals(book)) arraysize++;
                
            }
            Book[] newAr = new Book[arraysize];
            int k = 0;
            foreach (var item in books)
            {
                if(!item.Equals(book)) newAr[k++] = item;
                
            }
            books = newAr;

        }
        
    }
}
