using Tweet.Data.Services.Models.Tweet;

namespace Tweet.Data.Services.Interfaces
{
    public interface ITweetService
    {
        Task<IEnumerable<TweetDto>> GetAsync();
        Task<TweetDto> GetByIdAsync(int id);
        Task<TweetDto> CreateAsync(TweetCreateDto model);
        Task<TweetDto> UpdateByIdAsync(int id, TweetUpdateDto model);
        //Task<TweetDto> PatchByIdAsync(int id, TweetUpdateDto model);
        Task<bool> DeleteByIdAsync(int id);
    }
}
