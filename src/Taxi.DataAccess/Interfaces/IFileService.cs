namespace Taxi.DataAccess.Interfaces;

public interface IFileService
{
    public void CreateFile(string fileName);
    public void WriteDataToFile(string fileName, string data);
    public int GetNumberOfLines(string fileName);
}
