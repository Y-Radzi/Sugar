namespace Sugar
{
    public static partial class FolderExtra
    {
        /// <summary>
        /// Get disk name without ":" from path of folder or file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetPathDiskName(string path)
        {
            if (string.IsNullOrEmpty(path))
                return "";

            if (path.Contains(StringExtra.SplitterDisk))
            {
                path = path.SubstringWhileNotEquals(StringExtra.Side.Left, StringExtra.SplitterDisk)
                    .Replace(StringExtra.SplitterDirectoryToReplace, StringExtra.SplitterDirectory);

                return (path.ContainsAny(new char[] { StringExtra.SplitterDirectory, StringExtra.SplitterFileExtention })) ? "" : path;
            }
            else
                return "";
        }

    }
}
