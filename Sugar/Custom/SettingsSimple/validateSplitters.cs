using System;

namespace Sugar
{
    public static partial class SettingsSimple
    {
        /// <summary>
        /// Validate settings splitters: not empty and not equals
        /// </summary>
        /// <param name="variableSplitter"></param>
        /// <param name="keySplitter"></param>
        /// <exception cref="Exception"></exception>
        private static void validateSplitters(string variableSplitter, string keySplitter)
        {
            if (variableSplitter.ErrorIfEmpty("checkSplitters", "variableSplitter") == keySplitter.ErrorIfEmpty("checkSplitters", "keySplitter"))
                throw new Exception($"Error, variableSplitter equals to keySplitter; {variableSplitter}");
        }
    }
}
