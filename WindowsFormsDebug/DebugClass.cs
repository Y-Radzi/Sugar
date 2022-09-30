using System;
using System.IO;
using System.Linq;
using Sugar;
using System.Collections.Generic;

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

            string f = @"";
            result = FileCustom.DeleteEmptyFolders(f);

            return result;
        }
    }
}
