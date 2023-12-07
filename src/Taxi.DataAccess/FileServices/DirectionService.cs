using Taxi.DataAccess.Interfaces;

namespace Taxi.DataAccess.FileServices;

public class DirectionService : IDirection
{
    private readonly IFileService _fileService;
    public DirectionService()
    {
        _fileService = new FileService();
    }

    public void CreateDirection(Domain.Models.Directions.Direction direction, string fileName)
    {
        direction.Id = _fileService.GetNumberOfLines(fileName) + 1;

        string data = string.Format("{0} {1} {2} {3} {4} {5} {6}",
            direction.Id,
            direction.From,
            direction.Destination,
            direction.Time,
            direction.Speed,
            direction.StartAt,
            direction.EndAt);

        if (File.Exists(fileName))
        {
            _fileService.WriteDataToFile(fileName, data);
        }
        else
        {
            _fileService.CreateFile(fileName);
            _fileService.WriteDataToFile(fileName, data);
        }
    }

    public string GetAllDirection(string fileName)
    {
        string result = "";

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                result += line + "\n";
            }
        }
        else
        {
            Console.WriteLine($"Fayl topilmadi: {fileName}");
        }

        return result;
    }
}
