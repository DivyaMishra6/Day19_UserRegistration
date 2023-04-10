using Day19_UserRegistration;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Page!!");

            Console.WriteLine("********************************");
            UserRegistrationCodeUC1 obj = new UserRegistrationCodeUC1 ();
            Console.WriteLine("Enter the First Name:");
            string FName = Console.ReadLine();
            Console.WriteLine(obj.ValidateFName(FName));
        }

    }
}

