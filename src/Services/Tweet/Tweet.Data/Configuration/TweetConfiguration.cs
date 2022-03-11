using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tweet.Data.Configuration
{
    public class TweetConfiguration : IEntityTypeConfiguration<Models.Tweet.Tweet>
    {
        public void Configure(EntityTypeBuilder<Models.Tweet.Tweet> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasIndex(t => t.Name)
                .IsUnique();
            builder.Property(t => t.Name)
                .IsRequired();
        }
    }
}
