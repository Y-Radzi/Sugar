namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// variableName: variableAsString + postfix
        /// </summary>
        /// <param name="variableAsString"></param>
        /// <param name="variableName"></param>
        /// <param name="postfix"></param>
        /// <returns></returns>
        public static string DisplayVariable(this string variableAsString, string variableName, string postfix)
        {
            return variableName + ": " + (variableAsString ?? "") + postfix;
        }

        /// <summary>
        /// variableName: variableAsString
        /// </summary>
        /// <param name="variableAsString"></param>
        /// <param name="variableName"></param>
        /// <returns></returns>
        public static string DisplayVariable(this string variableAsString, string variableName)
        {
            return variableName + ": " + (variableAsString ?? "");
        }
    }
}