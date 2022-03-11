using System.ComponentModel.DataAnnotations;

namespace Tweet.Data.Services.Models.Tweet
{
    public class TweetUpdateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
