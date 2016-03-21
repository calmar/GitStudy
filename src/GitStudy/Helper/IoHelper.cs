using System.IO;

namespace GitStudy.Helper
{
    public class IoHelper
    {
        public static string ReadFile(string filePath) => File.ReadAllText(path: filePath);
    }
}
