using Taxi.DataAccess.Interfaces;

namespace Taxi.DataAccess.FileServices;

public class FileService : IFileService
{
    private List<string> _existingData;

    public FileService()
    {
        _existingData = new List<string>();
    }

    public void CreateFile(string fileName)
    {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            // Fayl bo'sh yaratiladi
        }
    }

    public void WriteDataToFile(string fileName, string data)
    {

        if (File.Exists(fileName))
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    _existingData.Add(line);
                }
            }
        }

        _existingData.Add(data);

        using (StreamWriter sw = new StreamWriter(fileName, false))
        {
            foreach (string line in _existingData)
            {
                sw.WriteLine(line);
            }
        }
    }

    public int GetNumberOfLines(string fileName)
    {
        // Faylni ochib qatorlar sonini hisoblash
        //if (File.Exists(fileName))
        //{
        //    using (StreamReader sr = new StreamReader(fileName))
        //    {
        //        int lineCount = 0;

        //        while (!sr.EndOfStream)
        //        {
        //            // Har bir qatorni o'qish
        //            sr.ReadLine();
        //            lineCount++;
        //        }

        //        return lineCount;
        //    }
        //}
        //else
        //{
        //    // Fayl mavjud emas, 0 qaytarish
        //    return 0;
        //}
        int count = _existingData.Count;
        return count;
    }
}
