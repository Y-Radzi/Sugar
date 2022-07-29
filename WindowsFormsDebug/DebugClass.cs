using System;
using System.Collections.Generic;
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

            string str = "aaaaaaaaaa444444";
            var div = str.Split(new string[] { "d" }, 2, StringSplitOptions.RemoveEmptyEntries);

            result = div.ToList().Display();

            return result;
        }
    }
}
