using AutoMapper;
using gnohp18.quiz.Answers;
using gnohp18.quiz.Players;
using gnohp18.quiz.Questions;
using gnohp18.quiz.Results;
using gnohp18.quiz.TypeOfQuestions;

namespace gnohp18.quiz.ObjectMapping;

public class quizAutoMapperProfile : Profile
{
    public quizAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */
        CreateMap<TypeOfQuestion, TypeOfQuestionDto>();
            // .ForMember(des => des.Type, 
            //     act => act.MapFrom(scr => scr.Type))
            // .ForMember(des => des.Level, 
            //     act => act.MapFrom(scr => scr.Level));
        CreateMap<CreateUpdateTypeOfQuestionDto, TypeOfQuestion>();

        CreateMap<CreateUpdateResultDto, Result>();
        CreateMap<Result, ResultDto>();
        CreateMap<ResultDto, Result>();

        CreateMap<CreateUpdatePlayerDto, Player>();
        CreateMap<PlayerResultDto, Result>();
        CreateMap<Player, PlayerDto>();
        CreateMap<Answer, PlayerAnswerDto>();

        CreateMap<CreateUpdateQuestionDto, Question>();
        CreateMap<Question, QuestionDto>();

        CreateMap<CreateUpdateAnswerDto, Answer>();
        CreateMap<Answer, AnswerDto>();
        CreateMap<Answer, AnswerDetailDto>();
    }
}
