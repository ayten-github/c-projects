using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonhw10
{
    public class Library
    {
        public Book[] Books = Array.Empty<Book>();
        public void Addbook( Book book) { 
        Array.Resize(ref Books,Books.Length+1);
            Books[Books.Length-1] = book;
        
        }
        public Book[] GetAllBooks() {
            return Books;

                } 
        public Book? GetBookById(int id) {
            foreach (var book in Books)
            {
                if (book.Id == id) {
                    return book;
                }
                
            }
            return null;
        }
        public Book? GetBookByName(string name) {
            foreach (var book in Books)
            {
                if (book.Name == name)
                { return book;
                }
               
            }
            return null;
        }
        public Book[] GetfilteredBook(string genre) {
            Book[] filteredbook = Array.Empty<Book>(); 
            foreach (var book in Books) {
            if(book.Genre == genre) 
                {
                    Array.Resize(ref filteredbook, filteredbook.Length + 1);
                    filteredbook[^1] = book;

                }
                }
            return filteredbook;
            }

        public Book[] GetFilteredBook(double maxprice, double minprice) {
            Book[] filteredbook=Array.Empty<Book>();
            foreach (var book in Books)
            {
                if (book.Price <= maxprice&& book.Price>=minprice) {
                    Array.Resize(ref filteredbook, filteredbook.Length + 1);
                    filteredbook[^1] = book;
                }
            }
            return filteredbook;

        }

        }
    }

