using Oski_Test.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oski_Test.Reposetories
{
    public interface ITestRepository
    {
        Task<List<Test>> GetTestsAsync();
        Task<Test> GetTestAsync(int testId);
        Task<List<Question>> GetQuestionsAsync(int testId);
        Task<Question> GetQuestionAsync(int questionId);
        Task<List<Answer>> GetAnswersAsync(int questionId);
        Task<Answer> GetAnswerAsync(int answerId);
    }
}
