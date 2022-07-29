namespace Sugar
{
    public static partial class Array<Temp>
    {
        /// <summary>
        /// Getting hash code of array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GetHashCodeOfArray(Temp[] array)
        {
            unchecked
            {
                if (IsNullOrEmpty(array))
                    return 0;
                int hash = 17;
                foreach (var element in array)
                    hash = hash * 23 + element.GetHashCode();
                return hash;
            }
        }
    }
}