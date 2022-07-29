using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        /// <summary>
        /// Align child controls by maximum size vertical
        /// </summary>
        /// <param name="controlMain"></param>
        /// <param name="distanceBetweenElements"></param>
        public static void AlignChildControlsByMaxSizeVertical(this Control controlMain, int distanceBetweenElements)
        {
            controlMain.AlignChildControlsByMaxSizeVertical(distanceBetweenElements, controlMain.GetChildControlMaxSize());
        }

        /// <summary>
        /// Align child controls by maximum size vertical if maximum size already exists
        /// </summary>
        /// <param name="controlMain"></param>
        /// <param name="distanceBetweenElements"></param>
        /// <param name="maxSize"></param>
        public static void AlignChildControlsByMaxSizeVertical(this Control controlMain, int distanceBetweenElements, Size maxSize)
        {
            for (int i = 0; i < controlMain.Controls.Count; i++)
                controlMain.Controls[i].Location = new Point(distanceBetweenElements,
                    distanceBetweenElements * (i + 1) + maxSize.Height * i);
        }
    }
}
