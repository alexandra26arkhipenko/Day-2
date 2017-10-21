using System;
using System.Linq;


namespace Seeker
{
    public class Seeker
    {
        
        public static double FindNextBiggerNumber(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number can't be < 0 ");
            }

            char[] numberChar = number.ToString().ToCharArray();

           
            for (int i =(int)number + 1; i < Math.Pow(10,numberChar.Length); i++)
            {
                int key = 0;
                string iString = i.ToString();
                for (int j = 0; j < numberChar.Length; j++)
                {
                    if (iString.Contains(numberChar[j]))
                    {
                        key++;
                        
                    }
                }
                if (key == numberChar.Length)
                {
                    return i;
                }
            }
            return -1;
            
        }
    }
}
