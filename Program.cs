using Day19_UserRegistration;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Page!!");

            Console.WriteLine("Welcome to User Registration Page!!");
            Console.WriteLine("********************************");
            ValidEmailUC3 obj = new ValidEmailUC3();
            Console.WriteLine("Enter the First Name:");
            string FName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name:");
            string LName = Console.ReadLine();
            Console.WriteLine("Enter your Email Id:");
            string MailId = Console.ReadLine();

            Console.WriteLine(obj.ValidateFName(FName));
            Console.WriteLine(obj.ValidateFName(LName));
            Console.WriteLine(obj.ValidateEmail(MailId));
        }

    }
}

