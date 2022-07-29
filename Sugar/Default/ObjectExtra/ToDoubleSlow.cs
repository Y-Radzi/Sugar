using System;

namespace Sugar
{
    public static partial class ObjectExtra
    {
        /// <summary>
        /// Slow conversion of any object to double
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>double.NaN if error</returns>
        public static double ToDoubleSlow(this object obj)
        {
            try
            {
                return (double)obj;
            }
            catch
            {
                try
                {
                    return Convert.ToDouble(obj);
                }
                catch
                {
                    try
                    {
                        return (obj as string).ToDoubleComma();
                    }
                    catch
                    {
                        return double.NaN;
                    }
                }
            }
        }
    }
}
