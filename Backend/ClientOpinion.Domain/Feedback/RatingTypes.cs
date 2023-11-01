using Ardalis.SmartEnum;

namespace Backend.Domain.Feedback;

public sealed class RatingTypes: SmartEnum<RatingTypes>
{
    public static readonly RatingTypes Poor = new RatingTypes("Poor", 1);
    public static readonly RatingTypes Unsatisfactory = new RatingTypes("Unsatisfactory", 2);
    public static readonly RatingTypes Neutral = new RatingTypes("Neutral", 3);
    public static readonly RatingTypes Satisfactory = new RatingTypes("Satisfactory", 4);
    public static readonly RatingTypes VerySatisfactory = new RatingTypes("VerySatisfactory", 5);

    public RatingTypes(string name, int value): base(name, value)
    {
        
    }
}