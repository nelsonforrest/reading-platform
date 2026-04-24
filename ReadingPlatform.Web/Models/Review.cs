namespace ReadingPlatform.Web.Models;

public class Review
{
    public string ReviewerName { get; set; } = string.Empty;
    public double Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
}
