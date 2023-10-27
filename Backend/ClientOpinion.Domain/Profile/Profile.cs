namespace Backend.Domain.Profile;

public class Profile
{
    public int Id { get; private set; }
    public string? FullName { get; private set; }

    public string AppUserId { get; set; }
    public AppUser.AppUser AppUser { get; set; }
}