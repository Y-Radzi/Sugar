using System.Reflection;
using System.IO;

namespace Sugar
{
    public static partial class FileExtra
    {
        
        public static string GetFileFreeFullName(string fileFullName)
        {
            string fileExtention = "." + GetFileExtention(fileFullName);
            int index = 0;
            while (File.Exists(fileFullName))
            {
                index++;
                fileFullName = fileFullName.Substring(0, fileFullName.Length - fileExtention.Length) + $"({index})" + fileExtention;
            }
            return fileFullName;
        }

    }
}
