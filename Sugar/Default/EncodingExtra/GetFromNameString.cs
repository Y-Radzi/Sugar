using System.Text;
using System.Windows.Forms;

namespace Sugar
{
    public static partial class EncodingExtra
    {
        /// <summary>
        /// Get encoding by encoding name, can show MessageBox if not found
        /// </summary>
        /// <param name="encodingString"></param>
        /// <param name="showWarningMessage"></param>
        /// <returns></returns>
        public static Encoding GetByName(string encodingString, bool showWarningMessage, string warningMessage)
        {
            if (string.IsNullOrEmpty(warningMessage))
                warningMessage = "Unable to read encoding. Using default.";

            Encoding encoding = Encoding.Default;
            try
            {
                encoding = Encoding.GetEncoding(encodingString);
            }
            catch
            {
                try
                {
                    encoding = Encoding.GetEncoding(int.Parse(encodingString));
                }
                catch
                {
                    if (showWarningMessage)
                        MessageBox.Show(warningMessage);
                }
            }
            return encoding;
        }

        /// <summary>
        /// Get encoding by encoding name
        /// </summary>
        /// <param name="encodingString"></param>
        /// <returns></returns>
        public static Encoding GetByName(string encodingString)
        {
            return GetByName(encodingString, false, "");
        }
    }
}
