using System.Text.RegularExpressions;
namespace UserRegistrationRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //string EmailPattern = "^\\S+(\\.\\S+)?@\\S+\\.\\S+(\\.\\S+)?";
            //string email = "abc@bl.co";
            //if (Regex.IsMatch(email,EmailPattern))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            User user= new User();
            user.takedata();

        }
    }
}