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