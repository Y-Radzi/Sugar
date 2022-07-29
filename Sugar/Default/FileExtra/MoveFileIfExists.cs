using System.IO;

namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Moves file if exists to new filename
        /// </summary>
        /// <param name="oldFileFullName"></param>
        /// <param name="newFileFullName"></param>
        /// <param name="isOverwrite"></param>
        /// <exception cref="System.Exception">if empty names; if not overwrite, but new name exists</exception>
        public static void MoveFileIfExists(string oldFileFullName, string newFileFullName, bool isOverwrite)
        {
            if (File.Exists(oldFileFullName.ErrorIfEmpty("MoveIfExists", "oldFileFullName")))
            {
                if (!IsFile(oldFileFullName, false))
                    throw new System.Exception($"Can't move {oldFileFullName}, oldFileFullName is not a file");

                if (File.Exists(newFileFullName.ErrorIfEmpty("MoveIfExists", "newFileFullName")))
                {
                    if (isOverwrite)
                        File.Delete(newFileFullName);
                    else
                        throw new System.Exception($"Can't move {oldFileFullName}, new file {newFileFullName} already exists");
                }

                File.Move(oldFileFullName, newFileFullName);
            }
        }
    }
}
