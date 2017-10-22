using System;
using System.Linq;
using System.Diagnostics;


namespace Seeker
{
    public class Seeker
    {
        
        public static Tuple<int, TimeSpan > FindNextBiggerNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number can't be < 0 ");
            }
            Stopwatch stopwatch = new Stopwatch();
            char[] numberChar = number.ToString().ToCharArray();
            stopwatch.Start();

            for (int i =(int)number + 1; i < Math.Pow(10,numberChar.Length); i++)
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
                    TimeSpan time1 = stopwatch.Elapsed;
                   
                    return Tuple.Create(i, time1);

                }
            }

            stopwatch.Stop();
            TimeSpan time2 = stopwatch.Elapsed;
            string time2toString = time2.ToString();
            return Tuple.Create(-1, time2);
           
        }
    }
}
