using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        
        public static bool IsIntersectsX(this Control control1, Control control2, int distanceBetweenElements)
        {
            return PointExtra.IsIntersectsInOneDimention(
                control1.Location.X,
                control1.GetPointRightTop().X,
                control2.Location.X - distanceBetweenElements,
                control2.GetPointRightTop().X + distanceBetweenElements
                );
        }

    }
}
