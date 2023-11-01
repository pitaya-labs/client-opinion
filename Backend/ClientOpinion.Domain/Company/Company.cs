namespace Backend.Domain.Company;

public class Company
{
    public int Id { get; private set; }
    public string? Name { get; private set; }
    public string? Description { get; private set; }

    public List<Feedback.Feedback> Feedbacks { get; set; } = new();
    
    private Company(string name, string description)
    {
        Id = 1;
        Name = name;
        Description = description;
    }

    public static Company Create(string name, string description)
    {
        return new Company(name, description);
    }
}