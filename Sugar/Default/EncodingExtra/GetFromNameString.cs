using System.Text;

namespace Sugar
{
    public static partial class EncodingExtra
    {
        /// <summary>
        /// Get encoding by encoding name
        /// </summary>
        /// <param name="encodingString"></param>
        /// <returns></returns>
        public static Encoding GetByName(string encodingString)
        {
            Encoding encoding = null; //Encoding.Default;
            try
            {
                encoding = Encoding.GetEncoding(encodingString);
            }
            catch
            {
                try
                {
                    encoding = Encoding.GetEncoding(int.Parse(encodingString));
                } catch { }
            }
            return encoding;
        }
    }
}
