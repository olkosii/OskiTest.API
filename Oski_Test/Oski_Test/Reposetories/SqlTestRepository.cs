using Microsoft.EntityFrameworkCore;
using Oski_Test.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oski_Test.Reposetories
{
    public class SqlTestRepository : ITestRepository
    {
        private readonly TestContext _testContext;
        public SqlTestRepository(TestContext testContext)
        {
            _testContext = testContext;
        }

        public async Task<List<Test>> GetTestsAsync()
        {
            return await _testContext.Test.ToListAsync();
        }

        public async Task<Test> GetTestAsync(int testId)
        {
            return await _testContext.Test.FirstOrDefaultAsync(t => t.Id == testId);
        }

        public async Task<List<Question>> GetQuestionsAsync(int testId)
        {
            return await _testContext.Question.Where(q => q.TestId == testId).ToListAsync();
        }

        public async Task<Question> GetQuestionAsync(int questionId)
        {
            return await _testContext.Question.FirstOrDefaultAsync(q => q.Id == questionId);
        }

        public async Task<List<Answer>> GetAnswersAsync(int questionId)
        {
            return await _testContext.Answer.Where(a => a.QuestionId == questionId).ToListAsync();
        }

        public async Task<Answer> GetAnswerAsync(int answerId)
        {
            return await _testContext.Answer.FirstOrDefaultAsync(a => a.Id == answerId);
        }
    }
}
