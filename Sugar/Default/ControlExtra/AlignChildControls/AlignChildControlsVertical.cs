using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        /// <summary>
        /// Align child controls by last position vertical
        /// </summary>
        /// <param name="controlMain"></param>
        /// <param name="distanceBetweenElements"></param>
        public static void AlignChildControlsVertical(this Control controlMain, int distanceBetweenElements)
        {
            int lastPosition = 0;
            for (int i = 0; i < controlMain.Controls.Count; i++)
            {
                controlMain.Controls[i].Location = new Point(distanceBetweenElements, distanceBetweenElements + lastPosition);
                lastPosition = controlMain.Controls[i].Location.Y + controlMain.Controls[i].Size.Height;
            }
        }
    }
}