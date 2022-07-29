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
        public static ComparaisonLogGroup FindFilesNonUnique(List<string> filesFullName)
        {
            filesFullName = filesFullName.Distinct().ToList();

            var logGroup = new ComparaisonLogGroup() { Name = "Files non unique" };
            
            var files = new List<FileAndInfo>();
            foreach (var fileFullName in filesFullName)
            {
                if (FileExtra.IsFile(fileFullName, false))
                {
                    var file = new FileAndInfo();
                    file.GetInfo(fileFullName);
                    file.GetDataHashCode(fileFullName);
                    files.Add(file);
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
                    logGroup.Elements.Add(element);
            }

            return logGroup;
        }
    }
}
