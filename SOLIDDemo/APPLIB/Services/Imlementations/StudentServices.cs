using System;
using System.Collections.Generic;
using APPLIB.Services.DTOs;
using APPLIB.Services.Interfaces;
using APPModels.Models;

namespace APPLIB.Services.Imlementations
{
    public class StudentServices : IPriviledgedUsers
    {
        public StudentServices()
        {
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();  // only students will be fetched
        }

        public bool OpenDoor(string IdCard)
        {
            // codes to use id card and generate security details
            Console.WriteLine("Openning hostel door...");
            return true;
        }

        public bool Register(UserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
