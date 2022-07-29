namespace Sugar
{
    public static partial class Number
    {
        /// <summary>
        /// Is number >= than one of any two numbers and <= that other
        /// </summary>
        /// <param name="numberMain"></param>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static bool IsBetween(this int numberMain, int number1, int number2)
        {
            return (numberMain >= (number1 < number2 ? number1 : number2)
                && numberMain <= (number2 > number1 ? number2 : number1));
        }

    }
}
