using System.ComponentModel.DataAnnotations;
using gnohp18.quiz.Players;
using gnohp18.quiz.TypeOfQuestions;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Players
{
    public class PlayerResultDto 
    {
        public int NumberOfTrueAnswer { get; set; } = 0;

        public int NumberOfFalseAnswer { get; set; } = 0;

        public bool IsPass { get; set; } = false;

        public string Feedback { get; set; } = "";

        public DateTimeOffset CompletedTime { get; set; } =  DateTimeOffset.Now;

        public Guid PlayerId { get; set; }

        public Guid TypeOfQuestionId { get; set; }
    }
}