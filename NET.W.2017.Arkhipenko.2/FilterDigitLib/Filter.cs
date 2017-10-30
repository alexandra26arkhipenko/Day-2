using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace FilterDigitLib
{
    public class Filter
    {
        public static List<int> FilterDigit(int  number, params int[] listInts)
        {

            if (listInts == null)
            {
                throw new ArgumentNullException();
            }
            if (listInts.Length == 0)
            {
                throw new ArgumentException();
            }
            List<int> listFilter = new List<int>();
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
