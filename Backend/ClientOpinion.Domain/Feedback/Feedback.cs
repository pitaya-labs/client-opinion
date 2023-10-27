namespace Backend.Domain.Feedback;

public class Feedback
{
    public Guid Id { get; private set; }
    public string? Name { get; private set; }
    public string Comment { get; private set; }
    public int Rating { get; private set; }

    public Company.Company Company { get; set; }
    
    private Feedback(string name, string comment, int rating)
    {
        Id = Guid.NewGuid();
        Name = name;
        Comment = comment;
        Rating = rating;
    }

    // public static Feedback Create(string name, string comment, int rating) => new(name, comment, rating);
}