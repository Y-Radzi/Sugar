using System.Reflection;

namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Assembly.GetEntryAssembly().Location;
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentFileFullName()
        {
            return Assembly.GetEntryAssembly().Location;
        }
    }
}
