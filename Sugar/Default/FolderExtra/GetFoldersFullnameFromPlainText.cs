using System;
using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class FolderExtra
    {
        /// <summary>
        /// Get list of folders full names
        /// </summary>
        /// <param name="foldersPlainText"></param>
        /// <param name="foldersSplitter"></param>
        /// <returns></returns>
        public static List<string> GetFoldersFullnameFromPlainText(string foldersPlainText, string foldersSplitter)
        {
            var foldersRaw = foldersPlainText.Split(new string[] { foldersSplitter }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
            var folders = new List<string>();
            foreach (string folderRaw in foldersRaw)
                if (IsFolder(folderRaw, false))
                    folders.Add(folderRaw);
            return folders.Distinct().ToList();
        }

    }
}
