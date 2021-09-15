namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" when number is even, larger than 100, and a multiple of 5.
            Return "Big Number" if the number is just larger than 100.
            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            bool largerThan100 = (number > 100);

            bool numberIsEven;
            if (number % 2 == 0) // Check for a remainder after dividing by 2
            {
                numberIsEven = true;
            } 
            else
            {
                numberIsEven = false;
            }

            bool isMultipleOfFive = (number % 5 == 0);

            if (numberIsEven && largerThan100 && isMultipleOfFive)
            {
                return "Big Even Number";
            }

            if (largerThan100)
            {
                return "Big Number";
            }

            return "";
        }
    }
}
