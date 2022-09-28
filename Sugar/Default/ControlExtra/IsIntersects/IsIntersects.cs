using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        public static bool IsIntersects(this Control control, Point point)
        {
            return point.IsIntersects(control, 0, 0);
        }
        public static bool IsIntersects(this Control control, Point point, int minDistanceX, int minDistanceY)
        {
            return point.IsIntersects(control, minDistanceX, minDistanceY);
        }

        public static bool IsIntersects(this Control control, Point point, int minDistanceXY)
        {
            return point.IsIntersects(control, minDistanceXY, minDistanceXY);
        }

        public static bool IsIntersects(this Control control1, Control control2)
        {
            return PointExtra.IsIntersects(
                control1.Location,
                control1.GetPointRightBottom(),
                control2.Location,
                control2.GetPointRightBottom(),
                0,
                0
                );
        }

        public static bool IsIntersects(this Control control1, Control control2, int minDistanceX, int minDistanceY)
        {
            return PointExtra.IsIntersects(
                control1.Location,
                control1.GetPointRightBottom(),
                control2.Location,
                control2.GetPointRightBottom(),
                minDistanceX,
                minDistanceY
                );
        }

        public static bool IsIntersects(this Control control1, Control control2, int minDistanceXY)
        {
            return PointExtra.IsIntersects(
                control1.Location,
                control1.GetPointRightBottom(),
                control2.Location,
                control2.GetPointRightBottom(),
                minDistanceXY,
                minDistanceXY
                );
        }
    }
}
