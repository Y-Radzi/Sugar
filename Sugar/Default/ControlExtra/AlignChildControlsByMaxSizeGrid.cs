using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        /// <summary>
        /// Align child controls by maximum size grid
        /// </summary>
        /// <param name="controlMain"></param>
        /// <param name="distanceBetweenElements"></param>
        /// <param name="isVerticalIfWidthNotEnough">If width not enough - vertical or horizontal</param>
        public static void AlignChildControlsByMaxSizeGrid(this Control controlMain, int distanceBetweenElements, bool isVerticalIfWidthNotEnough)
        {
            var maxSize = controlMain.GetChildControlMaxSize();

            //If parent control width too small
            if (controlMain.Width < maxSize.Width + distanceBetweenElements * 2)
            {
                if (isVerticalIfWidthNotEnough)
                    controlMain.AlignChildControlsByMaxSizeVertical(distanceBetweenElements, maxSize);
                else
                    controlMain.AlignChildControlsByMaxSizeHorizontal(distanceBetweenElements, maxSize);
            }
            else //If parent control width wider than child maximum width
            {
                int row = 0;
                int column = 0;
                for (int i = 0; i < controlMain.Controls.Count; i++)
                {
                    int positionX = distanceBetweenElements * (column + 1) + maxSize.Width * column;

                    if (controlMain.Width > positionX + maxSize.Width + distanceBetweenElements)
                    {
                        controlMain.Controls[i].Location = new Point(positionX, distanceBetweenElements * (row + 1) + maxSize.Height * row);
                        column++;
                    }
                    else
                    {
                        row++;
                        column = 0;
                        i--;
                    }
                }
            }
        }
    }
}
