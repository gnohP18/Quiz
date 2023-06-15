using gnohp18.quiz.Answers;
using gnohp18.quiz.TypeOfQuestions;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Players
{
    public class PlayerAnswerDto
    {
        public string Content { get; set; }
        
        public bool IsTrueAnswer { get; set; }
    }
}