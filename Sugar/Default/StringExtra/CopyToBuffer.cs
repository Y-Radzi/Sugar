using System.Windows.Forms;

namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Copy string to buffer - Clipboard.SetText(str)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static void CopyToBuffer(this string str)
        {
            Clipboard.SetText(str);
        }
    }
}
