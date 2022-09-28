using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        
        public static bool IsIntersectsY(this Control control1, Control control2, int distanceBetweenElements)
        {
            return PointExtra.IsIntersectsInOneDimention(
                control1.Location.Y,
                control1.GetPointLeftBottom().Y,
                control2.Location.Y - distanceBetweenElements,
                control2.GetPointLeftBottom().Y + distanceBetweenElements
                );
        }

    }
}
