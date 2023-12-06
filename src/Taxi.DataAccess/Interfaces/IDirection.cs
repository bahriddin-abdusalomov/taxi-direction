using Taxi.Domain.Models.Directions;
using Taxi.Domain.Models.Users;

namespace Taxi.DataAccess.Interfaces;

public interface IDirection
{
    public void CreateDirection(Direction direction);
    public string GetAllDirection();
    public void UpdateDirection(Direction direction);
    public void DeleteDirection(Direction direction);
    public string GetDirectionById(int id);
}
