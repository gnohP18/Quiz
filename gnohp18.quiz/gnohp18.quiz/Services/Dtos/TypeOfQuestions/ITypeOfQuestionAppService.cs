using Volo.Abp.Application.Services;

namespace gnohp18.quiz.TypeOfQuestions
{
    public interface ITypeOfQuestionAppService : 
        ICrudAppService<
            TypeOfQuestionDto,
            Guid,
            ConditionSearchDto,
            CreateUpdateTypeOfQuestionDto,
            CreateUpdateTypeOfQuestionDto>
    {  
    }
}