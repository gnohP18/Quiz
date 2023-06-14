using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Players
{
    public class PlayerAppService : 
        CrudAppService<
            Player, 
            PlayerDto, 
            Guid, 
            ConditionSearchDto, 
            CreateUpdatePlayerDto, 
            CreateUpdatePlayerDto>,
        IPlayerAppService
    {
        private readonly IRepository<Player, Guid> _repository;
        public PlayerAppService(IRepository<Player, Guid> repository): base(repository)
        {
            _repository = repository;
        }
    }
}