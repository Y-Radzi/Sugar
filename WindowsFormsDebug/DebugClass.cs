using System;
using System.Linq;
using Sugar;

namespace WindowsFormsDebug
{
    public static class DebugClass
    {
        public static string Debug()
        {
            string result = "";

            try
            {
                result = Run();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }

        public static string Run()
        {
            string result = "";




            return result;
        }
    }
}
