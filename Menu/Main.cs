
using System.Text.RegularExpressions;
using BankApp.Entities;
using BankApp.Manager;

namespace BankApp.Menu
{
    public class Main
    {
        UserManager userManager = new UserManager();
        public void MainMenu()
        {
            bool cont = true;
            while (cont)
            {
                System.Console.WriteLine("Welcome To Our Bank Application");
                System.Console.WriteLine("\nwelcome\npress 1 to register\npress 2 to login\npress 3 to exit");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        RegisterMenu();
                        break;
                    case 2:
                        LoginMenu();
                        break;
                    case 3:
                        cont = false;
                        break;
                    default:
                        System.Console.WriteLine("invalid input");
                        break;
                }

            }
        }
        public void RegisterMenu()
        {
            string firstName;
            do
            {
                Console.Write("firstName:\t");
                firstName = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
                {
                    Console.Beep();
                    Console.WriteLine("firstName is required and must only contain letters and numbers. Please enter a valid username.");
                }
            } while (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName));

            string lastName;
            do
            {
                Console.Write("lastName:\t");
                lastName = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName))
                {
                    Console.Beep();
                    Console.WriteLine("firstName is required and must only contain letters and numbers. Please enter a valid username.");
                }

            } while (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName));

            string pattern = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|yahoo\.com)$";
            string email;
            do
            {
                Console.Write("Email:\t");
                email = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email)
                    || !Regex.IsMatch(email, pattern))
                {
                    Console.Beep();
                    Console.WriteLine("Email is required. Please enter a valid email.");
                }


            } while (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, pattern));

            string password;
            do
            {
                
                Console.WriteLine("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one digit.");
                Console.Write("Password:\t");
                password = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password) ||
                    password.Length < 8 || !password.Any(char.IsLower) || !password.Any(char.IsUpper) || !password.Any(char.IsDigit))
                {
                    Console.Beep();
                    Console.WriteLine("Password is required . Please enter a valid password.");
                }

            } while (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password) ||
            password.Length < 8 || !password.Any(char.IsLower) || !password.Any(char.IsUpper) || !password.Any(char.IsDigit));


            User? user = userManager.Register(firstName, lastName, email, password);

            if (user != null)
            {
                System.Console.WriteLine($"Firstname : {user.Firstname} Lastname: {user.Lastname}");
            }
        }


        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            var user = userManager.Login(email, password);

            if (user == null)
            {
                Console.WriteLine("Invalid Credentials");
                return;
            }
            if (user.Role == "Admin")
            {
                System.Console.WriteLine("welcome sir");

                // System.Console.WriteLine(User.LoggedInUserId);
            }
            else if (user.Role == "Customer")
            {
                // AccountHolderMenu use = new AccountHolderMenu();
                //  use.UserMain();

                System.Console.WriteLine("welcome sir");

                User.LoggedInUserId = user.Id;
            }

        }

    }
}