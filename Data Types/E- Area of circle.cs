using System;
namespace solutions_codeforces
{
    
    class Program
    {
        static void Main()
        {
            double π = 3.141592653;
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine($"{π * (radius * radius)}");
        }
    }
}