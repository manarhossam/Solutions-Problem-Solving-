using System;
namespace solutions_codeforces
{
    
    class Program
    {
        static void Main()
        {
            char m =char.Parse( Console.ReadLine());
            if(m>='a'&&  m<= 'z')
                Console.WriteLine((char) (m-32));
            else Console.WriteLine((char)( m-32));

        }
    }
}