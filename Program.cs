using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12,18 };
            Console.Write("------------------find {0}", BinarySearch(14, 0, 12 - 1, array));

            Console.ReadKey(true);
        }


       static bool BinarySearch(int findnum,int startIndex,int endIndex,int[] array)
        {
            if(startIndex < 0 || endIndex < 0 || startIndex> endIndex)
            {
                return false;
            }

            if(startIndex == endIndex)
            {
                return findnum == array[startIndex];
            }

            int len = endIndex - startIndex + 1;
            int mixIndex = len / 2 + startIndex - 1;
            if (mixIndex < 0)
            {
                return false;
            }

            if (findnum== array[mixIndex])
            {
                return true;
            }
            else if(findnum < array[mixIndex])
            {
                return BinarySearch(findnum, startIndex, mixIndex - 1,array);
            }
            else if(findnum > array[mixIndex])
            {
                return BinarySearch(findnum, mixIndex + 1,endIndex, array);
            }

            return false;
        }
    }
}
