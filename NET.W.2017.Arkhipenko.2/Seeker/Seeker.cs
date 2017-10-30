using System;
using System.Linq;
using System.Diagnostics;


namespace Seeker
{
    /// <summary>
    /// class Seeker takes a integer and 
    /// returns the largest integer consisting of the digits of the original number,
    /// and - 1 (null), if there is no such number
    /// </summary>
    public class Seeker
    {
        /// <summary>
        /// 
        /// method FindNextBiggerNumber takes a integer and 
        /// returns the largest integer consisting of the digits of the original number,
        /// and - 1 (null), if there is no such number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Int32 , Time(double) </returns>

        #region public
        public static Tuple<int, double > FindNextBiggerNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number can't be < 0 ");
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            char[] numberChar = number.ToString().ToCharArray();           

            for (int i = number + 1; i < Math.Pow(10,numberChar.Length); i++)
            {
                int key = 0;
                string iString = i.ToString();
                for (int j = 0; j < numberChar.Length; j++)
                {
                    if (iString.Contains(numberChar[j]))
                    {
                        key++;
                        var l = iString.IndexOf(numberChar[j]);
                        iString = iString.Remove(l, 1);
                    }
                }
                if (key == numberChar.Length)
                {
                    stopwatch.Stop();
                    double time1 = stopwatch.Elapsed.Milliseconds;
                   
                    return Tuple.Create(i, time1);

                }
            }

            stopwatch.Stop();
            double time2 = stopwatch.Elapsed.Milliseconds;
            return Tuple.Create(-1, time2);
           
        }
         #endregion
    }
}
