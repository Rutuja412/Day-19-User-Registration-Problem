using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_1_FirstName
{
    internal class Pattern
    {
        //uc1-FirstNAME
        public static string FIRSTNAME = ("^[A-Z]{1,} [a-z]{2,}$");
        public bool validate_FirstName(string firstName)
        {
            return Regex.IsMatch(FIRSTNAME, firstName);

        }

    }
}
