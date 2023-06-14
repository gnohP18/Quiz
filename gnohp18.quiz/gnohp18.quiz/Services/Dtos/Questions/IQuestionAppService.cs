using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace gnohp18.quiz.Questions
{
    public interface IQuestionAppService : 
        ICrudAppService<
            QuestionDto,
            Guid,
            ConditionSearchDto,
            CreateUpdateQuestionDto,
            CreateUpdateQuestionDto>
    {  
        Task<List<QuestionAnswerDto>> LoadListQuestionAnswerByTypeAsync(Guid TypeOfQuestionId);

        Task<QuestionAnswerDto> LoadQuestionAnswerByIdAsync(Guid questionId);
        
        Task<bool> ValidateAnswerAsync(Guid questionId, Guid answerId);
    }
}