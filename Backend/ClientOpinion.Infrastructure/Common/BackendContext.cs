using Backend.Application.Data;
using Backend.Domain.Feedback;
using Backend.Infrastructure.AppUser;
using Backend.Infrastructure.Company;
using Backend.Infrastructure.Feedback;
using Backend.Infrastructure.Profile;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProfileSeed = Backend.Infrastructure.Profile.Seed;
using UserSeed = Backend.Infrastructure.AppUser.Seed;
using CompanySeed = Backend.Infrastructure.Company.Seed;
using FeedbackSeed = Backend.Infrastructure.Feedback.Seed;

namespace Backend.Infrastructure.Common;

public class BackendContext: IdentityDbContext<Domain.AppUser.AppUser>, IBackendDBContext
{
    public BackendContext(DbContextOptions<BackendContext> options) : base(options) { }


    public DbSet<Domain.Feedback.Feedback> Feedbacks { get; set; }
    public DbSet<Domain.Company.Company> Companies { get; set; }
    public DbSet<Domain.AppUser.AppUser> AppUsers { get; set; }
    public DbSet<Domain.Profile.Profile> Profiles { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new CompanyConfiguration());
        builder.ApplyConfiguration(new FeedbackConfiguration());
        builder.ApplyConfiguration(new AppUserConfiguration());
        builder.ApplyConfiguration(new ProfileConfiguration());

        var userTest = UserSeed.Create();
        var profileTest = ProfileSeed.Create("Alberto Ramirez", userTest.Id);
        var company = CompanySeed.Create("Pets Company", "Care pets company");
        var feedback = FeedbackSeed.Create("Awesome service", "the care with my dog was amazing", RatingTypes.VerySatisfactory, company.Id);

        builder.Entity<Domain.AppUser.AppUser>().HasData(userTest);
        builder.Entity<Domain.Profile.Profile>().HasData(profileTest);
        builder.Entity<Domain.Company.Company>().HasData(company);
        builder.Entity<Domain.Feedback.Feedback>().HasData(feedback);
    }
}