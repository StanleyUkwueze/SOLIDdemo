
using System;
using APPLIB.Services.Interfaces;

namespace APPClient
{
    public class Account
    {
        private readonly IUser _userRepo;

        public Account(IUser userRepo)
        {
            _userRepo = userRepo;
        }

        public void RegisterNewAccount()
        {
            // ask user for his/her details and construct the dto
            int choice = 1;
            while (choice == 1){
                Console.WriteLine("Please enter your details below.");
                Console.WriteLine("--------------------------");

                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();

                Console.WriteLine("What user type are you registering as?");
                string userType = Console.ReadLine();

                var res = _userRepo.Register(new APPLIB.Services.DTOs.UserDto { Name = name, UserType = userType });

                if (res)
                    Console.WriteLine("Added new user successfully!");
                else
                    Console.WriteLine("Operation to add new user failed!");

                Console.WriteLine("\nWould you like to continue?");
                choice = int.Parse(Console.ReadLine());
            }

        }

        public void DisplayAccountDetails()
        {
            var users = _userRepo.GetUsers();

            if (users.Equals(null))
                Console.WriteLine("No record was found for users!");
            else
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"Id: { user.Id }");
                    Console.WriteLine("--------------------------------------------------");

                    Console.WriteLine($"Name: { user.Name }");
                    Console.WriteLine("--------------------------------------------------");

                    Console.WriteLine($"Type: { user.UserType }");
                    Console.WriteLine("--------------------------------------------------");

                    //Console.WriteLine($"Doors: { user.OpenDoor(null) }");
                    //Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
