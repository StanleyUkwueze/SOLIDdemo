using System;
namespace APPLIB.Services.DTOs
{
    public class IdCardDto
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public UserDto User { get; set; }
    }
}
