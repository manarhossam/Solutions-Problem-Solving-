

using System;
namespace solutions_codeforces
{
    
    class Program
    {
        static void Main()
        {
            String[] arr = Console.ReadLine().Split(' ');
            long A = long.Parse(arr[0]);
            long B = long.Parse(arr[1]);
            Console.WriteLine($"{A} + {B} = {A + B}");
            Console.WriteLine($"{A} * {B} = {A * B}");
            Console.WriteLine($"{A} - {B} = {A - B}");

        }
    }
}