﻿using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        public static Point GetPointLeftBottom(this Control control)
        {
            return control.Location.GetPointLeftBottom(control.Size);
        }
    }
}
