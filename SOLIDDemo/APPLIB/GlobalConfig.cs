using System;
using APPDataAccess.Repositories.InMemoryImplementation.Implementation;
using APPDataAccess.Repositories.InMemoryImplementation.Interface;
using APPLIB.Services.Imlementations;
using APPLIB.Services.Interfaces;

namespace APPLIB
{
    public static class GlobalConfig
    {
        public static IPriviledgedUsers StaffInstance;
        public static IPriviledgedUsers StudentInstance;
        public static IUser UserInstance;

        private static IUserRepository userRepository;

        public static void Instantiate()
        {

            userRepository = new UserRepository();

            //------------------------------------------------------

            StaffInstance = new StaffServices();
            StudentInstance = new StudentServices();
            UserInstance = new UserServices(userRepository);
        }
    }
}
