namespace Backend.Domain.Company;

public class Company
{
    public int Id { get; private set; }
    public string? Name { get; private set; }
    public string? Description { get; private set; }

    public List<Feedback.Feedback> Feedbacks { get; set; }
}