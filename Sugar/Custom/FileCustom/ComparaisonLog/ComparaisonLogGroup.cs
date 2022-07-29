using System.Collections.Generic;
using System;

namespace Sugar
{
    public static partial class FileCustom
    {
        /// <summary>
        /// Collection of ComparaisonLogElement
        /// </summary>
        public class ComparaisonLogGroup
        {
            /// <summary>
            /// Name of group
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// List of ComparaisonLogElement
            /// </summary>
            public List<ComparaisonLogElement> Elements { get; set; }

            /// <summary>
            /// Initiate class
            /// </summary>
            public ComparaisonLogGroup()
            {
                Elements = new List<ComparaisonLogElement>();
            }

            /// <summary>
            /// Removes enties of every element in Elements if contaons no data. Removes element if empty.
            /// </summary>
            public void RemoveIfNotExists()
            {
                for (int i = 0; i < Elements.Count; i++)
                {
                    Elements[i].RemoveIfNotExists();
                    if (Elements[i].IsEmpty())
                    {
                        Elements.RemoveAt(i);
                        i--;
                    }
                }
            }

            /// <summary>
            /// Removes enties of every element in Elements if contaons only one filename: main or compared
            /// </summary>
            public void RemoveIfSingle()
            {
                for (int i = 0; i < Elements.Count; i++)
                {
                    if (Elements[i].GetMainAndCompared().Count == 1)
                    {
                        Elements.RemoveAt(i);
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
                if (this == null)
                    return true;

                if (Elements == null)
                    return true;

                if (Elements.Count == 0)
                    return true;

                return false;
            }

            /// <summary>
            /// Generates header with Name for Display
            /// </summary>
            /// <returns></returns>
            public string GenerateLogHeader()
            {
                string headerPart = "-------";
                return headerPart
                    + Environment.NewLine + headerPart.Multiply(2) + Name + headerPart.Multiply(2)
                    + Environment.NewLine + headerPart;
            }

            /// <summary>
            /// Displays name and data
            /// </summary>
            /// <returns></returns>
            public string Display()
            {
                string result = GenerateLogHeader();

                foreach (var element in Elements)
                    result += Environment.NewLine.Multiply(2) + element.Display();

                return result;
            }
        }


    }
}
