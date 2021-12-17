using System;

namespace Activity_8
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Login Attempt #"+i);
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Passowrd: ");
                string password = Console.ReadLine();

                if (username.Equals("abc") & password.Equals("1234"))
                {
                    Console.WriteLine("Result: Successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Result: Failed !!!");
                    Console.WriteLine("----------------------");
                }

                if (i == 3)
                {
                    Console.WriteLine("MAX Attempts Reached. Try again next time");
                }

            }

            Console.ReadLine();


        }
    }
}
