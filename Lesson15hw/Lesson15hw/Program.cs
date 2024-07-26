namespace Lesson15hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User() { };
            Group g1=new Group() { };
            Console.WriteLine("chose option 1 or 2");
            int num = int.Parse(Console.ReadLine());
            if (num == 1) { 
            u1.ShowInfo();
            }
            else
            {
         Group g2=new Group() { };

                Console.WriteLine("chose option 1,2,3 or 0");
                int num2 = int.Parse(Console.ReadLine());
                if (num2 == 1) { 
                
                }
            }          

        }
    }
}
