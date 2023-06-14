using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gnohp18.quiz.Questions;
using Volo.Abp.Domain.Entities.Auditing;

namespace gnohp18.quiz.Answers
{
    public class Answer : FullAuditedAggregateRoot<Guid>
    {
        public Guid QuestionId { get; set; }
        
        public string Content { get; set; }
        
        public bool IsTrueAnswer { get; set; }

        public virtual Question Question { get; set; }
    }
}