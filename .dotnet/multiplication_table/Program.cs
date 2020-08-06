using System;

namespace multiplication_table
{
    class Program
        {
            static void Main()
            {
                int no;

                Console.WriteLine("Multiplication Table :");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("\n");

                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write("{0,6}", i * j);
                    }
                }
                Console.Read();
            }
        }
}