using Taxi.DataAccess.Interfaces;
using Taxi.Domain.Models.Users;

namespace Taxi.DataAccess.FileServices;

public class UserService : IUser
{
    private readonly IFileService _fileService;

    public UserService(IFileService fileService)
    {
        _fileService = fileService;
    }

    public void CreateUser(User user, string fileName)
    {
        user.Id = _fileService.GetNumberOfLines(fileName) + 1;

        string data = string.Format("{0} {1} {2} {3} {4} {5} {6}",
            user.Id,
            user.FisrtName,
            user.LastName,
            user.UserName,
            user.Password,
            user.CreatedAt,
            user.UpdatedAt);

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

    public void DeleteUser(User user, string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        int tartibRaqami = user.Id;

        if (tartibRaqami > 0 && tartibRaqami <= lines.Length)
        {
            lines[tartibRaqami - 1] = $"{tartibRaqami} DELETED";

            File.WriteAllLines(fileName, lines);
        }
        else
        {
            Console.WriteLine("Tartib raqami fayl ichida mavjud bo'lgan qatorlar sonidan katta yoki 0.");
        }
    }

    public string GetAllUser(string fileName)
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

    public string GetUserById(int id, string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        int tartibRaqami = id;

        if (tartibRaqami > 0 && tartibRaqami <= lines.Length)
        {
            return lines[tartibRaqami - 1];
        }
        else
        {
            return "Tartib raqami fayl ichida mavjud bo'lgan qatorlar sonidan katta yoki 0.";
        }
    }

    public void UpdateUser(User user, string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        int tartibRaqami = user.Id;

        if (tartibRaqami > 0 && tartibRaqami <= lines.Length)
        {
            lines[tartibRaqami - 1] = $"{tartibRaqami} " +
                $"{user.FisrtName}" +
                $" {user.LastName}" +
                $" {user.UserName}" +
                $" {user.Password}" +
                $" {user.CreatedAt}" +
                $" {user.UpdatedAt}";

            File.WriteAllLines(fileName, lines);
        }
        else
        {
            Console.WriteLine("Tartib raqami fayl ichida mavjud bo'lgan qatorlar sonidan katta yoki 0.");
        }
    }
}
