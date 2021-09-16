namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints length 3, return a new array with the elements in reverse order, so
         {1, 2, 3} becomes {3, 2, 1}.
         Reverse3([1, 2, 3]) → [3, 2, 1]
         Reverse3([5, 11, 9]) → [9, 11, 5]
         Reverse3([7, 0, 0]) → [0, 0, 7]
         */
        public int[] Reverse3(int[] nums)
        {
            int store=nums[0]; //stores the first value
            nums[0] = nums[2]; //moves the last value to the first value
            nums[2] = store; //replaces the last value with the stored value

            return nums;
        }
    }
}
