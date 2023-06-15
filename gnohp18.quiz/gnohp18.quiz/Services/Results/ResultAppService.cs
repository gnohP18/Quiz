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

        public async Task<ResultDto> FeedbackAsync(Guid resultId, string feedback)
        {
            var result = await _repository.FindAsync(resultId);
            result.Feedback = feedback;
            await _repository.UpdateAsync(result);

            return ObjectMapper.Map<Result, ResultDto>(result);
        }

        public async Task<List<ResultDto>> GetResultByPlayerIdAsync(Guid playerId)
        {
            var listResult = await _repository.GetListAsync(x => x.PlayerId == playerId);
            return ObjectMapper.Map<List<Result>, List<ResultDto>>(listResult);
        }
    }
}