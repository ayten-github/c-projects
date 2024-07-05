using System.Security.Cryptography.X509Certificates;

namespace hw5
{
    internal class Program
    {

        // Task3
        //static void Main(string[] args)
        //{
        //    String name = "    hello    ";
        //    fix(name);
        //}
        //public static void fix(string a) {
        //    foreach (var i in a)
        //    {
        //        if(i!=' ') Console.Write(i);
        //    }

        //}
        //task2
        // return type
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(sum(12));


        //}
        //public static int sum(int n)
        //{
        //    int sumofeven = 0;
        //    for (int i = 0; i <= n; i++)
        //    {
        //        if (i % 2 == 0) sumofeven += i;
        //    }
        //    return sumofeven;
        //}
        //void type
        //static void Main(string[] args)
        //{
        //    sum(10);
        //}
        //public static void sum(int n)
        //{
        //    int sumofeven = 0;
        //    for (int i = 0; i <= n; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            sumofeven += i;
        //        }

        //    }
        //    Console.WriteLine(sumofeven);

        //}
        //Task 1
        static void Main(string[] args) {
            up( "HEllo WOrd");
        }
        public static void up(string name) {
            for (int i = 0; i < name.Length; i++) {
                if (char.IsUpper(name[i]) ) Console.Write(name[i] +" ");
            }
        }


    }
}
