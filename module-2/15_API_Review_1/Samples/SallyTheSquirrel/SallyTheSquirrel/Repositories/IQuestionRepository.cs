using System.Collections.Generic;
using TechElevator.SallyTheSquirrel.Server.Models;

namespace TechElevator.SallyTheSquirrel.Server.Repositories
{
    public interface IQuestionRepository
    {
        IEnumerable<QuestionEntry> Questions { get; }
        void AddQuestion(QuestionEntry entry);
        void UpdateQuestion(QuestionEntry entry);
        QuestionEntry FindQuestion(int id);
        bool DeleteQuestion(int id);
    }
}