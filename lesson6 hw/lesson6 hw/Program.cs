namespace lesson6_hw
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    string s = "salammmmaaa";
        //    Console.WriteLine(correctpas(s)) ;

        //}
        //public static bool correctpas(string a) {
        //    if (a.Length >= 8) {
        //        int let = 0, dig = 0, par = 0;
        //        foreach (var item in a)
        //        {
        //            bool flag = false;
        //            if (char.IsLetterOrDigit(item) || char.IsPunctuation(item)) {
        //                if (char.IsDigit(item))
        //                {
        //                    dig++;
        //                }
        //                else if (char.IsLetter(item))
        //                {
        //                    let++;
        //                }
        //                else par++;
        //        }
        //            if (dig >= 1 && let >= 1 && par >= 1) return true;

        //        }

        //    }
        //    return false;
        //}
        //static void Main(string[] args)
        //{

        //}
        //public static void fun(string a) {
        //    for (int i = 0; i < a.Length; i++) { 

        //    while(char.IsLetter(a[i])) {
        //            if (a[i] == ' ') {
        //                Console.WriteLine();
        //            } 
        //    }


        //}
        //SUBSTRInG

        //static void Main(string[] args)
        //{
        //    string s = "salamamsdnad";
        //    int n = 5, m = 3;
        //    sub(s, n, m);
        //}
        //public static void sub(string s, int a, int b)
        //{
        //    for (int i = a; i < b + a; i++)
        //    {
        //        Console.Write(s[i]);

        //    }

        //}

        //REPLACE
        static void Main(string[] args)
        {
            string s = "salam";
            char k='s';
            char l = 'm';
            rep (s,k, l);
        }
        public static void rep(string a, char b,char c) {
            foreach (var item in a)
            {
                if (item == b) {
                    b = c;
                
                }
               
                
            }
            Console.WriteLine(a);

        }
    }
}
