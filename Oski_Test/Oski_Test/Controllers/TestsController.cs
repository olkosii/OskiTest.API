using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Oski_Test.DomainModels;
using Oski_Test.Reposetories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oski_Test.Controllers
{
    public class TestsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITestRepository _testRepository;


        public TestsController(ITestRepository testRepository, IMapper mapper)
        {
            _mapper= mapper;
            _testRepository= testRepository;
        }


        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllTestsAsync()
        {
            var tests = await _testRepository.GetTestsAsync();

            return Ok(_mapper.Map<List<TestDto>>(tests));
        }

        [HttpGet]
        [Route("[controller]/{testId:int}")]
        public async Task<IActionResult> GetTestAsync([FromRoute] int testId)
        {
            var test = await _testRepository.GetTestAsync(testId);

            return Ok(_mapper.Map<TestDto>(test));
        }

        [HttpGet]
        [Route("[controller]/GetQuestions/{testId:int}")]
        public async Task<IActionResult> GetQuestionsAsync([FromRoute] int testId)
        {
            var questions = await _testRepository.GetQuestionsAsync(testId);

            return Ok(_mapper.Map<List<QuestionDto>>(questions));
        }

        [HttpGet]
        [Route("[controller]/GetQuestion/{questionId:int}")]
        public async Task<IActionResult> GetQuestionAsync([FromRoute] int questionId)
        {
            var question = await _testRepository.GetQuestionAsync(questionId);

            return Ok(_mapper.Map<QuestionDto>(question));
        }

        [HttpGet]
        [Route("[controller]/GetAnswers/{questionId:int}")]
        public async Task<IActionResult> GetAnswersAsync([FromRoute] int questionId)
        {
            var answers = await _testRepository.GetAnswersAsync(questionId);

            return Ok(_mapper.Map<List<AnswerDto>>(answers));
        }

        [HttpGet]
        [Route("[controller]/GetAnswer/{answerId:int}")]
        public async Task<IActionResult> GetAnswerAsync([FromRoute] int answerId)
        {
            var answer = await _testRepository.GetAnswerAsync(answerId);

            return Ok(_mapper.Map<AnswerDto>(answer));
        }
    }
}
