using Backend.Domain.Feedback;

namespace Backend.Infrastructure.Feedback;

public static class Seed
{
    public static Domain.Feedback.Feedback Create(string name, string comment, RatingTypes rating, int companyId) => 
        Domain.Feedback.Feedback.Create(name, comment, rating, companyId);
}