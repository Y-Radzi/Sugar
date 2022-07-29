using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Get all files of folders and child folders
        /// </summary>
        /// <param name="folders"></param>
        /// <returns></returns>
        public static List<string> GetFilesAll(List<string> folders)
        {
            List<string> files = new List<string>();
            foreach (var folder in folders)
                if (Directory.Exists(folder))
                    files.AddRange(Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories).ToList());
            return files.Distinct().ToList();
        }
    }
}
