namespace Backend.Domain.Company;

public class Company
{
    public int Id { get; set; }
    public string? Name { get; private set; }
    public string? Description { get; private set; }

    public List<Feedback.Feedback> Feedbacks { get; set; } = new();
    
    private Company(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public static Company Create(string name, string description)
    {
        return new Company(name, description);
    }
}