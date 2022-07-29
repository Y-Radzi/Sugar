using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static Point GetPointCenter(this Control control)
        {
            return new Point(control.Location.X + control.Width / 2, control.Location.Y + control.Height / 2);
        }

        public static Point GetPointCenter(this Point objectLeftTop, Size objectSize)
        {
            return new Point(objectLeftTop.X + objectSize.Width / 2, objectLeftTop.Y + objectSize.Height / 2);
        }

    }
}
