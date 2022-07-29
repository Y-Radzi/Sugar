namespace Sugar
{
    public static partial class StringExtra
    {
        
        private static int indexOfNot(this string str, string target, bool isLastIndex, bool isTargetLeftSide)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(target))
                return -1;

            string[] splitOfNot = str.Split(new string[] { target }, System.StringSplitOptions.RemoveEmptyEntries);

            if (splitOfNot.Length == 0)
                return -1;

            if (isLastIndex)
            {
                return str.LastIndexOf(splitOfNot[splitOfNot.Length - 1])
                    + ((isTargetLeftSide) ? 0 : splitOfNot[splitOfNot.Length - 1].Length - 1);
            }
            else
            {
                return str.IndexOf(splitOfNot[0])
                    + ((isTargetLeftSide) ? 0 : splitOfNot[0].Length - 1);
            }
        }

        private static int indexOfNot(this string str, string[] targetArray, bool isLastIndex, bool isTargetLeftSide)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            string[] splitOfNot = str.Split(targetArray, System.StringSplitOptions.RemoveEmptyEntries);

            if (splitOfNot.Length == 0)
                return -1;

            if (isLastIndex)
            {
                return str.LastIndexOf(splitOfNot[splitOfNot.Length - 1])
                    + ((isTargetLeftSide) ? 0 : splitOfNot[splitOfNot.Length - 1].Length - 1);
            }
            else
            {
                return str.IndexOf(splitOfNot[0])
                    + ((isTargetLeftSide) ? 0 : splitOfNot[0].Length - 1);
            }
        }


    }
}