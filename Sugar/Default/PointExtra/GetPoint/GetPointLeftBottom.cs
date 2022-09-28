using System.Drawing;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static Point GetPointLeftBottom(this Point leftTop, Size size)
        {
            return new Point(leftTop.X, leftTop.Y + size.Height);
        }
    }
}
