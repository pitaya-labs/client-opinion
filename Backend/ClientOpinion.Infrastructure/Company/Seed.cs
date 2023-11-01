namespace Backend.Infrastructure.Company;

public static class Seed
{
    public static Domain.Company.Company Create(string name, string description)
    {
        var company = Domain.Company.Company.Create(name, description);
        company.Id = 1;
        
        return company;
    }
}