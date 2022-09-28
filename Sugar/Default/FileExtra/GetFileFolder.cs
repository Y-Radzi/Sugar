namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Get parent folder of file full name
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <returns></returns>
        public static string GetFileFolder(string fileFullName)
        {
            return fileFullName.Substring(0, fileFullName.Length - GetFileShortNameWithExtention(fileFullName).Length).RemoveLastChar();
        }

    }
}
