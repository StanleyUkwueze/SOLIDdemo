using System;
using System.Collections.Generic;
using APPLIB.Services.DTOs;
using APPModels.Models;

namespace APPLIB.Services.Interfaces
{
    public interface IUser
    {
        public bool Register(UserDto model);
        public List<User> GetUsers();
    }
}
