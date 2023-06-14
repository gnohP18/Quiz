using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using gnohp18.quiz.Players;
using gnohp18.quiz.TypeOfQuestions;
using Volo.Abp.Domain.Entities.Auditing;

namespace gnohp18.quiz.Results
{
    public class Result :  FullAuditedAggregateRoot<Guid>
    {
        public int NumberOfTrueAnswer { get; set; }

        public int NumberOfFalseAnswer { get; set; }

        public bool IsPass { get; set; }

        [Required(AllowEmptyStrings =true)]

        public string Feedback { get; set; } 

        public DateTimeOffset CompletedTime { get; set; }

        public Guid PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public Guid TypeOfQuestionId { get; set; }
        public virtual TypeOfQuestion TypeOfQuestion { get; set; }

    }
}