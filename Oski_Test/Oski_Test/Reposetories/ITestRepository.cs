using Oski_Test.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oski_Test.Reposetories
{
    public interface ITestRepository
    {
        Task<List<Test>> GetTestsAsync();
        Task<List<Question>> GetQuestionsAsync(int testId);
        Task<List<Answer>> GetAnswersAsync(int questionId);
    }
}
