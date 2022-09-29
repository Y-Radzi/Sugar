namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Get file short name without extention from fileFullName
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <returns></returns>
        public static string GetFileShortNameNoExtention(string fileFullName)
        {
            if (string.IsNullOrEmpty(fileFullName))
                return "";

            fileFullName = fileFullName.Replace(StringExtra.SplitterDirectoryToReplace, StringExtra.SplitterDirectory);

            if (fileFullName.Contains(StringExtra.SplitterDirectory))
                fileFullName = fileFullName.SubstringWhileNotEquals(StringExtra.Side.Right, StringExtra.SplitterDirectory);

            string fileExtention = GetFileExtention(fileFullName);

            if (!string.IsNullOrEmpty(fileExtention))
                fileFullName = fileFullName.Substring(0, fileFullName.Length - fileExtention.Length - 1);

            return (fileFullName.Contains(StringExtra.SplitterDisk)) ? "" : fileFullName;
        }

    }
}
