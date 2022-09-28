using System.Drawing;

namespace Sugar
{
    public static partial class PointExtra
    {
        /// <summary>
        /// Point (ValueX; ValueY)
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static string Display(this Point point)
        {
            //return "Point (" + point.X.ToString() + StringExtra.SplitterColumnDefault + point.Y.ToString() + ")";
            return $"X: {point.X}{StringExtra.SplitterColumnDefault}Y: {point.Y}";
        }
    }
}
