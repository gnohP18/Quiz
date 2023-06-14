using gnohp18.quiz.Answers;
using gnohp18.quiz.TypeOfQuestions;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Questions
{
    public class QuestionDto : EntityDto<Guid>
    {
        public Guid TypeOfQuestionId { get; set; }

        public string Content { get; set; }

        public int Score { get; set; }
    }
}