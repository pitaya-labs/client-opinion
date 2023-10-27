using Microsoft.AspNetCore.Identity;

namespace Backend.Domain.AppUser;

public class AppUser: IdentityUser
{

    public Profile.Profile Profile { get; set; }
}