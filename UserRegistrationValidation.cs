using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegisterationProblem
{
    class UserRegistrationValidation
    {
        private static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        private static string REGEX_LASTNAME = "^[A-Z][a-z]{2,}$";

        //Method to test first name
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }

        //Method to test last name
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }
        //To print the result
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}
