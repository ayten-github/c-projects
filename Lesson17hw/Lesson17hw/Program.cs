namespace Lesson17hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1=new Book();
            Library l1 = new Library();
            l1.Add(b1);
            l1.RemoveBookByCode(b1.Code);
        
        }
    }
}
