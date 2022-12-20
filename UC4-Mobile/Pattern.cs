using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC4_Mobile
{
    internal class Pattern
    {
        //uc1-FirstNAME
        public static string FIRSTNAME = ("^[A-Z]{1,} [a-z]{2,}$");
        public bool validate_FirstName(string firstName)
        {
            return Regex.IsMatch(FIRSTNAME, firstName);

        }

        //UC2
        public static string LASTNAME = ("^[A-Z]{1}[a-z]{2,}$");
        public bool validate_LastName(string lastName)
        {
            return Regex.IsMatch(lastName, LASTNAME);
        }

        //UC3
        public static string EMAILID = ("^[a-zA-Z0-9]+ ([._-][a-zA-Z0-9]+)* @ [a-z]+ ([.][a-z])* ([.][a-z]+)$");
        public bool validate_EmailId(string emailId)
        {
            return Regex.IsMatch(EMAILID, emailId);
        }

        //UC4==MOBILE
        public static string MOBILENUM = ("^[0-9]{2}[ ][6-9]{1}[0-9]{9}$");

        public bool validate_MobileNum(string mobileNum)
        {
            return Regex.IsMatch(mobileNum, MOBILENUM);
        }

    }
}
