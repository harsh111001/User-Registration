using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class User
    {
        public string firstname;
        public string lastname;
        public string email;
        public string password;
        public string phonenumber;
        public bool vc;
        public void takeFirstname()
        {
            do
            {
                Console.WriteLine("Enter First Name : ");
                this.firstname = Console.ReadLine();
                vc=RegexPattern.ValidateFirstName(this.firstname);
                displayOutput("FirstName");
            }while(!vc);
        }
        public void takeLastname()
        {
            do
            {
                Console.WriteLine("Enter Last Name : ");
                this.lastname = Console.ReadLine();
                vc = RegexPattern.ValidateLastName(this.lastname);
                displayOutput("LastName");
            } while (!vc);
        }
        public void takeEmail()
        {
            do
            {
                Console.WriteLine("Enter Email : ");
                this.email = Console.ReadLine();
                vc = RegexPattern.ValidateEmail(this.email);
                displayOutput("Email");
            } while (!vc);
        }
        public void takePhoneNumber()
        {
            do
            {
                Console.WriteLine("Enter Phone Number : ");
                this.phonenumber = Console.ReadLine();
                vc = RegexPattern.ValidatephoneNumber(this.phonenumber);
                displayOutput("PhoneNumber");
            } while (!vc);
        }
        public void takePassword()
        {
            do
            {
                Console.WriteLine("Enter Password : ");
                this.password = Console.ReadLine();
                vc = RegexPattern.ValidatePassword(this.password);
                displayOutput("Password");
            } while (!vc);
        }
        public void takedata()
        {
            Console.WriteLine("enter data for registration");
            takeFirstname();
            takeLastname();
            takeEmail();
            takePhoneNumber();
            takePassword();

        }
        public void displayOutput(string option)
        {
            if (vc)
            {
                Console.WriteLine("the input satisfies all rules");
            }
            else
            {
                printrules(option);
            }
        }
        public void printrules(string option)
        {
            switch(option)
            {
                case "FirstName":
                    Console.WriteLine("wrong input");
                    Console.WriteLine("first character should be capital");
                    Console.WriteLine("should contain atleast 3 charcters");
                    break;
                case "LastName":
                    Console.WriteLine("wrong input");
                    Console.WriteLine("first character should be capital");
                    Console.WriteLine("should contain atleast 3 charcters");
                    break;
                case "Email":
                    Console.WriteLine("wrong input");
                    Console.WriteLine("E.g. abc.xyz@bl.co.in");
                    Console.WriteLine("Email has 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions");
                    break;
                case "PhoneNumber":
                    Console.WriteLine("wrong input");
                    Console.WriteLine("Mobile Format - E.g. 91 9919819801");
                    Console.WriteLine("Country code follow by space and 10 digit number");
                    break;
                case "Password":
                    Console.WriteLine("wrong input");
                    Console.WriteLine("minimum 8 Characters");
                    Console.WriteLine("Atleast 1 uppercase letter");
                    Console.WriteLine("Atleast 1 numeric number");
                    Console.WriteLine("Exactly 1 special character");
                    break;
            }
        }
    }
}
