using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static bool IsIntersects(this Point point, Control control, int minDistanceX, int minDistanceY)
        {
            return (
                    point.X.IsBetween(
                        control.Location.X - minDistanceX,
                        control.Location.GetPointRightTop(control.Size).X + minDistanceX
                    )
                &&  point.Y.IsBetween(
                        control.Location.Y - minDistanceY,
                        control.Location.GetPointLeftBottom(control.Size).Y + minDistanceY
                    )
                );
        }

        public static bool IsIntersects(this Point point, Control control, int minDistanceXY)
        {
            return point.IsIntersects(control, minDistanceXY, minDistanceXY);
        }

        public static bool IsIntersects(this Point point, Control control)
        {
            return point.IsIntersects(control, 0, 0);
        }

        public static bool IsIntersects(
            Point square1LeftTop,
            Point square1RightBottom,
            Point square2LeftTop,
            Point square2RightBottom,
            int minDistanceX,
            int minDistanceY
            )
        {
            return (
                    IsIntersectsInOneDimention(
                        square1LeftTop.X,
                        square1RightBottom.X,
                        square2LeftTop.X - minDistanceX,
                        square2RightBottom.X + minDistanceX
                    )
                &&  IsIntersectsInOneDimention(
                        square1LeftTop.Y,
                        square1RightBottom.Y,
                        square2LeftTop.Y - minDistanceY,
                        square2RightBottom.Y + minDistanceY
                    )
            );
        }

        public static bool IsIntersects(
            Point square1LeftTop,
            Point square1RightBottom,
            Point square2LeftTop,
            Point square2RightBottom,
            int minDistanceXY
            )
        {
            return IsIntersects(square1LeftTop, square1RightBottom, square2LeftTop, square2RightBottom, minDistanceXY, minDistanceXY);
        }

        public static bool IsIntersects(
            Point square1LeftTop,
            Point square1RightBottom,
            Point square2LeftTop,
            Point square2RightBottom
            )
        {
            return IsIntersects(square1LeftTop, square1RightBottom, square2LeftTop, square2RightBottom, 0, 0);
        }
    }
}
