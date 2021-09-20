namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            if (str.Length == 0)
            {
                return "";
            }
            else if (str.Length == 1 || str.Length == 2)
            {
                return str;
            }

            int startIndex = 0;
            int endIndex = 1;
            if (str[0] == 'x')
            {
                startIndex++;
            }
            if (str[str.Length - 1] == 'x')
            {
                endIndex++;
            }
            string oldString = str.Substring(startIndex, str.Length - endIndex);
            string cutString = oldString.Replace("x", "");
            string newString = str.Replace(oldString, cutString);
            return newString;
        }
    }
}
