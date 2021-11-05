using System;
using System.Collections.Generic;
using System.Threading;
using APPDataAccess.Repositories.InMemoryImplementation.Interface;
using APPLIB.Services.DTOs;
using APPLIB.Services.Interfaces;
using APPModels.Models;

namespace APPLIB.Services.Imlementations
{
    public class UserServices : IUser
    {
        private readonly IUserRepository _userRepo;
        public UserServices(IUserRepository userRepository)
        {
            _userRepo = userRepository; // Coupling: [Collaborative] 'uses a'
        }

        public bool Register(UserDto model)
        {
            var id = Guid.NewGuid().ToString();

            #region commented
            //var idCard = new IdCard();
            //idCard.UserId =  id;
            //idCard.Title = model.IdCard.Title;
            #endregion

            var user = new User(id, model.Name, null, model.UserType);
            Console.WriteLine("Registering user...");
            Thread.Sleep(1000);

            if(_userRepo.Add(user))
                return true;

            return false;
        }

        public List<User> GetUsers()
        {
            Console.WriteLine("Fetching users...");   // all users will be fetched
            Thread.Sleep(1000);

            var users = _userRepo.SelectUsers();

            return users;
        }
    }
}
