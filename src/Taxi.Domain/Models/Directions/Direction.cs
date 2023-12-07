namespace Taxi.Domain.Models.Directions;

public class Direction
{
    public int Id { get; set; }
    public string From { get; set; }
    public string Destination { get; set; }
    public string Distance { get; set; }
    public double Speed { get; set; }   
    public double Time { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
}
