﻿using System;

namespace UC2_LastName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Pattern p = new Pattern();
            //UC1
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

            //UC2
            Console.WriteLine("Enter last name ");
            string lastName = Console.ReadLine();
            bool Lname = p.validate_LastName(lastName);
            if (Lname)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Not matching");
            }


        }
    }
}
