using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static bool IsIntersects(this Point point, Control control)
        {
            return control.IsIntersects(point);
        }

        public static bool IsIntersects(this Control control, Point point)
        {
            return (point.X.IsBetween(control.Location.X, control.Location.X + control.Width)
                && point.Y.IsBetween(control.Location.Y, control.Location.Y + control.Height));
        }

        public static bool IsIntersects(Point square1LeftTop, Point square1RightBottom, Point square2LeftTop, Point square2RightBottom)
        {
            return (IsIntersectsInOneDimention(square1LeftTop.X, square1RightBottom.X, square2LeftTop.X, square2RightBottom.X)
                && IsIntersectsInOneDimention(square1LeftTop.Y, square1RightBottom.Y, square2LeftTop.Y, square2RightBottom.Y));
        }

        public static bool IsIntersects(Point object1LeftTop, Size object1Size, Point object2LeftTop, Size object2Size)
        {
            return IsIntersects(
                object1LeftTop,
                GetPointRightBottom(object1LeftTop, object1Size),
                object2LeftTop,
                GetPointRightBottom(object2LeftTop, object2Size));
        }

        public static bool IsIntersects(this Control control1, Control control2)
        {
            return IsIntersects(
                control1.Location,
                GetPointRightBottom(control1),
                control2.Location,
                GetPointRightBottom(control2));
        }

    }
}
