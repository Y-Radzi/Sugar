﻿using System.Drawing;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static Point GetPointCenter(this Point leftTop, Size size)
        {
            return new Point(leftTop.X + size.Width / 2, leftTop.Y + size.Height / 2);
        }

    }
}
