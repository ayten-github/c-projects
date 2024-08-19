namespace Lesson17hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1=new Book() { PageCount=100};
            Book b2 = new Book() { PageCount=94};
            Book b3 = new Book() { PageCount=91};
            Library l1 = new Library();
            l1.Add(b1);
            l1.Add(b2);
            l1.Add(b3);
            //foreach (var item in l1.FindAllBooksByPageCountRange(90, 95))
            //{
            //    Console.WriteLine(item.Id);

            //}

        }
    }
}
