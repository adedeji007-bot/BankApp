using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp.Entities;
using BankApp.Manager;

namespace BankApp.Menu
{
    public class UserMenu
    {
        private readonly UserManager userManager = new UserManager();

        public void Show()
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("\n==== User Menu ====");
                Console.WriteLine("1. View Profile");
                Console.WriteLine("2. Update Profile");
                Console.WriteLine("3. Logout");

                Console.Write("Choose option: ");
                string input = Console.ReadLine();
                int opt;
                if (!int.TryParse(input, out opt))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (opt)
                {
                    case 1:
                        ViewProfile();
                        break;

                    case 2:
                        UpdateProfile();
                        break;

                    case 3:
                        cont = false;
                        Console.WriteLine("Logging out...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
        private void UpdateProfile()
        {
            Console.Write("New Firstname: ");
            string newFirstname = Console.ReadLine() ?? "";

            Console.Write("New Lastname: ");
            string newLastname = Console.ReadLine() ?? "";

            Console.Write("New Email: ");
            string newEmail = Console.ReadLine() ?? "";

            var updated = userManager.UpdateProfile(User.LoggedInUserId, newFirstname, newLastname, newEmail);
            if (updated != null)
            {
                Console.WriteLine("✅ Profile updated successfully!");
            }
            else
            {
                Console.WriteLine("⚠️ Update failed. User not found.");
            }
        }
    }
}