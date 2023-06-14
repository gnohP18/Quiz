using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gnohp18.quiz.Answers
{
    public class AnswerAppService : 
        CrudAppService<
            Answer, 
            AnswerDto, 
            Guid, 
            ConditionSearchDto, 
            CreateUpdateAnswerDto, 
            CreateUpdateAnswerDto>,
        IAnswerAppService
    {
        private readonly IRepository<Answer, Guid> _repository;
        public AnswerAppService(IRepository<Answer, Guid> repository): base(repository)
        {
            _repository = repository;
        }
    }
}