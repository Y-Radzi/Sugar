using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class PointExtra
    {
        public static Point GetPointLeftTop(this Control control)
        {
            return control.Location;
        }
    }
}
