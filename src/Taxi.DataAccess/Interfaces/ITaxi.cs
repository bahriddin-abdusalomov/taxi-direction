using Taxi.Domain.Models.Transports;

namespace Taxi.DataAccess.Interfaces;

public interface ITaxi
{
    public void CreateTaxi(Car car);
    public string GetAllTaxi();
    public void UpdateTaxi(Car car);
    public void DeleteTaxi(Car car);
    public string GetTaxiById(int id);
}
