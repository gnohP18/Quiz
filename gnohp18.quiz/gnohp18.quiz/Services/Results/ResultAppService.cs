using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Results
{
    public class ResultAppService : 
        CrudAppService<
            Result, 
            ResultDto, 
            Guid, 
            ConditionSearchDto, 
            CreateUpdateResultDto, 
            CreateUpdateResultDto>,
        IResultAppService
    {
        private readonly IRepository<Result, Guid> _repository;
        public ResultAppService(IRepository<Result, Guid> repository): base(repository)
        {
            _repository = repository;
        }
    }
}