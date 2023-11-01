namespace Backend.Domain.Feedback;

public class Feedback
{
    public Guid Id { get; private set; }
    public string? Name { get; private set; }
    public string Comment { get; private set; }
    public RatingTypes Rating { get; private set; }

    public int CompanyId { get; set; }
    public Company.Company Company { get; set; }
    
    private Feedback(string name, string comment, RatingTypes rating, int companyId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Comment = comment;
        Rating = rating;
        CompanyId = companyId;
    }

    public static Feedback Create(string name, string comment, RatingTypes rating, int companyId) => new(name, comment, rating, companyId);
}