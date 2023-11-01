namespace Backend.Infrastructure.Company;

public static class Seed
{
    public static Domain.Company.Company Create(string name, string description) => Domain.Company.Company.Create(name, description);
}