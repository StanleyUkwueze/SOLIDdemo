using System;
using System.Collections.Generic;
using APPLIB;

namespace APPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate global config
            GlobalConfig.Instantiate();

            var acc = new Account(GlobalConfig.UserInstance);



            // Test to register new user
            acc.RegisterNewAccount();

            Console.WriteLine("\n\n");

            // Test to view new user details
            acc.DisplayAccountDetails();

        }

    }
}
