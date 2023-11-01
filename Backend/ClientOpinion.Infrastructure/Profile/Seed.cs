namespace Backend.Infrastructure.Profile;

public static class Seed
{
    public static Domain.Profile.Profile Create(string fullName, string userId)
    {
        var profile = Domain.Profile.Profile.Create(fullName, userId);
        profile.Id = 1;
        return profile;
    }
}