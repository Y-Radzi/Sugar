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
        /// <param name="isReallyDelete"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static ComparaisonLogOutput DeleteFilesIfEqualsData(List<string> filesFullNameToDelete, List<string> filesFullNameToCompare, bool isReallyDelete)
        {
            filesFullNameToCompare = filesFullNameToCompare.Distinct().ToList();
            filesFullNameToDelete = filesFullNameToDelete.Distinct().ToList().GetUniqueOfThis(filesFullNameToCompare);

            if (!FileExtra.IsFiles(filesFullNameToCompare, true))
                throw new Exception($"Can't \"DeleteFilesIfEqualsData\", some comparing filenames are not a files");

            if (!FileExtra.IsFiles(filesFullNameToDelete, true))
                throw new Exception($"Can't \"DeleteFilesIfEqualsData\", some deleting filenames are not a files");

            string keyDeleted = "Deleted";
            string keyMore2GB = "keyMore2GB";

            var logs = new ComparaisonLogOutput();
            logs.Groups.Add(keyDeleted, new ComparaisonLogGroup() { Name = "Files deleted" });
            logs.Groups.Add(keyMore2GB, new ComparaisonLogGroup() { Name = "Unable to compare files more than 2 GB" });
            
            var filesToDelete = new List<FileAndInfo>();
            foreach (var fileFullNameToDelete in filesFullNameToDelete)
            {
                var file = new FileAndInfo();
                file.GetInfo(fileFullNameToDelete);
                if (file.IsFileSizeLessThan2GB())
                {
                    file.GetDataHashCode(fileFullNameToDelete);
                    filesToDelete.Add(file);
                }
                else
                    logs.Groups[keyMore2GB].Elements.Add(new ComparaisonLogElement(fileFullNameToDelete));
            }

            foreach (var fileFullNameToCompare in filesFullNameToCompare)
            {
                if (FileExtra.IsFileSizeLessThan2GB(fileFullNameToCompare))
                {
                    var dataToCompare = File.ReadAllBytes(fileFullNameToCompare);
                    var dataHashCodeToCompare = Array<byte>.GetHashCodeOfArray(dataToCompare);
                    
                    for (int j = 0; j < filesToDelete.Count; j++)
                    {
                        if (filesToDelete[j].DataHashCode != dataHashCodeToCompare) //if hash not equals
                            continue;
                        else //if data not equals
                        {
                            var dataToDelete = File.ReadAllBytes(filesToDelete[j].Info.FullName);
                            if (!dataToDelete.SequenceEqual(dataToCompare))
                                continue;
                        }

                        //if data equals
                        if (isReallyDelete)
                            File.Delete(filesToDelete[j].Info.FullName);

                        logs.Groups[keyDeleted].Elements.Add(new ComparaisonLogElement(filesToDelete[j].Info.FullName, fileFullNameToCompare));
                        filesToDelete.RemoveAt(j);
                        j--;
                    }
                }
                else
                    logs.Groups[keyMore2GB].Elements.Add(new ComparaisonLogElement(fileFullNameToCompare));
            }

            return logs;
        }
    }
}
