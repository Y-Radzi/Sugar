using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class FileCustom
    {
        /// <summary>
        /// Find equals files
        /// </summary>
        /// <param name="filesFullName"></param>
        /// <returns></returns>
        public static ComparaisonLogOutput FindFilesNonUnique(List<string> filesFullName)
        {
            filesFullName = filesFullName.Distinct().ToList();

            string keyCompared = "keyCompared";
            string keyMore2GB = "keyMore2GB";

            var logs = new ComparaisonLogOutput();
            logs.Groups.Add(keyCompared, new ComparaisonLogGroup() { Name = "Non unique files" });
            logs.Groups.Add(keyMore2GB, new ComparaisonLogGroup() { Name = "Unable to compare files more than 2 GB" });

            var files = new List<FileAndInfo>();
            foreach (var fileFullName in filesFullName)
            {
                if (FileExtra.IsFile(fileFullName, false))
                {
                    var file = new FileAndInfo();
                    file.GetInfo(fileFullName);
                    if (FileExtra.IsFileSizeLessThan2GB(fileFullName))
                    {
                        file.GetDataHashCode(fileFullName);
                        files.Add(file);
                    }
                    else
                        logs.Groups[keyMore2GB].Elements.Add(new ComparaisonLogElement(fileFullName));
                }
            }

            for (int i = 0; i < files.Count; i++)
            {
                var element = new ComparaisonLogElement() { FullNameMain = files[i].Info.FullName };
                var dataThis = new byte[0];

                for (int j = i + 1; j > i && j < files.Count; j++)
                {
                    if (files[i].DataHashCode == files[j].DataHashCode)
                    {
                        if (dataThis.Length == 0)
                            dataThis = File.ReadAllBytes(files[i].Info.FullName);

                        var dataOther = File.ReadAllBytes(files[j].Info.FullName);

                        if (dataThis.SequenceEqual(dataOther))
                        {
                            element.FullNamesCompared.Add(files[j].Info.FullName);
                            files.RemoveAt(j);
                            j--;
                        }
                    }
                }

                if (element.FullNamesCompared.Count > 0)
                    logs.Groups[keyCompared].Elements.Add(element);
            }

            return logs;
        }
    }
}
