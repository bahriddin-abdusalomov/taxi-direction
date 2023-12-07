using Taxi.Domain.Models.Directions;
using Taxi.Domain.Models.Users;

namespace Taxi.DataAccess.Interfaces;

public interface IDirection
{
    public void CreateDirection(Direction direction, string fileName);
    public string GetAllDirection(string fileName);
}
