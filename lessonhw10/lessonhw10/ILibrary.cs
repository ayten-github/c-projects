using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonhw10
{
    internal interface ILibrary 
    {
     void AddBook();
     Book GetBookById();
     Book GetBookByName();
     Book[] GetFilteredBooks();
     Book[] GetFilteredBooks(double n, double m);

    }
}
