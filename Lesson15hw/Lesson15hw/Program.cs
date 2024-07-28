using System.Linq.Expressions;

namespace Lesson15hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("userin fullnameni girin:");
                string fullname = Console.ReadLine();
                Console.WriteLine("userin emailini girin :");
                string email = Console.ReadLine();
                Console.WriteLine("userin passwordunu girin:");
                string password = Console.ReadLine();
                User user1 = new User(email, password) { Fullname = fullname };
                Console.WriteLine("chose one of them" +
                    " 1. Show info\n        " +
                    "2. Create new group");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            user1.ShowInfo();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("group limit :");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("grop no:");
                            string no = Console.ReadLine();
                            Group g1 = new Group(no, limit);
                            Console.WriteLine(" 1. Show all students\n      " +
                                "  2. Get student by id\n        " +
                                "3. Add student\n       " +
                                " 0. Quit");
                            int choice2= Convert.ToInt32(Console.ReadLine());
                            switch (choice2)
                            {
                                case 1:
                                    {
                                        foreach (var item in g1.GetAllStudent())
                                        {
                                            Console.WriteLine(item);
                                        }

                                    }break;
                                    case 2: {
                                        Console.WriteLine("id verin:");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        try
                                        {
                                            Console.WriteLine(g1.GetStudent(id));
                                        }
                                        catch(Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                                                                
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("studentin fullnameni daxil edin:");
                                        string name = Console.ReadLine();
                                        Console.WriteLine("studentin pointini daxil edin:");
                                        int point=Convert.ToInt32(Console.ReadLine());
                                        Student student = new Student(name, point);
                                        g1.AddStudent(student);

                                    }
                                    break;
                                case 0:
                                    {
                                        break;
                                    }
                            
                            }
                        }
                        break;
                }
            }

        }
    }
}
