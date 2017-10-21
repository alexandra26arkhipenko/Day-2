using System;
using System.Collections;
using System.Linq;

namespace NumberHelper
{
    public class NumberHelper
    {
        public static int[] IntToBiteArray(int number)
        {
            BitArray b = new BitArray(new int[] { number });
            var bitArray = new int[b.Count];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == true)
                {
                    bitArray[i] = 1;
                }
                if (b[i] == false)
                {
                    bitArray[i] = 0;
                }

            }

            return bitArray;
        }
        public static int BitStringToInt(string bits)
        {
            var reversedBits = bits.Reverse().ToArray();
            var num = 0;
            for (var power = 0; power < reversedBits.Count(); power++)
            {
                var currentBit = reversedBits[power];
                if (currentBit == '1')
                {
                    var currentNum = (int)Math.Pow(2, power);
                    num += currentNum;
                }
            }

            return num;
        }
        public static void InsertNumber(int firstIntNumber, int secondIntNumber, int i, int j)
        {
            int[] supportArrayFirst = IntToBiteArray(firstIntNumber);
            int[] supportArraySecond = IntToBiteArray(secondIntNumber);

            int[] littleSecondArray = new int[j - i + 1];

            for (int k = 0; k < j-i+1; k++)
            {
                littleSecondArray[k] = supportArraySecond[k]; 
            }   
           
            
            for (int l = i, k = 0; l<j ; l++, k++)
            {
                supportArrayFirst[l] = littleSecondArray[k];
            }
            Array.Reverse(supportArrayFirst);
            
            string supportArrayFirstToString = null;
            for (int l = 0; l < supportArrayFirst.Length; l++)
            {
                supportArrayFirstToString = supportArrayFirstToString + supportArrayFirst[l];
            }
            

        }
    }
}