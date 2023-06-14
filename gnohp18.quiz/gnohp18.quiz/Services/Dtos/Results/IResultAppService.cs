using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace gnohp18.quiz.Results
{
    public interface IResultAppService : 
        ICrudAppService<
            ResultDto,
            Guid,
            ConditionSearchDto,
            CreateUpdateResultDto,
            CreateUpdateResultDto>
    {  
    }
}