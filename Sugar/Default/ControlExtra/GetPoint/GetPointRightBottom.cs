using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        public static Point GetPointRightBottom(this Control control)
        {
            return control.Location.GetPointRightBottom(control.Size);
        }
    }
}
