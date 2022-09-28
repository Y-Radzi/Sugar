using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        public static Point GetPointCenter(this Control control)
        {
            return new Point(control.Location.X + control.Width / 2, control.Location.Y + control.Height / 2);
        }
    }
}
