using AutoMapper;
using Tweet.Data.Services.Models.Tweet;

namespace Tweet.Data.Services.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Models.Tweet.Tweet, TweetDto>().ReverseMap();
            CreateMap<Data.Models.Tweet.Tweet, TweetCreateDto>().ReverseMap();
            CreateMap<Data.Models.Tweet.Tweet, TweetUpdateDto>().ReverseMap();
        }
    }
}
