namespace Backend.Domain.Profile;

public class Profile
{
    public int Id { get; set; }
    public string? FullName { get; private set; }

    
    public string AppUserId { get; set; }
    public AppUser.AppUser AppUser { get; set; }

    private Profile(string fullName, string appUserId)
    {
        FullName = fullName;
        AppUserId = appUserId;
    }

    public static Profile Create(string fullName, string appUserId)
    {
        return new Profile(fullName, appUserId);
    }
}