namespace Oski_Test.DomainModels
{
    public class AnswerDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsTrue { get; set; }
        public int QuestionId { get; set; }
    }
}
