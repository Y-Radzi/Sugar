using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static Point GetPointRightTop(this Control control)
        {
            return new Point(control.Location.X + control.Width, control.Location.Y);
        }

        public static Point GetPointRightTop(this Point objectLeftTop, Size objectSize)
        {
            return new Point(objectLeftTop.X + objectSize.Width, objectLeftTop.Y);
        }

    }
}
