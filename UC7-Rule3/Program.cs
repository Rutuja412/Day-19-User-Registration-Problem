using System;

namespace UC7_Rule3
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

            //UC3
            Console.WriteLine("Enter EmailId");
            string emailId = Console.ReadLine();
            bool mailId = p.validate_EmailId(emailId);
            if (mailId)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Not Matching");
            }

            //UC4

            Console.WriteLine("Enter Mobile number");
            string mobileNum = Console.ReadLine();
            bool phonenum = p.validate_MobileNum(mobileNum);
            if (phonenum)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Not matched");
            }

            //UC5 = Rule1 password`
            Console.WriteLine("Enter correct password for rule1");
            string passWord = Console.ReadLine();
            bool pass = p.validate_Password(passWord);
            if (pass)
            {
                Console.WriteLine("Password Match");
            }
            else
            {
                Console.WriteLine("Not matched");
            }
            //UC6= Rule 2 password
            Console.WriteLine("Enter Correct password for rule 2 ");
            string passwordRule = Console.ReadLine();
            bool password = p.validate_Password(passwordRule);
            if (password)
            {
                Console.WriteLine("Password Match");

            }
            else
            {
                Console.WriteLine("Not matched");
            }

            //UC7 Rule 3
            Console.WriteLine("Enter correct password for rule3");
            string passwordrule = Console.ReadLine();
            bool passwrd = p.validate_Password(passwordrule);
            if (password)
            {
                Console.WriteLine("Password Match");
            }
            else
            {
                Console.WriteLine("Not matched");
            }
            //UC8 one special chara
            Console.WriteLine("Enter correct password for rule4");
            string finalpassword = Console.ReadLine();
            bool fpassword = p.validate_Password(finalpassword);
            if (password)
            {
                Console.WriteLine("Password Match");
            }
            else
            {
                Console.WriteLine("Not matched");
            }

        }
    }
}
