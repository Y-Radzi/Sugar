using System.Windows.Forms;
using System.Drawing;

namespace Sugar
{
    public static partial class ControlExtra
    {
        
        public static void MoveToRightOf(this Control control1, Control control2, int distanceBetweenElements)
        {
            control1.Location = new Point(
                control2.GetPointRightTop().X + distanceBetweenElements + 1,
                control1.Location.Y
            );
        }

    }
}
