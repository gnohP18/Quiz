using gnohp18.quiz.Questions;
using gnohp18.quiz.Results;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities.Auditing;

namespace gnohp18.quiz.TypeOfQuestions
{
    public class CreateUpdateTypeOfQuestionDto
    {
        public string Type { get; set; }

        public int Level { get; set; }
    }
}