using System;
namespace solutions_codeforces
{
    
    class Program
    {
        static void Main()
        {
            String[] input = Console.ReadLine().Split(' ');
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);
            long c = A % 10 + B % 10;
            Console.WriteLine(c);
        }
    }
}