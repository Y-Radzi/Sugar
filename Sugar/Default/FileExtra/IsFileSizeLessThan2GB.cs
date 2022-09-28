using System.IO;

namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Is file size < 2147483648 bytes?
        /// </summary>
        /// <returns></returns>
        public static bool IsFileSizeLessThan2GB(string fileFullName)
        {
            return (new FileInfo(fileFullName).Length < 2147483648);
        }
    }
}
