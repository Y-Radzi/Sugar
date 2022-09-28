using System;

namespace Sugar
{
    public static partial class Number
    {
        
        public static int GetDistance(this int number1, int number2)
        {
            return Math.Abs(Math.Abs(number1) - Math.Abs(number2));
        }

    }
}
