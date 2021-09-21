using System;

namespace Prelim_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // menu variable

            string firstItem = "Pizza";
            string secondItem = "Burger";
            string thirdItem = "Fries";


            // create menu selection program using nested if statements

            Console.WriteLine("---MENU---");

            // write user food options

            Console.WriteLine("1. " + firstItem);
            Console.WriteLine("2. " + secondItem);
            Console.WriteLine("3. " + thirdItem);

            // user food input

            Console.Write("Menu choice: ");
            int menuInput = Convert.ToInt32(Console.ReadLine());


            // menu function
            // display variants depending on user input

            // pizza
            if (menuInput == 1)
            {
                Console.WriteLine("---Variants---");
                Console.WriteLine("1. Cheese");
                Console.WriteLine("2. Pepperoni");
                Console.WriteLine("3. Hawaiian");

                // ask the user for variant
                Console.Write("Variant choice: ");
                int variantInput = Convert.ToInt32(Console.ReadLine());

                if (variantInput == 1)
                {
                    Console.WriteLine("Cheese " + firstItem);
                }
                else if (variantInput == 2)
                {
                    Console.WriteLine("Pepperoni " + firstItem);
                }
                else if (variantInput == 3)
                {
                    Console.WriteLine("Hawaiian " + firstItem);
                }
                else
                {
                    Console.WriteLine("Invalid Pizza Variant");
                }

            }

            // burger
            if (menuInput == 2)
            {
                Console.WriteLine("---Variants---");
                Console.WriteLine("1. TLC");
                Console.WriteLine("2. Double Patty");
                Console.WriteLine("3. Cheese");

                // ask the user for variant
                Console.Write("Variant choice: ");
                int variantInput = Convert.ToInt32(Console.ReadLine());

                if (variantInput == 1)
                {
                    Console.WriteLine("TLC " + secondItem);
                }
                else if (variantInput == 2)
                {
                    Console.WriteLine("Double Patty " + secondItem);
                }
                else if (variantInput == 3)
                {
                    Console.WriteLine("Cheese " + secondItem);
                }
                else
                {
                    Console.WriteLine("Invalid Burger Variant");
                }
            }

            // fries
            if (menuInput == 3)
            {
                Console.WriteLine("---Variants---");
                Console.WriteLine("1. BBQ");
                Console.WriteLine("2. Cheese");
                Console.WriteLine("3. Salt");

                // ask the user for variant
                Console.Write("Variant choice: ");
                int variantInput = Convert.ToInt32(Console.ReadLine());

                if (variantInput == 1)
                {
                    Console.WriteLine("BBQ " + thirdItem);
                }
                else if (variantInput == 2)
                {
                    Console.WriteLine("Cheese " + thirdItem);
                }
                else if (variantInput == 3)
                {
                    Console.WriteLine("Salt " + thirdItem);
                }
                else
                {
                    Console.WriteLine("Invalid Fries Variant");
                }
            }

            // invalid user input
            else
            {
                Console.WriteLine("Invalid Menu Choice");
            }


            Console.ReadLine();
        }
    }
}
