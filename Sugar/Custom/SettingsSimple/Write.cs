using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sugar
{
    public static partial class SettingsSimple
    {
        /// <summary>
        /// Writes settings if different
        /// </summary>
        /// <param name="newSettings"></param>
        /// <param name="fileName"></param>
        /// <param name="encoding"></param>
        /// <param name="variableSplitter">splitter after value</param>
        /// <param name="keySplitter">splitter between key and value</param>
        public static void Write(
            Dictionary<string, string> newSettings,
            string fileName,
            Encoding encoding,
            string variableSplitter,
            string keySplitter
            )
        {
            validateSplitters(variableSplitter, keySplitter);

            var oldSettings = Load(newSettings, fileName, encoding, variableSplitter, keySplitter);

            if (!oldSettings.IsEquals(newSettings))
                File.WriteAllText(
                    fileName,
                    newSettings.Display(keySplitter, variableSplitter),
                    encoding);
        }
    }
}
