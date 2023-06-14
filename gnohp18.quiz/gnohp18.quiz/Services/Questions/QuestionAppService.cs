using gnohp18.quiz.Answers;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace gnohp18.quiz.Questions
{
    public class QuestionAppService : 
        CrudAppService<
            Question, 
            QuestionDto, 
            Guid, 
            ConditionSearchDto, 
            CreateUpdateQuestionDto, 
            CreateUpdateQuestionDto>,
        IQuestionAppService
    {
        private readonly IRepository<Question, Guid> _repository;
        private readonly IRepository<Answer, Guid> _answerRepository;
        public QuestionAppService(
            IRepository<Question, Guid> repository, 
            IRepository<Answer, Guid> answerRepository): base(repository)
        {
            _repository = repository;
            _answerRepository = answerRepository;
        }

        public async Task<List<QuestionAnswerDto>> LoadListQuestionAnswerByTypeAsync(Guid typeOfQuestionId)
        {
            var listQuestionAnswerDto = new List<QuestionAnswerDto>();
            var listQuestionAnswer = await _repository.GetListAsync(x => x.TypeOfQuestionId == typeOfQuestionId);
            foreach (var question in listQuestionAnswer)
            {
                var questionAnswer = new QuestionAnswerDto();
                questionAnswer.TypeOfQuestionId = question.TypeOfQuestionId;
                questionAnswer.Content = question.Content;
                questionAnswer.Score = question.Score;

                var answer = await _answerRepository.GetListAsync(x => x.QuestionId == question.Id);
                var answerList = answer != null ? ObjectMapper.Map<List<Answer>, List<AnswerDetailDto>>(answer) : null;
                questionAnswer.AnswerList = answerList;
                listQuestionAnswerDto.Add(questionAnswer);
            }

            return listQuestionAnswerDto;
        }

        public async Task<QuestionAnswerDto> LoadQuestionAnswerByIdAsync(Guid questionId)
        {
            var questionAnswer = new QuestionAnswerDto();
            var question = await _repository.GetAsync(questionId);
            questionAnswer.TypeOfQuestionId = question.TypeOfQuestionId;
            questionAnswer.Content = question.Content;
            questionAnswer.Score = question.Score;

            var answer = await _answerRepository.GetListAsync(x => x.QuestionId == questionId);
            var answerList = answer != null ? ObjectMapper.Map<List<Answer>, List<AnswerDetailDto>>(answer) : null;
            questionAnswer.AnswerList = answerList;
            return questionAnswer;
        }

        public async Task<bool> ValidateAnswerAsync(Guid questionId, Guid answerId)
        {
            return (await _answerRepository.FindAsync(x => x.Id == answerId && x.QuestionId == questionId)).IsTrueAnswer;
        }
    }
}