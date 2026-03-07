namespace ConsoleAppode
{
 class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String[] arr = Console.ReadLine().Split(' ');
            int odd = 0, even = 0, negative = 0, positive = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(arr[i]);
                if (x % 2 == 0)
                    even++;

                else

                    odd++;

                if (x > 0)

                    positive++;

                if (x < 0)

                    negative++;


            }
            Console.WriteLine($"Even: " + even);
            Console.WriteLine($"Odd: " + odd);
            Console.WriteLine($"Positive: " + positive);
            Console.WriteLine($"Negative: " + negative);


        }
    }
}
