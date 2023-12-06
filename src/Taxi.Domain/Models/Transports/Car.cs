namespace Taxi.Domain.Models.Transports;

public class Car : BaseModel
{
    public string Model { get; set; }
    public string Name { get; set; }
    public string CarNumber { get; set; }
    public string Color { get; set; }
}
