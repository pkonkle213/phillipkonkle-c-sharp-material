using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class ListDiscussion
    {
        public void Launchpad()
        {
            List<int> mainList = new List<int> { 1, 2, 3 };
            List<int> resultingList = ListExample(mainList);

            Console.WriteLine("Main List");
            foreach (int i in mainList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Resulting List");
            foreach (int i in resultingList)
            {
                Console.WriteLine(i);
            }
        }

        private List<int> ListExample(List<int> incomingList) // { 1, 2, 3}
        {
            List<int> myList = new List<int>();
            myList = incomingList;

            myList.Add(42);

            return myList;
        }
    }
}
