namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int maxValue = 0;

            for(int arrayIndex = 0; arrayIndex < randomNumbers.Length; arrayIndex++)
            {
                if (maxValue < randomNumbers[arrayIndex])
                {
                    maxValue = randomNumbers[arrayIndex];
                }
            }
            return maxValue;
        }
    }
}
