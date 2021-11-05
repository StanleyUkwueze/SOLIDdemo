
namespace APPLIB.Services.Interfaces
{
    public interface IPriviledgedUsers: IUser
    {
        public bool OpenDoor(string IdCard);
    }
}
