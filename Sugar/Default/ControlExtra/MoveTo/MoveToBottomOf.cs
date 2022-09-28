using System.Windows.Forms;
using System.Drawing;

namespace Sugar
{
    public static partial class ControlExtra
    {
        
        public static void MoveToBottomOf(this Control control1, Control control2, int distanceBetweenElements)
        {
            control1.Location = new Point(
                control1.Location.X,
                control2.GetPointLeftBottom().Y + distanceBetweenElements + 1
            );
        }

    }
}
