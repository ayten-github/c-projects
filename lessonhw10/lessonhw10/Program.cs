using System.Runtime.InteropServices;

namespace lessonhw10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book(1, "martin Edin", 15.2, "dram");
            Book book2 = new Book(2, "Harry potter", 10.2, "fantastik");
            Book book3 = new Book(3, "lord of ring", 12.11, "fantastik");
            Book book4 = new Book(4, "lttle prencess", 21.15, "fantastik");
            Library lib1 = new Library();
            lib1.Addbook(book1);
            lib1.Addbook(book2);
            foreach (var book in lib1.GetAllBooks()) {
                Console.WriteLine(book.Genre);
            }
        
        }
    }
}
