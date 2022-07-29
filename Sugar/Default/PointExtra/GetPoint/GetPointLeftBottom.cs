using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static Point GetPointLeftBottom(this Control control)
        {
            return new Point(control.Location.X, control.Location.Y + control.Height);
        }

        public static Point GetPointLeftBottom(this Point objectLeftTop, Size objectSize)
        {
            return new Point(objectLeftTop.X, objectLeftTop.Y + objectSize.Height);
        }
    }
}
