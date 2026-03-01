using System;
namespace solutions_codeforces
{
    
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);
            Console.WriteLine($"floor {A} / {B} = {A / B}");
            Console.WriteLine($"ceil {A} / {B} = {(A + B - 1) / B}");
            Console.WriteLine($"round {A} / {B} = {(A + B / 2) / B}");
        }
    }
}