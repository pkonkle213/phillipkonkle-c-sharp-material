namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        3. Return the last element of the array
            TOPIC: Accessing Array Elements
        */
        public int ReturnLastElement()
        {
            int[] portNumbers = { 80, 8080, 8088, 4444, 443 };

            return portNumbers[portNumbers.Length - 1];
        }
    }
}
