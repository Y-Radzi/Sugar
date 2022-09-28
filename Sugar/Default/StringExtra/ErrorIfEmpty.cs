using System;

namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// this or Error in methodName: empty variableName + postfix
        /// </summary>
        /// <param name="str"></param>
        /// <param name="methodName"></param>
        /// <param name="variableName"></param>
        /// <param name="postfix"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Error in methodName: empty variableName + postfix</exception>
        public static string ErrorIfEmpty(this string str, string methodName, string variableName, string postfix)
        {
            if (string.IsNullOrEmpty(str))
                throw new Exception("Error in " + methodName + ": empty " + variableName + postfix);
            else
                return str;
        }

        /// <summary>
        /// this or Error in methodName: empty variableName
        /// </summary>
        /// <param name="str"></param>
        /// <param name="methodName"></param>
        /// <param name="variableName"></param>
        /// <returns></returns>
        /// /// <exception cref="Exception">Error in methodName: empty variableName</exception>
        public static string ErrorIfEmpty(this string str, string methodName, string variableName)
        {
            return str.ErrorIfEmpty(methodName, variableName, "");
        }




    }
}