using System.IO;
using System.Collections.Generic;
using System;

namespace Sugar
{
    public static partial class FileCustom
    {
        /// <summary>
        /// Names of file and compared files
        /// </summary>
        public class ComparaisonLogElement
        {
            /// <summary>
            /// Current file
            /// </summary>
            public string FullNameMain { get; set; }

            /// <summary>
            /// Compared files
            /// </summary>
            public List<string> FullNamesCompared { get; set; }

            /// <summary>
            /// Initiate class
            /// </summary>
            public ComparaisonLogElement()
            {
                FullNamesCompared = new List<string>();
            }

            /// <summary>
            /// Initiate class with FullNameMain
            /// </summary>
            /// <param name="fullNameMain"></param>
            public ComparaisonLogElement(string fullNameMain)
            {
                FullNameMain = fullNameMain;
                FullNamesCompared = new List<string>();
            }

            /// <summary>
            /// Initiate class with FullNameMain and single FullNamesCompared
            /// </summary>
            /// <param name="fullNameMain"></param>
            /// <param name="fullNameCompared"></param>
            public ComparaisonLogElement(string fullNameMain, string fullNameCompared)
            {
                FullNameMain = fullNameMain;
                FullNamesCompared = new List<string>() { fullNameCompared };
            }

            /// <summary>
            /// Get list of all files with FullNameMain and FullNamesCompared
            /// </summary>
            /// <returns></returns>
            public List<string> GetMainAndCompared()
            {
                var result = FullNamesCompared.Copy();
                if (!String.IsNullOrEmpty(FullNameMain))
                    result.Add(FullNameMain);
                return result;
            }

            /// <summary>
            /// FullNameMain + NewLine + "compared to:" + FullNamesCompared.Display()
            /// </summary>
            /// <returns></returns>
            public string Display()
            {
                return FullNameMain
                    + Environment.NewLine + "compared to:"
                    + Environment.NewLine + FullNamesCompared.Display()
                    ;
            }

            /// <summary>
            /// Removes from this if not exists. If FullNameMain: set null; if FullNamesCompared: .RemoveAt(...)
            /// </summary>
            public void RemoveIfNotExists()
            {
                if (!File.Exists(FullNameMain))
                    FullNameMain = null;

                for (int i = 0; i < FullNamesCompared.Count; i++)
                {
                    if (!File.Exists(FullNamesCompared[i]))
                    {
                        FullNamesCompared.RemoveAt(i);
                        i--;
                    }
                }
            }

            /// <summary>
            /// Is this contains no data
            /// </summary>
            /// <returns></returns>
            public bool IsEmpty()
            {
                return (String.IsNullOrEmpty(FullNameMain) && FullNamesCompared.IsNullOrEmpty());
            }

        }


    }
}
