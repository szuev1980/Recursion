using System;

namespace Factorial
{
    class Program
    {
        static void Rec(int i)
        {
            if (i > 1) Rec(--i);
            Console.WriteLine("***");
        }

        static void Main(string[] args) 
        {
            Rec(3);
        }
    }
}
