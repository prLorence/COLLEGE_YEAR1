using System;

namespace Activity_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // user enters value and then stored to variable
            Console.Write("Num1: ");
            int firstVal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Num2: ");
            int secondVal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Operation (+,-,*,/,%): ");
            char operate = Console.ReadLine()[0];

            Console.WriteLine("----------");

            // calculator function
            switch (operate)
            {
                case '+':
                    Console.WriteLine("Addition");
                    Console.WriteLine(firstVal + " " + "+" + " " + secondVal + " " + "=" + " " + (firstVal + secondVal));
                    break;
                case '-':
                    Console.WriteLine("Subtraction");
                    Console.WriteLine(firstVal + " " + "-" + " " + secondVal + " " + "=" + " " + (firstVal - secondVal));
                    break;
                case '*':
                    Console.WriteLine("Multiplication");
                    Console.WriteLine(firstVal + " " + "*" + " " + secondVal + " " + "=" + " " + (firstVal * secondVal));
                    break;
                case '/':
                    Console.WriteLine("Division");
                    Console.WriteLine(firstVal + " " + "/" + " " + secondVal + " " + "=" + " " + (firstVal / secondVal));
                    break;
                case '%':
                    Console.WriteLine("Modulo");
                    Console.WriteLine(firstVal + " " + "%" + " " + secondVal + " " + "=" + " " + (firstVal % secondVal));
                    break;
                default:
                    Console.WriteLine("Invalid Input !!!");
                    break;

            }

            Console.ReadLine();
            
        }
    }
}


