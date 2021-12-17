using System;

namespace Activity_6_For_
{
    class Program
    {
        static void Main(string[] args)
        {
            // first three numbers declaration
            
            int firstNum = 10;
            int secondNum = 2;
            int thirdNum = 5;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Loop#" + i + ": " + firstNum + ", " + secondNum + ", " + thirdNum);

                firstNum -= 1;
                secondNum += 2;
                thirdNum *= 2;
            }

            Console.ReadLine();
        }
    }
}


