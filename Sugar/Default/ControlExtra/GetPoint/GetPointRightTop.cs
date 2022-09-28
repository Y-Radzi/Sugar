using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        public static Point GetPointRightTop(this Control control)
        {
            return control.Location.GetPointRightTop(control.Size);
        }
    }
}
