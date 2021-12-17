using System;

namespace Activity_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------A--------------------");
            // counter for grid a
            int counterA = 1; 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(counterA + "\t");
                    counterA++;
                }
            Console.WriteLine();
            }
            Console.WriteLine("--------------------B--------------------");
            // counter for grid b
            int counterB = 1; 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(counterB + "\t");
                    if (i % 2 == 0)
                    {
                        counterB--;
                    }
                    else
                    {
                        counterB++;
                    }
                }
                Console.WriteLine();
                if (i % 2 == 0)
                {
                    counterB += 6;
                }
                else
                {
                    counterB += 4;
                }
            }
            Console.WriteLine("--------------------C--------------------");
            // counter for grid c
            int counterC = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(counterC + "\t");
                    counterC += 5;
                }
                Console.WriteLine();
                counterC -= 24;
            }
            Console.WriteLine("--------------------D--------------------");
            // counter for grid d
            int counterD = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(counterD + "\t");
                    if (j % 2 == 1)
                    {
                        counterD += 9;
                    }
                    else
                    {
                        counterD++;
                    }
                }
                Console.WriteLine();
                counterD -= 28;
            }
            Console.WriteLine("--------------------E--------------------");
            // counter for grid e
            int counterE = 25; 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(counterE + "\t");
                    counterE--;
                }
            Console.WriteLine();
            }
            Console.WriteLine("--------------------F--------------------");
            // counter for grid b
            int counterF = 25; 
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(counterF + "\t");
                    if (i % 2 == 0)
                    {
                        counterF++;
                    }
                    else
                    {
                        counterF--;
                    }
                }
                Console.WriteLine();
                if (i % 2 == 0)
                {
                    counterF -= 6;
                }
                else
                {
                    counterF -= 4;
                }
            }
            Console.WriteLine("--------------------G--------------------");
            // counter for grid g
            int counterG = 25;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(counterG + "\t");
                    counterG -= 5;
                }
                Console.WriteLine();
                counterG += 24;
            }
            Console.WriteLine("--------------------H--------------------");
            // counter for grid Hhttps://lh3.googleusercontent.com/gdI8alO1xFRe1XnsxVqeW-Jqno6H_EQJAyu-qDAEwsRvY_HDiZIlNex1bwrQgSU_V3sBBn_ioXcFZxs=w1335-h995
            int counterH = 25;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(counterH + "\t");
                    if (j % 2 == 1)
                    {
                        counterH -= 9;
                    }
                    else
                    {
                        counterH--;
                    }
                }
                Console.WriteLine();
                counterH += 28;
            }
            Console.ReadLine();
        }
    }
}
