using System.Reflection;
using System.IO;

namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Get file extention without "." from fileFullName
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <returns></returns>
        public static string GetFileExtention(string fileFullName)
        {
            if (string.IsNullOrEmpty(fileFullName))
                return "";

            if (fileFullName.Contains(StringExtra.SplitterFileExtention))
            {
                fileFullName = fileFullName
                    .SubstringWhileNotEquals(StringExtra.Side.Right, StringExtra.SplitterFileExtention)
                    .Replace(StringExtra.SplitterDirectoryToReplace, StringExtra.SplitterDirectory);

                return (fileFullName.ContainsAny(new char[] { StringExtra.SplitterDirectory, StringExtra.SplitterDisk })) ? "" : fileFullName;
            }
            else
                return "";
        }

    }
}
