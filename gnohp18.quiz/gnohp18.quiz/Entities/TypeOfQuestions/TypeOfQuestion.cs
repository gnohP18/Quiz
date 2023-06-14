using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gnohp18.quiz.Questions;
using gnohp18.quiz.Results;
using Volo.Abp.Domain.Entities.Auditing;

namespace gnohp18.quiz.TypeOfQuestions
{
    public class TypeOfQuestion :  FullAuditedAggregateRoot<Guid>
    {
        public string Type { get; set; }

        public int Level { get; set; }

        public Guid ResultId { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<Result> Results { get; set; }

        public TypeOfQuestion()
        {
            Questions = new HashSet<Question>();
            Results = new HashSet<Result>();
        }
    }
}