using System;
using System.Collections.Generic;

namespace PSP
{
    //Recursive method
    public class BinarySearch01
    {
        public static int Chop(int key, List<int> array)
        {
            return Chopped(key, array, array.Count - 1, 0);
        }

        private static int Chopped(int key, List<int> array, int top, int bottom)
        {
            int middle = (top - bottom) / 2 + bottom;

            if (array.Count == 0)
                return -1;
            if (bottom > top)
                return -1;
            if (array[middle] == key)
                return middle;
            if (key < array[middle])
                return Chopped(key, array, middle - 1, bottom);
            else
                return Chopped(key, array, top, middle + 1);
        }
    }
}
