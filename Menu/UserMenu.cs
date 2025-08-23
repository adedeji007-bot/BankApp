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
        private void UpdateProfile()
        {
            
            var currentUser = UserDb.UserDatabase.FirstOrDefault(u => u.Id == User.LoggedInUserId);

            if (currentUser == null)
            {
                Console.WriteLine("⚠️ User not found.");
                return;
            }

            Console.WriteLine("\n--- Update Profile ---");
            Console.WriteLine("Press Enter without typing anything to keep the current value.\n");

            Console.Write($"New Firstname ({currentUser.Firstname}): ");
            string newFirstname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newFirstname)) newFirstname = currentUser.Firstname;

            Console.Write($"New Lastname ({currentUser.Lastname}): ");
            string newLastname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newLastname)) newLastname = currentUser.Lastname;

            Console.Write($"New Email ({currentUser.Email}): ");
            string newEmail = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newEmail)) newEmail = currentUser.Email;

            var updated = userManager.UpdateProfile(
                User.LoggedInUserId,
                newFirstname,
                newLastname,
                newEmail
            );

            if (updated != null)
            {
                Console.WriteLine("\n✅ Profile updated successfully!");
            }
            else
            {
                Console.WriteLine("\n⚠️ Update failed. User not found.");
            }
        }

    }
}