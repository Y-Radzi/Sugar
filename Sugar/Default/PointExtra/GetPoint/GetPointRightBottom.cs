using System.Drawing;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static Point GetPointRightBottom(this Point leftTop, Size size)
        {
            return new Point(leftTop.X + size.Width, leftTop.Y + size.Height);
        }
    }
}
