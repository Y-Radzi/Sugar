namespace Sugar
{
    public static partial class ObjectExtra
    {
        /// <summary>
        /// Safe comparasion of ".Equals" allows nulls. "true" if both objects are null.
        /// </summary>
        /// <param name="thisObject"></param>
        /// <param name="otherObject"></param>
        /// <returns></returns>
        public static bool EqualsSafe(this object thisObject, object otherObject)
        {
            if (thisObject == null && otherObject == null)
                return true;
            else if ((thisObject == null && otherObject != null) || (thisObject != null && otherObject == null))
                return false;
            else
                return thisObject.Equals(otherObject);
        }

    }
}
