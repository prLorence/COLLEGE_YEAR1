using System;

namespace Activity_6_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int firstNum = 10;
            int secondNum = 2;
            int thirdNum = 5;


            while (i <= 10)
            {
                Console.WriteLine("Loop#" + i + ": " + firstNum +", " + secondNum +", " + thirdNum);

                firstNum -= 1;
                secondNum += 2;
                thirdNum *= 2;

                i++;
            }

            Console.ReadLine();
        }
    }
}

