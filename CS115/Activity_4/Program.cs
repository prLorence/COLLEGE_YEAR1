using System;

namespace Activity_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // create a calculator using if statement

            // user input for the first value
            Console.Write("Num1: ");
            int firstVal = Convert.ToInt32(Console.ReadLine());

            // user input for the second value
            Console.Write("Num2: ");
            int secondVal = Convert.ToInt32(Console.ReadLine());

            // user input for the operation
            Console.Write("Operation (+,-,*,/,%): ");
            char operation = Console.ReadLine()[0];

            Console.WriteLine("----------");

            // operations for the two values
            int addition = firstVal + secondVal;
            int subtraction = firstVal - secondVal;
            int multiplication = firstVal * secondVal;
            int division = firstVal / secondVal;
            int modulo = firstVal % secondVal;

            // calculator function

            if (operation == '+')
            {
                Console.WriteLine("Addition");
                Console.WriteLine(firstVal + " " + "+" + " " + secondVal + " " + "=" + " " + addition);
            } 
            else if (operation == '-')
            {
                Console.WriteLine("Subtraction");
                Console.WriteLine(firstVal + " " + "-" + " " + secondVal + " " + "=" + " " + subtraction);
            }
            else if (operation == '*')
            {
                Console.WriteLine("Multiplication");
                Console.WriteLine(firstVal + " " + "*" + " " + secondVal + " " + "=" + " " + multiplication);
            }
            else if (operation == '/')
            {
                Console.WriteLine("Division");
                Console.WriteLine(firstVal + " " + "/" + " " + secondVal + " " + "=" + " " + division);
            }
            else if (operation == '%')
            {
                Console.WriteLine("Modulo");
                Console.WriteLine(firstVal + " " + "%" + " " + secondVal + " " + "=" + " " + modulo);
            }
            else
            {
                Console.WriteLine("Invalid Input !!!");
            }


            Console.ReadLine();
        }
    }
}
