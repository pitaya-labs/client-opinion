using Microsoft.AspNetCore.Identity;

namespace Backend.Infrastructure.AppUser;

public static class Seed
{
    public static Domain.AppUser.AppUser Create()
    {
        var user = new Domain.AppUser.AppUser()
        {
            UserName = "user.test@email.com",
            Email = "user.test@email.com",
            EmailConfirmed = true,
            Id = Guid.NewGuid().ToString()
        };

        var hasher = new PasswordHasher<Domain.AppUser.AppUser>();
        user.PasswordHash = hasher.HashPassword(user, "clamato con cheve");

        return user;
    }
}