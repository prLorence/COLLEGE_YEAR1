using System;

namespace Activity_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // variable declaration
            string midName = "Doe";
            char midInit = midName[0];
            int firstVal = 20;
            int secondVal = 6;

            // variable operations
            int addVal = firstVal + secondVal;
            int subtractVal = firstVal - secondVal;
            int multiplyVal = firstVal  * secondVal;
            int divideVal = firstVal / secondVal;
            int moduloVal = firstVal % secondVal;
            
            // display variable values
            Console.WriteLine("Enter Middle Name: " + midName);
            Console.WriteLine("Middle Initial: " + midInit);
            Console.WriteLine("Enter Number 1: " + firstVal);
            Console.WriteLine("Enter Number 2: " + secondVal);

            // display firstVal and secondVal operation results 
            Console.WriteLine("Addition: " + firstVal + " " + "+" + " " + secondVal + " " + "=" + " " + addVal);

            Console.WriteLine("Subtraction: " + firstVal + " " + "-" + " " + secondVal + " " + "=" + " " + subtractVal);

            Console.WriteLine("Multipilication: " + firstVal + " " + "*" + " " + secondVal + " " + "=" + " " + multiplyVal);

            Console.WriteLine("Division: " + firstVal + " " + "/" + " " + secondVal + " " + "=" + " " + divideVal);

            Console.WriteLine("Modulo/Quotient: " + firstVal + " " + "%" + " " + secondVal + " " + "=" + " " + moduloVal);

            Console.ReadLine();
        }
    }
}
