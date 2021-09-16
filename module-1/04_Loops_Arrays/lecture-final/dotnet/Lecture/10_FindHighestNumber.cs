namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers) // [-1, -2, -3]
        {
            // Create a variable to track the largest number
            int largest = randomNumbers[0];

            // Loop through all numbers
            for (int index = 1; index < randomNumbers.Length; index++)
            {
                // If a number is larger than last largest number, it is now the largest number
                int number = randomNumbers[index];

                if (number > largest)
                {
                    largest = number;
                }
            }

            // Return largest number
            return largest;
        }
    }
}
