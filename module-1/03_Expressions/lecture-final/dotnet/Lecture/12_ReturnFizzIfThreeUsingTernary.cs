﻿namespace Lecture
{
    public partial class LectureExample
    {
        /*
        12. Now write the above using the Ternary operator ?:
        */
        public string ReturnFizzIfThreeUsingTernary(int number)
        {
            return (number == 3)
                ? "Fizz"
                : "";

            return (number == 3) ? "Fizz" : "";

            if (number == 3)
            {
                return "Fizz";
            }
            else
            {
                return "";
            }
        }
    }
}
