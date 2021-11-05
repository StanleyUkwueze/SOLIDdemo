using System;
using System.Collections.Generic;
using APPLIB.Services.DTOs;
using APPLIB.Services.Interfaces;
using APPModels.Models;

namespace APPLIB.Services.Imlementations
{
    public class StaffServices : IPriviledgedUsers
    {
        public StaffServices()
        {
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();  // only staff will be fetched
        }

        public bool OpenDoor(string IdCard)
        {
            // codes to use id card and generate security details
            Console.WriteLine("Openning staff room door...");
            Console.WriteLine("Openning student room door...");
            return true;
        }

        public bool Register(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
