using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using gnohp18.quiz.Results;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Players
{
    public class PlayerDto :  EntityDto<Guid>
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string DisplayName { get; set; }

        public int HighestScore { get; set; }

    }
}