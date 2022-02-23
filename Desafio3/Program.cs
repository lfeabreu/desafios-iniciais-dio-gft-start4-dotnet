using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while(x > 0)
            {
                //se x for impar, incrementar 1
                if((x % 2) == 1)
                {
                    x++;
                }
                int soma5ParesSeguintes = 0;
                for( int i = 0 ; i < 5 ; i++ )
                {
                    soma5ParesSeguintes = soma5ParesSeguintes + (x + (2 * i));
                }
                Console.WriteLine($"{soma5ParesSeguintes}");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
