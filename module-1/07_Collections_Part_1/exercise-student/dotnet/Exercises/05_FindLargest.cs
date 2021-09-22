﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given a List of integers, return the largest value.
        FindLargest( [11, 200, 43, 84, 9917, 4321, 1, 33333, 8997] ) -> 33333
        FindLargest( [987, 1234, 9381, 731, 43718, 8932] ) -> 43718
        FindLargest( [34070, 1380, 81238, 7782, 234, 64362, 627] ) -> 64362
        */
        public int FindLargest(List<int> integerList)
        {
            /* int largestInt = integerList[0];
            foreach (int number in integerList)
            {
                if (number > largestInt)
                {
                    largestInt = number;
                }
            }
            return largestInt;
            */

            integerList.Sort();
            return integerList[integerList.Count - 1];

        }
    }
}
