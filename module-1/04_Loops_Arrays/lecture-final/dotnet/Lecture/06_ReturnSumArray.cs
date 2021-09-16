namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        6. How can we write a for loop that sums up the values in this array?
           TOPIC: For Loops
        */
        public int ReturnSumArray()
        {
            int[] arrayToLoopThrough = { 3, 4, 2, 9 };

            // Start our total sum at 0
            int total = 0;

            // For each element in the array, add its value to total
            for (int index = 0; index < arrayToLoopThrough.Length; index++)
            {
                // Get the value by its index
                int value = arrayToLoopThrough[index];

                // Add the value to the total
                total += value;
            }

            // Return total
            return total;
        }
    }
}
