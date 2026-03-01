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
            if ((A > B) || (A == B))
                Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }
}