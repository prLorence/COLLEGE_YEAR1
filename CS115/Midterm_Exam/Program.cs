using System;

namespace Midterm_Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---Midterm Exam Part 1---");
            int firstPartOutput = 2;

            for (int i = 1; i <= 25; i++)
            {
                Console.Write(firstPartOutput + ",\t");
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                };

                firstPartOutput += 2;
            }
         
            Console.WriteLine("---Midterm Exam Part 2---");
            int secondPartOutput = 100;

            for (int i = 1; i <= 25; i++)
            {
                Console.Write(secondPartOutput + ",\t");
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                };

                // secondPartOutput += 2;
                secondPartOutput -= 5;
            }

            Console.WriteLine("---Midterm Exam Part 3---");
            int thirdPartOutput = 1;
            int incrementor = 1;

            for (int i = 1; i <= 25; i++)
            {
                Console.Write(thirdPartOutput + ",\t");
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                    incrementor++;
                };

                thirdPartOutput += incrementor;
            }

            Console.WriteLine("---Midterm Exam Part 4---");
            int fourthPartOutput = 2;
            int increment = 2;

            for (int i = 1; i <= 25; i++)
            {
                Console.Write(fourthPartOutput + ",\t");
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                    fourthPartOutput = 2;
                    increment++;
                };

                fourthPartOutput *= increment;
            }


            Console.ReadLine();
        }
    }
}
