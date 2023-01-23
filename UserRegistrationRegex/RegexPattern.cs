using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            return Regex.IsMatch(firstName, FirstNamePattern);
        }
        public static bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, LastNamePattern);
        }
        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EmailPattern);
        }
        public static bool ValidatephoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, PhoneNumberPattern);
        }
        public static bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PasswordPattern);
        }
    }
}
