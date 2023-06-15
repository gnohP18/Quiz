using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Dtos;
using gnohp18.quiz.Questions;
using gnohp18.quiz.Answers;
using gnohp18.quiz.Results;

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
        private readonly IRepository<Question, Guid> _questionRepository;
        private readonly IRepository<Answer, Guid> _answerRepository;
        private readonly IRepository<Result, Guid> _resultRepository;
        public PlayerAppService(
            IRepository<Player, Guid> repository, 
            IRepository<Question, Guid> questionRepository, 
            IRepository<Answer, Guid> answerRepository,
            IRepository<Result, Guid> resultRepository): base(repository)
        {
            _repository = repository;
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
            _resultRepository = resultRepository;
        }

        public async Task PlayerAnswerValidateAsync(Guid playerId, Guid questionId, Guid answerId)
        {
            var result = (await _answerRepository.FindAsync(x => x.Id == answerId && x.QuestionId == questionId)).IsTrueAnswer;
            var listNewestResult = await _resultRepository.GetListAsync(x => x.PlayerId == playerId);
            var newestResult = listNewestResult.LastOrDefault();
            if (newestResult != null)
            {
                if (result)
                {
                    newestResult.NumberOfTrueAnswer++;
                }
                else
                {
                    newestResult.NumberOfFalseAnswer++;
                }
                newestResult.CompletedTime = DateTimeOffset.Now;
                await _resultRepository.UpdateAsync(newestResult);
            }
        }

        public async Task<List<QuestionAnswerDto>> PlayGameWithTypeOfQuestionAsync(Guid playerId, Guid typeOfQuestionId)
        {
            var listQuestionAnswerDto = new List<QuestionAnswerDto>();
            var listQuestionAnswer = await _questionRepository.GetListAsync(x => x.TypeOfQuestionId == typeOfQuestionId);
            foreach (var question in listQuestionAnswer)
            {
                var questionAnswer = new QuestionAnswerDto();
                questionAnswer.TypeOfQuestionId = question.TypeOfQuestionId;
                questionAnswer.Content = question.Content;
                questionAnswer.Score = question.Score;

                var answer = await _answerRepository.GetListAsync(x => x.QuestionId == question.Id);
                var answerList = answer != null ? ObjectMapper.Map<List<Answer>, List<PlayerAnswerDto>>(answer) : null;
                questionAnswer.AnswerList = answerList;
                listQuestionAnswerDto.Add(questionAnswer);
            }

            var record = new PlayerResultDto();
            record.PlayerId = playerId;
            record.TypeOfQuestionId = typeOfQuestionId;

            await _resultRepository.InsertAsync(ObjectMapper.Map<PlayerResultDto, Result>(record));

            return listQuestionAnswerDto;
        }
    }
}