namespace ReadingPlatform.Web.Models;

public class BookTitle
{
    public int Id { get; set; }
    public string TitleName { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public string Format { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string CoverClass { get; set; } = "cover-default";
    public string Description { get; set; } = string.Empty;
    public string ReadingStatus { get; set; } = string.Empty;
    public int CurrentVolume { get; set; }
    public int TotalVolumes { get; set; }
    public bool PrivateShelfEligible { get; set; }
    public double AverageRating { get; set; }
    public List<Review> Reviews { get; set; } = new();

    public string ProgressLabel => TotalVolumes > 0
        ? $"Volume {CurrentVolume} of {TotalVolumes}"
        : "Standalone title";

    public static List<BookTitle> GetSampleBooks()
    {
        return new List<BookTitle>
        {
            new()
            {
                Id = 1,
                TitleName = "Dungeon Crawler Carl",
                AuthorName = "Matt Dinniman",
                Format = "Novel",
                Genre = "Fantasy",
                CoverClass = "cover-carl",
                Description = "A chaotic progression fantasy adventure with high stakes, dark comedy, and an audience inside the dungeon.",
                ReadingStatus = "Currently Reading",
                CurrentVolume = 3,
                TotalVolumes = 7,
                PrivateShelfEligible = true,
                AverageRating = 4.8,
                Reviews = new()
                {
                    new() { ReviewerName = "Lena", Rating = 5.0, Comment = "Funny, weird, and impossible to stop reading." },
                    new() { ReviewerName = "Marcus", Rating = 4.5, Comment = "The pacing is wild in the best way." }
                }
            },
            new()
            {
                Id = 2,
                TitleName = "Solo Leveling",
                AuthorName = "Chugong",
                Format = "Manhwa",
                Genre = "Action",
                CoverClass = "cover-solo",
                Description = "A hunter rises from weakness to overwhelming power through relentless grinding and dangerous dungeon clears.",
                ReadingStatus = "Completed",
                CurrentVolume = 8,
                TotalVolumes = 8,
                PrivateShelfEligible = false,
                AverageRating = 4.7,
                Reviews = new()
                {
                    new() { ReviewerName = "Ava", Rating = 4.5, Comment = "Pure momentum. Great for binge reading." },
                    new() { ReviewerName = "Noah", Rating = 4.9, Comment = "The art and power scaling are ridiculously satisfying." }
                }
            },
            new()
            {
                Id = 3,
                TitleName = "Berserk",
                AuthorName = "Kentaro Miura",
                Format = "Manga",
                Genre = "Dark Fantasy",
                CoverClass = "cover-berserk",
                Description = "A brutal and emotional dark fantasy epic known for its art, intensity, and unforgettable character arcs.",
                ReadingStatus = "On Hold",
                CurrentVolume = 12,
                TotalVolumes = 42,
                PrivateShelfEligible = true,
                AverageRating = 4.9,
                Reviews = new()
                {
                    new() { ReviewerName = "Rin", Rating = 5.0, Comment = "One of the greatest manga ever made." },
                    new() { ReviewerName = "Theo", Rating = 4.8, Comment = "Heavy material, but incredible craft." }
                }
            },
            new()
            {
                Id = 4,
                TitleName = "The Hobbit",
                AuthorName = "J.R.R. Tolkien",
                Format = "Novel",
                Genre = "Fantasy",
                CoverClass = "cover-hobbit",
                Description = "A classic adventure that balances warmth, wonder, and danger while launching an unforgettable journey.",
                ReadingStatus = "Want to Read",
                CurrentVolume = 0,
                TotalVolumes = 0,
                PrivateShelfEligible = false,
                AverageRating = 4.8,
                Reviews = new()
                {
                    new() { ReviewerName = "Emma", Rating = 4.8, Comment = "Comfort reading with genuine adventure." },
                    new() { ReviewerName = "Jon", Rating = 4.7, Comment = "A perfect entry point into fantasy." }
                }
            },
            new()
            {
                Id = 5,
                TitleName = "One Piece",
                AuthorName = "Eiichiro Oda",
                Format = "Manga",
                Genre = "Adventure",
                CoverClass = "cover-onepiece",
                Description = "A massive pirate adventure with long term payoffs, emotional character work, and a huge world to explore.",
                ReadingStatus = "Currently Reading",
                CurrentVolume = 18,
                TotalVolumes = 108,
                PrivateShelfEligible = true,
                AverageRating = 4.9,
                Reviews = new()
                {
                    new() { ReviewerName = "Sage", Rating = 5.0, Comment = "Huge commitment, huge reward." },
                    new() { ReviewerName = "Kai", Rating = 4.8, Comment = "The world building never runs out of surprises." }
                }
            },
            new()
            {
                Id = 6,
                TitleName = "Mistborn",
                AuthorName = "Brandon Sanderson",
                Format = "Novel",
                Genre = "Epic Fantasy",
                CoverClass = "cover-mistborn",
                Description = "A heist driven fantasy with an accessible magic system, memorable twists, and strong ensemble chemistry.",
                ReadingStatus = "Want to Read",
                CurrentVolume = 0,
                TotalVolumes = 3,
                PrivateShelfEligible = true,
                AverageRating = 4.6,
                Reviews = new()
                {
                    new() { ReviewerName = "Piper", Rating = 4.6, Comment = "Smart magic system and very readable." },
                    new() { ReviewerName = "Drew", Rating = 4.5, Comment = "Easy to recommend to fantasy readers." }
                }
            }
        };
    }
}
