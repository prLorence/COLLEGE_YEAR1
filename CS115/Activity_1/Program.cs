using System;

namespace Activity_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputInfo = "---Input Information---";
            String displayInfo = "---Display Information---";
            String endSession = "---END---";

            Console.WriteLine(inputInfo);

            Console.Write("Firstname: ");
            String firstName = Console.ReadLine();

            Console.Write("Middle Initial: ");
            String midName = Console.ReadLine();

            Console.Write("Surname: ");
            String surName = Console.ReadLine();

            Console.Write("Gender: ");
            String gender = Console.ReadLine();

            Console.Write("Address: ");
            String address = Console.ReadLine();

            Console.Write("Birth Month: ");
            String birthMonth = Console.ReadLine();

            Console.Write("Birth Day: ");
            String birthDay = Console.ReadLine();

            Console.Write("Birth Year: ");
            String birthYear = Console.ReadLine();

            Console.Write("Age: ");
            String age = Console.ReadLine();

            Console.Write("Contact #: ");
            String contactNo = Console.ReadLine();

            Console.WriteLine(displayInfo);


            Console.WriteLine("Fullname: " + surName + "," + " " + firstName + " " + midName + ".");
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Birthdate: " + birthMonth + " " + birthDay + "," + " " + birthYear);
            Console.WriteLine("Age: " + age + " " + "years old");
            Console.WriteLine("Contact #: " + contactNo);
            Console.WriteLine("Address: " + address);



            Console.WriteLine(endSession);

            Console.ReadLine();

      
        }
    }
}
