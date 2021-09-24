namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
        }

        public int EarnedMarks { get; set; }
        
        public int PossibleMarks { get; private set; }
        
        public string SubmitterName { get; private set; }
        
        public string LetterGrade
        {
            get
            {
                int scoreEarned = (EarnedMarks * 100) / PossibleMarks;
                string letter;
                if (90 <= scoreEarned)
                {
                    letter = "A";
                }
                else if (80 <= scoreEarned)
                {
                    letter = "B";
                }
                else if (70 <= scoreEarned)
                {
                    letter = "C";
                }
                else if (60 <= scoreEarned)
                {
                    letter = "D";
                }
                else
                {
                    letter = "F";
                }
                return letter;
            }
        }
    }
}
