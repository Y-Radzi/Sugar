using System.Windows.Forms;

namespace Sugar
{
    public static partial class ControlExtra
    {
        /// <summary>
        /// Display control's Name, Location, Size splitted by elementsSplitter
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static string DisplayNameLocationSize(this Control control, string elementsSplitter)
        {
            if (control == null)
                return "none";
            else
                return $"Name: {control.Name.ReplaceIfEmpty("none")}" + elementsSplitter
                    + $"Location: {control.Location.Display()}" + elementsSplitter
                    + $"Size: {control.Size.Display()}";
        }

        /// <summary>
        /// Display control's Name, Location, Size splitted by StringExtra.SplitterRowDefault
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static string DisplayNameLocationSize(this Control control)
        {
            return control.DisplayNameLocationSize(StringExtra.SplitterRowDefault);
        }
    }
}
