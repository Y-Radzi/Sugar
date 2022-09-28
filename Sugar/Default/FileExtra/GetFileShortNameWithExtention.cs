namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Get file short name with extention from fileFullName
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <returns></returns>
        public static string GetFileShortNameWithExtention(string fileFullName)
        {
            if (string.IsNullOrEmpty(fileFullName))
                return "";

            fileFullName = fileFullName.Replace(StringExtra.SplitterDirectoryToReplace, StringExtra.SplitterDirectory);

            if (fileFullName.Contains(StringExtra.SplitterDirectory))
                fileFullName = fileFullName.SubstringWhileNotEquals(StringExtra.Side.Right, StringExtra.SplitterDirectory);

            return (fileFullName.Contains(StringExtra.SplitterDisk)) ? "" : fileFullName;
        }
    }
}
