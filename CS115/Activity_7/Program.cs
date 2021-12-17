using System;

namespace Activity_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter start number: ");
            int startNum = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter increment number: ");
            int incrementVal = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter loop count: ");
            int loopVal = Convert.ToInt32(Console.ReadLine());

           

            for (int i = 1; i <= loopVal; i++) 
            { 
                Console.WriteLine("Loop#" + i + ": " + startNum);
                startNum += incrementVal;
            }


            Console.ReadLine();
        }
    }
}


