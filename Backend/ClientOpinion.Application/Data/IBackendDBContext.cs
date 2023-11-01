using Backend.Domain.AppUser;
using Backend.Domain.Company;
using Backend.Domain.Feedback;
using Backend.Domain.Profile;
using Microsoft.EntityFrameworkCore;

namespace Backend.Application.Data;

public interface IBackendDBContext
{
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}