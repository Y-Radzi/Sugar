namespace Sugar
{
    public static partial class Array<Temp>
    {
        /// <summary>
        /// "true" if array == null or array.Length == 0; else - "false"
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(Temp[] array)
        {
            if (array == null)
                return true;

            if (array.Length == 0)
                return true;
            else
                return false;
        }
    }
}