using System;
namespace solutions_codeforces
{
    
    class Program
    {
        static void Main()
        {
            int max = 0;
            int min = 0;    
            String[] input1 = Console.ReadLine().Split(' ');
            int ie=int.Parse(input1[0]);
            int we=int.Parse(input1[1]);
            int u=int.Parse(input1[2]);
            if (ie > we && ie > u)
                max = ie;
            else if (we > ie && we > u)
                max = we;
            else
                max = u;
            if(ie <we && ie < u)
                min = ie;
            else if (we < ie && we < u)
                min = we;
            else
                min = u;

            Console.WriteLine($"{min} {max}");
        }
    }
}