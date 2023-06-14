using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace gnohp18.quiz.Answers
{
    public interface IAnswerAppService : 
        ICrudAppService<
            AnswerDto,
            Guid,
            ConditionSearchDto,
            CreateUpdateAnswerDto,
            CreateUpdateAnswerDto>
    {  
    }
}