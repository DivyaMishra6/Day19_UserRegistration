﻿using Day19_UserRegistration;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Page!!");

            Console.WriteLine("********************************");
            PasswordRule1UC5 obj = new PasswordRule1UC5();
            Console.WriteLine("Enter the First Name:");
            string FName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name:");
            string LName = Console.ReadLine();
            Console.WriteLine("Enter your Email Id:");
            string MailId = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number:");
            string MobNum = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            Console.WriteLine(obj.ValidateFName(FName));
            Console.WriteLine(obj.ValidateFName(LName));
            Console.WriteLine(obj.ValidateEmail(MailId));
            Console.WriteLine(obj.ValidateMobNum(MobNum));
            Console.WriteLine(obj.ValidatePassword(password));
        }

    }
}

