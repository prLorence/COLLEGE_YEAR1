using System;

namespace Activity_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Triangle A---");
            Console.Write("Enter a number of lines: ");
            int triangleHeightA = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= triangleHeightA; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---Triangle B---");
            Console.Write("Enter a number of lines: ");
            int triangleHeightB = Convert.ToInt32(Console.ReadLine());

            for (int i = triangleHeightB; i >= 1; i--)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write("Y");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---Triangle C---");
            Console.Write("Enter a number of lines (ODD number only): ");
            int triangleHeightC = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i <= triangleHeightC; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("A");
                }
                if (i == 4)
                {
                    Console.WriteLine();
                    break;
                }
                Console.WriteLine();
                counter++;
            }

            for (int k = counter - 1; k >= 0; k--)
            {
                for (int l = 0; l <= k; l++)
                {

                    Console.Write("B");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
