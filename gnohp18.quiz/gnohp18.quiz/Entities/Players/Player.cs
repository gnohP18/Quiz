using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using gnohp18.quiz.Results;
using Volo.Abp.Domain.Entities.Auditing;

namespace gnohp18.quiz.Players
{
    public class Player : FullAuditedAggregateRoot<Guid>
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string DisplayName { get; set; }

        public int HighestScore { get; set; }

        public ICollection<Result> Results { get; set; }

        public Player()
        {
            Results = new HashSet<Result>();
        }
    }
}