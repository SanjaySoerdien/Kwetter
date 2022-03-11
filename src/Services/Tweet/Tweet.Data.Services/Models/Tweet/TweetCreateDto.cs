using System.ComponentModel.DataAnnotations;

namespace Tweet.Data.Services.Models.Tweet
{
    public class TweetCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
