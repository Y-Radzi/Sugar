using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Sugar
{
    public static partial class FileCustom
    {
        /// <summary>
        /// Deleting files from list ToDelete if equals to files from list ToCompare
        /// </summary>
        /// <param name="filesFullNameToDelete"></param>
        /// <param name="filesFullNameToCompare"></param>
        /// <param name="isShowNotEqualsLog"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static ComparaisonLogOutput DeleteFilesIfEqualsDataShortNames(List<string> filesFullNameToDelete, List<string> filesFullNameToCompare, bool isShowNotEqualsLog)
        {
            filesFullNameToCompare = filesFullNameToCompare.Distinct().ToList();
            filesFullNameToDelete = filesFullNameToDelete.Distinct().ToList().GetUniqueOfThis(filesFullNameToCompare);

            if (!FileExtra.IsFiles(filesFullNameToCompare, true))
                throw new Exception($"Can't \"DeleteFilesIfEqualsDataShortNames\", some comparing filenames are not a files");

            if (!FileExtra.IsFiles(filesFullNameToDelete, true))
                throw new Exception($"Can't \"DeleteFilesIfEqualsDataShortNames\", some deleting filenames are not a files");

            string keyDeleted = "Deleted";
            string keyNotDeletedButSame = "NotDeletedButSame";
            string keyNotEqualsByHash = "NotEqualsByHash";
            string keyNotEqualsByData = "keyNotEqualsByData";

            var logs = new ComparaisonLogOutput();
            logs.Groups.Add(keyDeleted, new ComparaisonLogGroup() { Name = "Files deleted" });
            logs.Groups.Add(keyNotDeletedButSame, new ComparaisonLogGroup() { Name = "Files equals, but not deleted" });
            if (isShowNotEqualsLog)
            {
                logs.Groups.Add(keyNotEqualsByHash, new ComparaisonLogGroup() { Name = "Files not equals by hash" });
                logs.Groups.Add(keyNotEqualsByData, new ComparaisonLogGroup() { Name = "Files not equals by data" });
            }

            var filesToDelete = new List<FileAndInfo>();
            foreach (var fileFullNameToDelete in filesFullNameToDelete)
            {
                var file = new FileAndInfo();
                file.GetInfo(fileFullNameToDelete);
                file.GetDataHashCode(fileFullNameToDelete);
                filesToDelete.Add(file);
            }

            foreach (var fileFullNameToCompare in filesFullNameToCompare)
            {
                var dataToCompare = File.ReadAllBytes(fileFullNameToCompare);
                var dataHashCodeToCompare = Array<byte>.GetHashCodeOfArray(dataToCompare);
                var fileShortNameWithExtentionToCompare = FileExtra.GetFileShortNameWithExtention(fileFullNameToCompare);

                for (int j = 0; j < filesToDelete.Count; j++)
                {
                    //if hash not equals
                    if (filesToDelete[j].DataHashCode != dataHashCodeToCompare)
                    {
                        if (isShowNotEqualsLog)
                            logs.Groups[keyNotEqualsByHash].Elements.Add(new ComparaisonLogElement(filesToDelete[j].Info.FullName, fileFullNameToCompare));
                        continue;
                    }
                    else
                    {
                        var dataToDelete = File.ReadAllBytes(filesToDelete[j].Info.FullName);
                        //if data not equals
                        if (!dataToDelete.SequenceEqual(dataToCompare))
                        {
                            if (isShowNotEqualsLog)
                                logs.Groups[keyDeleted].Elements.Add(new ComparaisonLogElement(filesToDelete[j].Info.FullName, fileFullNameToCompare));
                            continue;
                        }
                    }

                    //if data equals
                    //if short name equals
                    if (FileExtra.GetFileShortNameWithExtention(filesToDelete[j].Info.FullName) == fileShortNameWithExtentionToCompare)
                    {
                        File.Delete(filesToDelete[j].Info.FullName);
                        logs.Groups[keyDeleted].Elements.Add(new ComparaisonLogElement(filesToDelete[j].Info.FullName, fileFullNameToCompare));
                        filesToDelete.RemoveAt(j);
                        j--;
                    }
                    //if short name not equals
                    else
                        logs.Groups[keyNotDeletedButSame].Elements.Add(new ComparaisonLogElement(filesToDelete[j].Info.FullName, fileFullNameToCompare));
                }
            }

            return logs;
        }
    }
}
