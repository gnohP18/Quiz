using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.TypeOfQuestions
{
    public class TypeOfQuestionAppService : 
        CrudAppService<
            TypeOfQuestion, 
            TypeOfQuestionDto, 
            Guid, 
            ConditionSearchDto, 
            CreateUpdateTypeOfQuestionDto, 
            CreateUpdateTypeOfQuestionDto>,
        ITypeOfQuestionAppService
    {
        private readonly IRepository<TypeOfQuestion, Guid> _repository;
        public TypeOfQuestionAppService(IRepository<TypeOfQuestion, Guid> repository): base(repository)
        {
            _repository = repository;
        }
    }
}