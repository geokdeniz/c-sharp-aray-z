using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "geokdenizyilmaz28@gmail.com";
            string[] a = email.Split('@');
            Console.WriteLine(a[0]+" "+a[1]);
            Console.ReadKey();
        }
    }
}
