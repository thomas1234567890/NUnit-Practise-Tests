using System.IO;

namespace NUnitPractiseApp.Mocking
{
    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }

    }
}