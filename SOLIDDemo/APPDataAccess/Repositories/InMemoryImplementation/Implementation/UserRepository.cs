using System;
using System.Collections.Generic;
using APPDataAccess.Repositories.InMemoryImplementation.Interface;
using APPModels.Models;

namespace APPDataAccess.Repositories.InMemoryImplementation.Implementation
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        public bool Add<T>(T entity)
        {
            int rowCountBefore = this.RowCount();
            var user = entity as User; // convert generic type value to concrete type user
            InMemoryStore.Users.Add(user);
            int rowCountAfter = this.RowCount();

            if (rowCountAfter <= rowCountBefore)
                return false;

            return true;
        }

        public string Delete<T>(T entity)
        {
            int rowCountBefore = this.RowCount();

            if (rowCountBefore < 1)
                return "No record found! Table is empty";

            var user = entity as User; // convert generic type value to concrete type user
            InMemoryStore.Users.Remove(user);
            int rowCountAfter = this.RowCount();

            if (rowCountAfter >= rowCountBefore)
                return "false";

            return "true";
        }

        public int RowCount()
        {
            return InMemoryStore.Users.Count;
        }

        public User SelectUser(string Id)
        {
            int count = InMemoryStore.Users.Count;
            for (int i = 0; i < InMemoryStore.Users.Count; i++)
            {
                if (InMemoryStore.Users[i].Id.Equals(Id))
                {
                    return InMemoryStore.Users[i];
                }

                if (InMemoryStore.Users[count].Id.Equals(Id))
                {
                    return InMemoryStore.Users[count];
                }
                count--;
            }

            return null;
        }

        public List<User> SelectUsers()
        {
            int rowCountBefore = this.RowCount();

            if (rowCountBefore < 1)
                return null;

            return InMemoryStore.Users;
        }

        public string Update<T>(T entity)
        {
            int rowCountBefore = this.RowCount();

            if (rowCountBefore < 1)
                return "No record found! Table is empty";

            var user = entity as User; // convert generic type value to concrete type user

            int count = InMemoryStore.Users.Count;
            for (int i=0; i < InMemoryStore.Users.Count; i++)
            {
                if(InMemoryStore.Users[i].Equals(user))
                {
                    InMemoryStore.Users[i].Name = user.Name;
                    InMemoryStore.Users[i].UserType = user.UserType;
                    return "true";
                }

                if (InMemoryStore.Users[count].Equals(user))
                {
                    InMemoryStore.Users[count].Name = user.Name;
                    InMemoryStore.Users[count].UserType = user.UserType;
                    return "true";
                }
                count--;
            }

            return "false";
        }
    }
}
