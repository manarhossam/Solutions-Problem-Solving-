using System;
using System.ComponentModel.Design;
namespace solutions_codeforces
{
    
    class Program
    {
        static void Main()
        {
           char X=char.Parse(Console.ReadLine());
            if (X >= 'A' && X <= 'Z')
            {
                Console.WriteLine("ALPHA");
                Console.WriteLine("IS CAPITAL");
            }
            else if (X >= 'a' && X <= 'z')
            {
                Console.WriteLine("ALPHA");
                Console.WriteLine("IS SMALL");
            }
            else
                Console.WriteLine("IS DIGIT");

        }
    }
}