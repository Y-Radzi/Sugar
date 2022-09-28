using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        
        public static string DisplayFourPoints(this Control control, string elementsSplitter)
        {
            if (control == null)
                return "none";
            else
                return $"Name: {control.Name.ReplaceIfEmpty("none")}"
                    + elementsSplitter + $"LeftTop {control.Location.Display()}"
                    + elementsSplitter + $"LeftBottom {control.GetPointLeftBottom().Display()}"
                    + elementsSplitter + $"RightTop {control.GetPointRightTop().Display()}"
                    + elementsSplitter + $"RightBottom {control.GetPointRightBottom().Display()}"
                    ;
        }
    }
}
