using AutoMapper;
using Oski_Test.DataModels;
using Oski_Test.DomainModels;

namespace Oski_Test.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Test, TestDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<Answer, AnswerDto>().ReverseMap();
        }
        
    }
}
