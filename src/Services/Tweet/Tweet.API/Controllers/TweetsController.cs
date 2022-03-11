using Microsoft.AspNetCore.Mvc;
using Tweet.Data.Services.Interfaces;
using Tweet.Data.Services.Models.Tweet;

namespace Tweet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TweetsController : ControllerBase
    {
        private readonly ITweetService _tweetService;

        public TweetsController(ITweetService tweetService)
        {
            _tweetService = tweetService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var tweetDtos = await _tweetService.GetAsync();

            return Ok(tweetDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            var tweetDto = await _tweetService.GetByIdAsync(id);

            return Ok(tweetDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] TweetCreateDto model)
        {
            var tweetDto = await _tweetService.CreateAsync(model);

            return Created($"/tweets/{tweetDto.Id}", tweetDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateByIdAsync([FromRoute] int id, [FromBody] TweetUpdateDto model)
        {
            var tweetDto = await _tweetService.UpdateByIdAsync(id, model);

            return Ok(tweetDto);
        }

        //[HttpPatch("{Id}")]
        //public async Task<IActionResult> UpdateByIdAsync([FromRoute] int Id, [FromBody] JsonPatchDocument<TweetUpdateDto> patchCoc)
        //{

        //}

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteByIdAsync([FromRoute] int id)
        {
            var IsDeleted = await _tweetService.DeleteByIdAsync(id);

            if (IsDeleted)
            {
                // Dispatch event to buss -> TweetDeleted(){ id }
                return NoContent();
            }

            return BadRequest("OOPS");
        }
    }
}
