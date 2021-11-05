
namespace APPModels.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IdCard IdCard { get; set; } // coupling: [compositional] 'has a'
        public string UserType { get; set; }


        public User(string id, string name, IdCard idCard, string userType)
        {
            Id = id;
            Name = name;
            UserType = userType;
        }
        
    }
}
