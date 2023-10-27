using Backend.Domain.Company;
using Backend.Domain.Feedback;
using Microsoft.EntityFrameworkCore;

namespace Backend.Application.Data;

public interface IBackendDBContext
{
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Company> Companies { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}