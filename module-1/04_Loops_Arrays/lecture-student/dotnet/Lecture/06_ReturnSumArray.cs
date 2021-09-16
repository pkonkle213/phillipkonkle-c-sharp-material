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
            
            int sum = 0;

            for (int indexArray = 0; indexArray<arrayToLoopThrough.Length; indexArray++)
            {
                sum += arrayToLoopThrough[indexArray];
            }

            return sum;
        }
    }
}
