using Oski_Test.DataModels;
using System.Collections.Generic;

namespace Oski_Test.DomainModels
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int TestId { get; set; }
    }
}
