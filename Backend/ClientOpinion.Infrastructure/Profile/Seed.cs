namespace Backend.Infrastructure.Profile;

public static class Seed
{
    public static Domain.Profile.Profile Create(string fullName, string userId)
    {
        return Domain.Profile.Profile.Create(fullName, userId);
    }
}