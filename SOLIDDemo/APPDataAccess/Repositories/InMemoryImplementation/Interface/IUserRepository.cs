using System;
using System.Collections.Generic;
using APPModels.Models;

namespace APPDataAccess.Repositories.InMemoryImplementation.Interface
{
    public interface IUserRepository : ICRUDRepository
    {
        User SelectUser(string Id);
        List<User> SelectUsers();
    }
}
