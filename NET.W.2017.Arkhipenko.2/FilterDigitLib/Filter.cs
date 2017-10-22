using System;
using System.Collections;

namespace FilterDigitLib
{
    public class Filter
    {
        public static ArrayList FilterDigit(int  number, params int[] listInts)
        {
            ArrayList listFilter = new ArrayList();
            for (int i = 0; i < listInts.Length; i++)
            {
                string supportString = listInts[i].ToString();
                string numberString = number.ToString();
                if (supportString.Contains(numberString))
                {
                    listFilter.Add(listInts[i]);
                }
            }
            return listFilter;
        }
    }
}
