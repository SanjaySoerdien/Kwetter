using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tweet.Data.Services.Interfaces;
using Tweet.Data.Services.Models.Tweet;

namespace Tweet.Data.Services
{
    public class TweetService : ITweetService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TweetService(ApplicationDbContext context,
                            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TweetDto>> GetAsync()
        {
            var dbTweets = await _context.Tweets.ToListAsync();

            return _mapper.Map<IEnumerable<TweetDto>>(dbTweets);
        }

        public async Task<TweetDto> GetByIdAsync(int id)
        {
            var dbTweet = await _context.Tweets.FirstOrDefaultAsync(t => t.Id == id);

            return _mapper.Map<TweetDto>(dbTweet);
        }

        public async Task<TweetDto> CreateAsync(TweetCreateDto model)
        {
            var tweetToAdd = _mapper.Map<Data.Models.Tweet.Tweet>(model);

            _context.Add(tweetToAdd);
            await _context.SaveChangesAsync();

            return _mapper.Map<TweetDto>(tweetToAdd);
        }

        public async Task<TweetDto> UpdateByIdAsync(int id, TweetUpdateDto model)
        {
            var dbTweet = await _context.Tweets.FirstOrDefaultAsync(t => t.Id == id);

            _mapper.Map(model, dbTweet);
            await _context.SaveChangesAsync();

            return _mapper.Map<TweetDto>(dbTweet);
        }

        //public async Task<TweetDto> PatchByIdAsync(int id, JsonPatchDocument<TweetUpdateDto> patch)
        //{
        //    var dbTweet = await _context.Tweets.FirstOrDefaultAsync(t => t.Id == id);

        //    var updateModel = _mapper.Map<TweetUpdateDto>(dbTweet);
        //    patch.Apply(updateModel);

        //    _mapper.Map(updateModel, dbTweet);
        //    await _context.SaveChangesAsync();

        //    return _mapper.Map<TweetDto>(dbTweet);
        //}

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var dbTweet = await _context.Tweets.FirstOrDefaultAsync(t => t.Id == id);

            _context.Tweets.Remove(dbTweet);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
