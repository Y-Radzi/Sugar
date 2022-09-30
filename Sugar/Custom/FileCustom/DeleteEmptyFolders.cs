using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Sugar
{
    public static partial class FileCustom
    {
        public static string DeleteEmptyFolders(string folderToCheck)
        {
            return DeleteEmptyFolders(new List<string>() { folderToCheck });
        }

        public static string DeleteEmptyFolders(List<string> foldersToCheck)
        {
            string headerPart = "-------";
            string logsDeleted =
                headerPart + Environment.NewLine
                + headerPart + "Folders deleted:" + headerPart + Environment.NewLine
                + headerPart + Environment.NewLine;

            string logsKeeped = Environment.NewLine
                + headerPart + Environment.NewLine
                + headerPart + "Folders keeped:" + headerPart + Environment.NewLine
                + headerPart + Environment.NewLine;

            foldersToCheck = foldersToCheck.Distinct().ToList();

            if (FileExtra.IsAnyFiles(foldersToCheck, false))
                throw new Exception($"Can't \"DeleteEmptyFolders\", some folders a files");

            List<string> foldersAll = new List<string>();

            foreach (var folder in foldersToCheck)
            {
                foldersAll.Add(folder);
                foldersAll.AddRange(Directory.GetDirectories(folder, "*", SearchOption.AllDirectories));
            }
            foldersAll = foldersAll.Distinct().OrderByDescending(x => x.Length).ToList();

            //quick deletion
            for (int i = 0; i < foldersAll.Count; i++)
            {
                if (FolderExtra.IsFolderEmpty(foldersAll[i]))
                {
                    Directory.Delete(foldersAll[i]);
                    logsDeleted += foldersAll[i] + Environment.NewLine;
                    foldersAll.RemoveAt(i);
                    i--;
                }
            }

            //slow deletion
            for (int i = 0; i < foldersAll.Count; i++)
            {
                if (FolderExtra.IsFolderEmpty(foldersAll[i]))
                {
                    Directory.Delete(foldersAll[i]);
                    logsDeleted += foldersAll[i] + Environment.NewLine;
                    foldersAll.RemoveAt(i);
                    i = -1;
                }
            }

            foreach(var folder in foldersAll)
                logsKeeped += folder + Environment.NewLine;
            
            return logsDeleted + logsKeeped;
        }
    }
}
