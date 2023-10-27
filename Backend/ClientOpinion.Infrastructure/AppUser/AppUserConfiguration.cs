using Backend.Domain.Profile;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infrastructure.AppUser;

public class AppUserConfiguration: IEntityTypeConfiguration<Domain.AppUser.AppUser>
{
    public void Configure(EntityTypeBuilder<Domain.AppUser.AppUser> builder)
    {
        builder.HasOne(x => x.Profile)
            .WithOne(x => x.AppUser);
    }
}

public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
    }
}