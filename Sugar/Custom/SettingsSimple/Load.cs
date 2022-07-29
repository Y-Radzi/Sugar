using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sugar
{
    public static partial class SettingsSimple
    {
        /// <summary>
        /// Reads settings from file
        /// </summary>
        /// <param name="settingsWithKeys"></param>
        /// <param name="fileName"></param>
        /// <param name="encoding"></param>
        /// <param name="variableSplitter">splitter after value</param>
        /// <param name="keySplitter">splitter between key and value</param>
        /// <returns></returns>
        public static Dictionary<string, string> Load(
            Dictionary<string, string> settingsWithKeys,
            string fileName,
            Encoding encoding,
            string variableSplitter,
            string keySplitter
            )
        {
            validateSplitters(variableSplitter, keySplitter);

            var result = settingsWithKeys.Copy().NullAllValues();

            if (File.Exists(fileName))
            {
                var data = File.ReadAllText(fileName, encoding).Split(new string[] { variableSplitter }, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (var line in data)
                {
                    var keyValuePair = line.Split(new string[] { keySplitter }, 2, StringSplitOptions.RemoveEmptyEntries);
                    if (keyValuePair.Length == 2)
                        result = result.SetValueIfKeyExists(keyValuePair[0], keyValuePair[1]);
                }
            }
            return result;
        }
    }
}
