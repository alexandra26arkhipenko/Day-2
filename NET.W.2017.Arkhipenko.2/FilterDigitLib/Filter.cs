using System;
using System.Collections;
using System.Data;

namespace FilterDigitLib
{
    public class Filter
    {
        public static ArrayList FilterDigit(int  number, params int[] listInts)
        {
            if (listInts.Length == 0)
            {
                throw new ArgumentException();
            }
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
