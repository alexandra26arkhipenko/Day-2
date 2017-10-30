using System;
using System.Collections;
using System.Linq;


namespace NumberHelper
{
    /// <summary>
    /// Inserts bits of the 2nd number starting from position startPosition to endPosition
    /// to the 1st number.
    /// </summary>
    public class NumberHelper
    { 
        #region private fields
        private const int RightBorder = 31;
        private const int LeftBorder = 0;
        #endregion

        #region public
        /// <summary>
        /// method InsertNumber Inserts bits of the 2nd number starting from position startPosition to endPosition
        /// to the 1st number
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="startPosition"></param>
        /// <param name="endPosition"></param>
        /// <returns>Int32 number</returns>
        public static int InsertNumber(int number1, int number2, int startPosition, int endPosition)
        {
            if (startPosition > endPosition)
                throw new ArgumentException($"{nameof(startPosition)} must be less than {nameof(endPosition)}");

            if ((startPosition < LeftBorder) || (startPosition > RightBorder) || (endPosition < LeftBorder) || (endPosition > RightBorder))
                throw new ArgumentException($"{nameof(startPosition)} and {nameof(endPosition)} must be greater than 0 and less than 32");

            int mask = ((2 << (endPosition - startPosition)) - 1) << startPosition;
            return (number1 & ~mask) | ((number2 << startPosition) & mask);
        }
        #endregion

    }
}