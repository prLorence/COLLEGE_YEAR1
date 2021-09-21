using System;

namespace Prelim_Exam_Switch_
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

            // switch function

            switch (menuInput)
            { 
                // pizza
                case 1:
                    Console.WriteLine("---Variants---");
                    Console.WriteLine("1. Cheese");
                    Console.WriteLine("2. Pepperoni");
                    Console.WriteLine("3. Hawaiian");

                    // user variant input

                    Console.Write("Variant Choice: ");
                    int pizzaVariant = Convert.ToInt32(Console.ReadLine());
                    
                    // pizza variant switch
                    switch (pizzaVariant)
                    {
                        case 1:
                            Console.WriteLine("Cheese " + firstItem);
                            break;
                        case 2:
                            Console.WriteLine("Pepperoni " + firstItem);
                            break;
                        case 3:
                            Console.WriteLine("Hawaiian " + firstItem);
                            break;
                        default:
                            Console.WriteLine("Invalid Pizza Variant");
                            break;
                    }
                break;

                // burger
                case 2:
                    Console.WriteLine("---Variants---");
                    Console.WriteLine("1. TLC");
                    Console.WriteLine("2. Double Patty");
                    Console.WriteLine("3. Cheese");

                    // user variant input

                    Console.Write("Variant Choice: ");
                    int burgerVariant = Convert.ToInt32(Console.ReadLine());

                    // burger variant switch
                    switch (burgerVariant)
                    {
                        case 1:
                            Console.WriteLine("TLC " + secondItem);
                            break;
                        case 2:
                            Console.WriteLine("Double Patty " + secondItem);
                            break;
                        case 3:
                            Console.WriteLine("Cheese " + secondItem);
                            break;
                        default:
                            Console.WriteLine("Invalid Burger Variant");
                            break;
                    }
                    break;
                // fries
                case 3:
                    Console.WriteLine("---Variants---");
                    Console.WriteLine("1. BBQ");
                    Console.WriteLine("2. Cheese");
                    Console.WriteLine("3. Salt");

                    // user variant input

                    Console.Write("Variant Choice: ");
                    int friesVariant = Convert.ToInt32(Console.ReadLine());

                    // burger variant switch
                    switch (friesVariant)
                    {
                        case 1:
                            Console.WriteLine("BBQ " + thirdItem);
                            break;
                        case 2:
                            Console.WriteLine("Cheese " + thirdItem);
                            break;
                        case 3:
                            Console.WriteLine("Salt " + thirdItem);
                            break;
                        default:
                            Console.WriteLine("Invalid Fries Variant");
                            break;
                    }
                    break;


                default:
                    Console.WriteLine("Invalid Menu Choice");
                    break;
            }


            Console.ReadLine();

        }
    }
}