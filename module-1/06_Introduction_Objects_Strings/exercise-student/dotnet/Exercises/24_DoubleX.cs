namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {
            if (str.Length < 2)
            {
                return false;
            }
            else if (str.IndexOf("x") == str.Length-1)
            {
                return false;
            }
            else
            {
                int testIndex = str.IndexOf("x");
                bool test = str[testIndex+1] == 'x';
                return test;
            }
        }
    }
}
