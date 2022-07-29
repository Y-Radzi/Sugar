using System;
using System.Drawing;

namespace Sugar
{
    public static partial class PointExtra
    {
        /// <summary>
        /// Distance between points
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        public static int GetLengthBetween(this Point point1, Point point2)
        {
            return GetSqrtOfXSqrPlusYSqr(point1.X - point2.X, point1.Y - point2.Y);
        }

        /// <summary>
        /// Distance between point and line
        /// </summary>
        /// <param name="pointSingle"></param>
        /// <param name="pointOfLine1"></param>
        /// <param name="pointOfLine2"></param>
        /// <returns></returns>
        public static int GetLengthBetween(this Point pointSingle, Point pointOfLine1, Point pointOfLine2)
        {
            return Math.Abs(
                    (pointOfLine2.X - pointOfLine1.X) * (pointOfLine1.Y - pointSingle.Y)
                    - (pointOfLine1.X - pointSingle.X) * (pointOfLine2.Y - pointOfLine1.Y)
                ) / GetLengthBetween(pointOfLine1, pointOfLine2);

            /*
            Point delta = GetActionResult(pointOfLine2, PointAction.Minus, pointOfLine1);
            
            int t = ((pointSingle.X - pointOfLine1.X) * delta.X + (pointSingle.Y - pointOfLine1.Y) * delta.Y)
                / (delta.X * delta.X + delta.Y * delta.Y);

            if (t < 0)
                delta = GetActionResult(pointSingle, PointAction.Minus, pointOfLine1);
            else if (t > 1)
                delta = GetActionResult(pointSingle, PointAction.Minus, pointOfLine2);
            else
            {
                Point closest = new Point(pointOfLine1.X + t * delta.X, pointOfLine1.Y + t * delta.Y);
                delta = GetActionResult(pointSingle, PointAction.Minus, closest);
            }
            return getSqrtOfXSqrPlusYSqr(delta);
            */
        }
    }
}
