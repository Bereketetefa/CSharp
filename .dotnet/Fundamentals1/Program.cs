using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100 - 1; i >= 0; i--)
            {
                if (i%3==0)
                    Console.WriteLine("fizz" + "");
                
                else if(i%5==0)
                    Console.WriteLine("fizzbuzz" + "");

                else if (i % 5 == 0)                                              
                    Console.Write("Buzz" + ""); 
                    {
                        Console.Write(i + " "); 
                }
            }
        }
    }
}