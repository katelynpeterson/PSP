using System;
using System.Collections.Generic;
using System.Text;

namespace PSP
{
    //Iterative method
    class BinarySearch02
    {
        public static int Chop(int key, List<int> array)
        {
            int top = array.Count - 1;
            int bottom = 0;

            while (top >= bottom) {
                int middle = (top - bottom) / 2 + bottom;
                if (array[middle] == key)
                    return middle;
                if (key < array[middle])
                    top = middle-1;
                else
                    bottom = middle+1;
            }

            return -1;
        }
    }
}
