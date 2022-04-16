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
        private static string REGEX_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        private static string REGEX_MOBILENUMBER = "^[1-9]{1,3}[ ][1-9][0-9]{9}$";
        //private static string REGEX_PASSWORD = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$"; //Rule 1 minimum 8 characters
        private static string REGEX_PASSWORD = "^(?=.*[A-Z])[A-Za-z0-9!@#$%^&*]{8,}$"; //Rule 2 should have at least 1 Upper Case

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

        //Method to test Email ID
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }

        //Method to test Mobile Number
        public bool ValidateMobileNumber(string mobNumber)
        {
            return Regex.IsMatch(mobNumber, REGEX_MOBILENUMBER);
        }

        //Method to test Password
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
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
