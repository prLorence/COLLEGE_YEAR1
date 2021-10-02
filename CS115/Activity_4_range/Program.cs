using System;

namespace Activity_4_range
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput >= 1 & userInput <= 4 | userInput >= 21 & userInput <= 24 | userInput >= 41 & userInput <= 44)
                {
                    if (userInput % 2 == 0)
                    {
                        Console.WriteLine("AAA");

                    }
                    else
                    {
                        Console.WriteLine("BBB");
                    }
                }

                else if (userInput >= 11 & userInput <= 14 | userInput >= 31 & userInput <= 34 | userInput >= 51 & userInput <= 54)
                {
                    if (userInput % 2 == 0)
                    {
                        Console.WriteLine("CCC");
                    }
                    else
                    {
                        Console.WriteLine("DDD");
                    }
                }

                else if (userInput % 5 == 0)
                {
                    Console.WriteLine("EEE");
                }

                else
                {
                    Console.WriteLine("FFF");
                }

                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
