using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        /// <summary>
        /// Get size of child controls maximum width and maximum height
        /// </summary>
        /// <param name="controlMain"></param>
        /// <returns></returns>
        public static Size GetChildControlMaxSize(this Control controlMain)
        {
            var maxSize = new Size(0, 0);

            foreach (Control control in controlMain.Controls)
            {
                if (control.Size.Width > maxSize.Width)
                    maxSize.Width = control.Size.Width;

                if (control.Size.Height > maxSize.Height)
                    maxSize.Height = control.Size.Height;
            }

            return maxSize;
        }
    }
}
