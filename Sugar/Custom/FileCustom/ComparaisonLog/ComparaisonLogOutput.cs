using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Sugar
{
    public static partial class FileCustom
    {
        /// <summary>
        /// Collection of ComparaisonLogGroup
        /// </summary>
        public class ComparaisonLogOutput
        {
            /// <summary>
            /// Dictionary of ComparaisonLogGroup
            /// </summary>
            public Dictionary<string, ComparaisonLogGroup> Groups { get; set; }

            /// <summary>
            /// Initiate class
            /// </summary>
            public ComparaisonLogOutput()
            {
                Groups = new Dictionary<string, ComparaisonLogGroup>();
            }

            /// <summary>
            /// Dislays data by keys
            /// </summary>
            /// <param name="keys"></param>
            /// <returns></returns>
            public string Display(List<string> keys)
            {
                string result = "";
                keys = keys.GetIntersection(Groups.Keys.ToList());

                for (int i = 0; i < keys.Count; i++)
                {
                    result += ((i == 0) ? "" : Environment.NewLine.Multiply(4))
                        + Groups[keys[i]].Display();
                }

                return result;
            }

            /// <summary>
            /// Dislays all data
            /// </summary>
            /// <returns></returns>
            public string DisplayAll()
            {
                string result = "";
                var keys = Groups.Keys.ToList();

                for (int i = 0; i < keys.Count; i++)
                {
                    result += ((i == 0) ? "" : Environment.NewLine.Multiply(4))
                        + Groups[keys[i]].Display();
                }

                return result;
            }
        }


    }
}
