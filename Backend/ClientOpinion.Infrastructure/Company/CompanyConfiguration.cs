using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infrastructure.Company;

public class CompanyConfiguration: IEntityTypeConfiguration<Domain.Company.Company>
{
    public void Configure(EntityTypeBuilder<Domain.Company.Company> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(x => x.Description).HasMaxLength(350);

        builder.HasMany(x => x.Feedbacks)
            .WithOne(x => x.Company);
    }
}