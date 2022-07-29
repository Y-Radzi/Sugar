using System.Drawing;

namespace Sugar
{
    public static partial class PointExtra
    {
        /// <summary>
        /// Get new point as result of action between 2 points
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="action"></param>
        /// <param name="point2"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static Point GetActionResult(this Point point1, PointAction action, Point point2)
        {
            switch (action)
            {
                case PointAction.Plus:
                    return new Point(point1.X + point2.X, point1.Y + point2.Y);
                case PointAction.Minus:
                    return new Point(point1.X - point2.X, point1.Y - point2.Y);
                default: throw new System.Exception(
                    $"Unknown point action {action} between {point1.Display()} and {point2.Display()}");
            }
        }

        /// <summary>
        /// Get new point as result of action between points and number
        /// </summary>
        /// <param name="point"></param>
        /// <param name="action"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Point GetActionResult(this Point point, PointAction action, int number)
        {
            return point.GetActionResult(action, new Point(number, number));
        }

    }
}
