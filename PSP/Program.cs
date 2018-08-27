using System;
using System.Collections.Generic;

namespace PSP
{
    class Program
    {
        static void Main(string[] args)
        {

            Assert(-1, BinarySearch01.Chop(3, new List<int>{ }));
            Assert(-1, BinarySearch01.Chop(3, new List<int> { 1}));
            Assert(0, BinarySearch01.Chop(1, new List<int> { 1}));

            Assert(0, BinarySearch01.Chop(1, new List<int> { 1, 3, 5}));
            Assert(1, BinarySearch01.Chop(3, new List<int> { 1, 3, 5}));
            Assert(2, BinarySearch01.Chop(5, new List<int> { 1, 3, 5}));
            Assert(-1, BinarySearch01.Chop(0, new List<int> { 1, 3, 5}));
            Assert(-1, BinarySearch01.Chop(2, new List<int> { 1, 3, 5}));
            Assert(-1, BinarySearch01.Chop(4, new List<int> { 1, 3, 5}));
            Assert(-1, BinarySearch01.Chop(6, new List<int> { 1, 3, 5}));

            Assert(0, BinarySearch01.Chop(1, new List<int> { 1, 3, 5, 7}));
            Assert(1, BinarySearch01.Chop(3, new List<int> { 1, 3, 5, 7}));
            Assert(2, BinarySearch01.Chop(5, new List<int> { 1, 3, 5, 7}));
            Assert(3, BinarySearch01.Chop(7, new List<int> { 1, 3, 5, 7}));
            Assert(-1, BinarySearch01.Chop(0, new List<int> { 1, 3, 5, 7}));
            Assert(-1, BinarySearch01.Chop(2, new List<int> { 1, 3, 5, 7}));
            Assert(-1, BinarySearch01.Chop(4, new List<int> { 1, 3, 5, 7}));
            Assert(-1, BinarySearch01.Chop(6, new List<int> {1, 3, 5, 7}));
            Assert(-1, BinarySearch01.Chop(8, new List<int>{ 1, 3, 5, 7}));

            //Binary method 2
            Assert(-1, BinarySearch02.Chop(3, new List<int> { }));
            Assert(-1, BinarySearch02.Chop(3, new List<int> { 1 }));
            Assert(0, BinarySearch02.Chop(1, new List<int> { 1 }));

            Assert(0, BinarySearch02.Chop(1, new List<int> { 1, 3, 5 }));
            Assert(1, BinarySearch02.Chop(3, new List<int> { 1, 3, 5 }));
            Assert(2, BinarySearch02.Chop(5, new List<int> { 1, 3, 5 }));
            Assert(-1, BinarySearch02.Chop(0, new List<int> { 1, 3, 5 }));
            Assert(-1, BinarySearch02.Chop(2, new List<int> { 1, 3, 5 }));
            Assert(-1, BinarySearch02.Chop(4, new List<int> { 1, 3, 5 }));
            Assert(-1, BinarySearch02.Chop(6, new List<int> { 1, 3, 5 }));

            Assert(0, BinarySearch02.Chop(1, new List<int> { 1, 3, 5, 7 }));
            Assert(1, BinarySearch02.Chop(3, new List<int> { 1, 3, 5, 7 }));
            Assert(2, BinarySearch02.Chop(5, new List<int> { 1, 3, 5, 7 }));
            Assert(3, BinarySearch02.Chop(7, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch02.Chop(0, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch02.Chop(2, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch02.Chop(4, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch02.Chop(6, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch02.Chop(8, new List<int> { 1, 3, 5, 7 }));

            ////Yet another binary method
            Assert(-1, BinarySearch03.Chop(3, new List<int> { }));
            Assert(-1, BinarySearch03.Chop(3, new List<int> { 1 }));
            Assert(0, BinarySearch03.Chop(1, new List<int> { 1 }));

            Assert(0, BinarySearch03.Chop(1, new List<int> { 1, 3, 5 }));
            Assert(1, BinarySearch03.Chop(3, new List<int> { 1, 3, 5 }));
            Assert(0, BinarySearch03.Chop(5, new List<int> { 1, 3, 5 }));//new index is 0 instead of 2
            Assert(-1, BinarySearch03.Chop(0, new List<int> { 1, 3, 5 }));
            Assert(-1, BinarySearch03.Chop(2, new List<int> { 1, 3, 5 }));
            Assert(-1, BinarySearch03.Chop(4, new List<int> { 1, 3, 5 }));
            Assert(-1, BinarySearch03.Chop(6, new List<int> { 1, 3, 5 }));

            Assert(0, BinarySearch03.Chop(1, new List<int> { 1, 3, 5, 7 }));
            Assert(1, BinarySearch03.Chop(3, new List<int> { 1, 3, 5, 7 }));
            Assert(0, BinarySearch03.Chop(5, new List<int> { 1, 3, 5, 7 }));//new index is 0 instead of 2
            Assert(0, BinarySearch03.Chop(7, new List<int> { 1, 3, 5, 7 }));//new index is 0 instead of 3
            Assert(-1, BinarySearch03.Chop(0, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch03.Chop(2, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch03.Chop(4, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch03.Chop(6, new List<int> { 1, 3, 5, 7 }));
            Assert(-1, BinarySearch03.Chop(8, new List<int> { 1, 3, 5, 7 }));
        }

        public static int Assert(int index, int result)
        {
            if (index != result)
                throw new Exception();
            else
                return index;
        }

       
    }
}

