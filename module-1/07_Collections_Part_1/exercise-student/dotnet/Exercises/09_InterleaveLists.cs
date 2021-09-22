using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> bothLists = new List<int>();
            int maxCount;

            if (listOne.Count > listTwo.Count)
            {
                maxCount = listOne.Count;
            }
            else
            {
                maxCount = listTwo.Count;
            }

            for (int i = 0; i < maxCount; i++)
            {
                if (i < listOne.Count)
                {
                    bothLists.Add(listOne[i]);
                }
                if (i < listTwo.Count)
                {
                    bothLists.Add(listTwo[i]);
                }
            }

            return bothLists;
        }
    }
}
