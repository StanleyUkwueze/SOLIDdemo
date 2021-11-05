using System;
namespace APPLIB.Services.DTOs
{
    public class UserDto
    {
        public string Name { get; set; }
        public IdCardDto IdCard { get; set; }
        public string UserType { get; set; }
    }
}
