using System;
using System.Collections.Generic;
using System.Text;

namespace PSP
{
    //
    class BinarySearch03
    {
        public static int Chop(int key, List<int> array)
        {
            int top = array.Count - 1;
            int bottom = 0;
            int middle = (top - bottom) / 2 + bottom;
            
            if (array.Count == 0)
                return -1;
            if (bottom > top)
                return -1;
            if (array[middle] == key)
                return middle;
            if (key < array[middle]) {
                List<int> leftSide = new List<int>();
                for (int i = 0; i < middle; i++)
                {
                    leftSide.Add(array[i]);
                }
                return Chop(key, leftSide);
            }
            else {
                List<int> rightSide = new List<int>();
                for (int i = middle+1; i <= top; i++)
                {
                    rightSide.Add(array[i]);
                }
                return Chop(key, rightSide);
            }
        }
    }
}
