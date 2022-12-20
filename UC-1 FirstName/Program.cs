using System;

namespace UC_1_FirstName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Pattern p = new Pattern();
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            bool name = p.validate_FirstName(firstName);
            if (name)
            {
                Console.WriteLine("Correct");

            }
            else
            {
                Console.WriteLine("Not Matching");
            }

        }
    }
}
