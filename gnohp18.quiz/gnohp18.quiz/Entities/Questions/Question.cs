using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gnohp18.quiz.Answers;
using gnohp18.quiz.TypeOfQuestions;
using Volo.Abp.Domain.Entities.Auditing;

namespace gnohp18.quiz.Questions
{
    public class Question : FullAuditedAggregateRoot<Guid>
    {
        public Guid TypeOfQuestionId { get; set; }

        public string Content { get; set; }

        public int Score { get; set; }

        public virtual TypeOfQuestion TypeOfQuestion { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public Question()
        {
            Answers = new HashSet<Answer>();
        }
    }
}