using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegisterationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("=-=-=-=-=-=-=-=Welcome To the User Registration Problem=-=-=-=-=-=-=-=");
            Console.WriteLine("----------------------------------------------------------------------");

            //object created
            UserRegistrationValidation validate = new UserRegistrationValidation();

            Console.WriteLine("Enter First Name : ");
            string firstName = Console.ReadLine();
            bool fNameResult = validate.ValidateFirstName(firstName);
            validate.PrintResult(fNameResult);


            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter Last Name : ");
            string lastName = Console.ReadLine();
            bool lNameResult = validate.ValidateLastName(lastName);
            validate.PrintResult(lNameResult);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter Email Id : ");
            string email = Console.ReadLine();
            bool emailResult = validate.ValidateEmail(email);
            validate.PrintResult(emailResult);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter Mobile Number : ");
            string mobNumber = Console.ReadLine();
            bool mobNumberResult = validate.ValidateMobileNumber(mobNumber);
            validate.PrintResult(mobNumberResult);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter Password : ");
            string password = Console.ReadLine();
            bool passwordResult = validate.ValidatePassword(password);
            validate.PrintResult(passwordResult);

            Console.WriteLine("--------------------------------------");

            Console.ReadLine();
        }
    }
}
