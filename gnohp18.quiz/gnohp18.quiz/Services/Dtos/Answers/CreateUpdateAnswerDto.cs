using gnohp18.quiz.Questions;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Answers
{
    public class CreateUpdateAnswerDto 
    {
        public Guid QuestionId { get; set; }
        
        public string Content { get; set; }
        
        public bool IsTrueAnswer { get; set; }
    }
}