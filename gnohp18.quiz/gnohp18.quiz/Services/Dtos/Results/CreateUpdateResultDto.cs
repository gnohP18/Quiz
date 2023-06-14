using System.ComponentModel.DataAnnotations;
using gnohp18.quiz.Players;
using gnohp18.quiz.TypeOfQuestions;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Results
{
    public class CreateUpdateResultDto
    {
        public int NumberOfTrueAnswer { get; set; }

        public int NumberOfFalseAnswer { get; set; }

        public bool IsPass { get; set; }

        public string Feedback { get; set; } 

        public DateTimeOffset CompletedTime { get; set; }

        public Guid PlayerId { get; set; }

        public Guid TypeOfQuestionId { get; set; }
    }
}