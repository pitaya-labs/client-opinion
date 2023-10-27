using Backend.Application.Data;
using Backend.Infrastructure.AppUser;
using Backend.Infrastructure.Company;
using Backend.Infrastructure.Feedback;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infrastructure.Common;

public class BackendContext: IdentityDbContext<IdentityUser>, IBackendDBContext
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
    }
}