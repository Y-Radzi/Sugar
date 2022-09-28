namespace Sugar
{
    public static partial class PointExtra
    {
        /// <summary>
        /// Is coordinates intersects in one dimention: X or Y.
        /// Is square1 any point between square2 points
        /// </summary>
        /// <param name="square1LeftTop"></param>
        /// <param name="square1rightBottom"></param>
        /// <param name="square2LeftTop"></param>
        /// <param name="square2rightBottom"></param>
        /// <returns></returns>
        public static bool IsIntersectsInOneDimention(int square1LeftTop, int square1rightBottom, int square2LeftTop, int square2rightBottom)
        {
            return (square1LeftTop.IsBetween(square2LeftTop, square2rightBottom)
                || square1rightBottom.IsBetween(square2LeftTop, square2rightBottom)
                );
        }

    }
}
