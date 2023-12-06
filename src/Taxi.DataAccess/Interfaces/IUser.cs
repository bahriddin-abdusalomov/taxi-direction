using Taxi.Domain.Models.Users;

namespace Taxi.DataAccess.Interfaces;

public interface IUser
{
    public void CreateUser(User user, string fileName);
    public string GetAllUser(string fileName);
    public void UpdateUser(User user, string fileName);
    public void DeleteUser(User user, string fileName);
    public string GetUserById(int id, string fileName);
}
