using System;
using System.Collections.Generic;
using APPModels.Models;

namespace APPDataAccess.Repositories.InMemoryImplementation
{
    public static class InMemoryStore
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<IdCard> IdCards { get; set; } = new List<IdCard>();
    }
}
