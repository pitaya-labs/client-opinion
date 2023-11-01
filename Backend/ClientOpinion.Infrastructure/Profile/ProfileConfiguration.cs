using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infrastructure.Profile;

public class ProfileConfiguration : IEntityTypeConfiguration<Domain.Profile.Profile>
{
    public void Configure(EntityTypeBuilder<Domain.Profile.Profile> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
    }
}