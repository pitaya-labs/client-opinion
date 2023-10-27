using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infrastructure.Feedback;

public class FeedbackConfiguration: IEntityTypeConfiguration<Domain.Feedback.Feedback>    
{
    public void Configure(EntityTypeBuilder<Domain.Feedback.Feedback> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).HasMaxLength(200);
        builder.Property(x => x.Comment).IsRequired();
        builder.Property(x => x.Rating).IsRequired();
    }
}