using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace gnohp18.quiz.Players
{
    public interface IPlayerAppService : 
        ICrudAppService<
            PlayerDto,
            Guid,
            ConditionSearchDto,
            CreateUpdatePlayerDto,
            CreateUpdatePlayerDto>
    {  
    
    }
}