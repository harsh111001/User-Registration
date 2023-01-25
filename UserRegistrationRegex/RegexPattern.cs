using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using UserRegisteration;

namespace UserRegistrationRegex
{
    public class RegexPattern
    {
        public static string FirstNamePattern = "^[A-Z][a-z]{2,}$";
        public static string LastNamePattern = "^[A-Z][a-z]{2,}$";
        public static string EmailPattern="^\\S+(\\.\\S+)?@\\S+\\.\\S+(\\.\\S+)?";
        public static string PhoneNumberPattern = "^[0-9][0-9]\\s[0-9]{10}$";
        public static string PasswordPattern = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public static bool ValidateFirstName(string firstName)
        {
            bool res= Regex.IsMatch(firstName, FirstNamePattern);
            if (!res) 
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "not a valid entry");
            }
            else
            {
                return true;
            }
            //return Regex.IsMatch(firstName, FirstNamePattern);
        }
        public static bool ValidateLastName(string lastName)
        {
            bool res = Regex.IsMatch(lastName, LastNamePattern);
            if (!res)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "not a valid entry");
            }
            else
            {
                return true;
            }
            //return Regex.IsMatch(lastName, LastNamePattern);
        }
        public static bool ValidateEmail(string email)
        {
            bool res = Regex.IsMatch(email, EmailPattern);
            if (!res)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "not a valid entry");
            }
            else
            {
                return true;
            }
            //return Regex.IsMatch(email, EmailPattern);
        }
        public static bool ValidatephoneNumber(string phoneNumber)
        {
            bool res = Regex.IsMatch(phoneNumber, PhoneNumberPattern);
            if (!res)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "not a valid entry");
            }
            else
            {
                return true;
            }
            //return Regex.IsMatch(phoneNumber, PhoneNumberPattern);
        }
        public static bool ValidatePassword(string password)
        {
            bool res = Regex.IsMatch(password, PasswordPattern);
            if (!res)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "not a valid entry");
            }
            else
            {
                return true;
            }
            //return Regex.IsMatch(password, PasswordPattern);
        }
    }
}
