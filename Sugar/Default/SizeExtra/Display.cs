using System.Drawing;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class SizeExtra
    {
        /// <summary>
        /// "width: {size.Width}; height: {size.Height}" or "none"
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string Display(this Size size)
        {
            if (size != null)
                return $"width: {size.Width}; height: {size.Height}";
            else
                return "none";
        }
    }
}