using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOAC
{
    class IOAC
    {
        #region Input
        protected static void Header(string header)
        {
            Console.WriteLine(header);
        }

        protected static int GetInt(string text)
        {
            Header(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        protected static double GetDbl(string text)
        {
            Header(text);
            return Convert.ToDouble(Console.ReadLine());
        }
        #endregion

        #region Output
        #endregion

        #region Array
        protected static void FillArray(ref int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }
        }

        protected static void FillRandomArray(ref int[] array, int length = 10, int lowerBound = 0, int upperBound = 20)
        {
            Random randNum = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = randNum.Next(lowerBound, upperBound);
            }
        }


        protected static void PrintArray(int[] array)
        {
            string output = String.Empty;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                output += "[" + i + "] => " + array[i] + "\n";
            }

            Console.WriteLine(output);
        }
        #endregion
    }
}
