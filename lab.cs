using System;
namespace Fib
{
    class Program
    {
        static void Main(string[] args)
        {
            int trip = 0;
            int next = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(next);
                if (next == 0)
                {
                    next = 1;
                }
                else
                {
                    int a = next;
                    next = next + trip;
                    trip = a;
                }
            }
            Console.ReadLine();
        }

    }
}