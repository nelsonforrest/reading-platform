namespace ReadingPlatform.Web.Models
{
    public class BookTitle
    {
        public int Id { get; set; }
        public string TitleName { get; set; } = "";
        public string AuthorName { get; set; } = "";
        public string Format { get; set; } = "";
        public string Genre { get; set; } = "";
        public double AverageRating { get; set; }

        public BookTitle(int id, string titleName, string authorName, string format, string genre, double averageRating)
        {
            Id = id;
            TitleName = titleName;
            AuthorName = authorName;
            Format = format;
            Genre = genre;
            AverageRating = averageRating;
        }

        public static List<BookTitle> GetSampleBooks() => new List<BookTitle>
        {
            new BookTitle(1, "Dungeon Crawler Carl", "Matt Dinniman", "Novel", "Fantasy", 4.8),
            new BookTitle(2, "Solo Leveling", "Chugong", "Manhwa", "Action", 4.7),
            new BookTitle(3, "Berserk", "Kentaro Miura", "Manga", "Dark Fantasy", 4.9),
            new BookTitle(4, "The Hobbit", "J.R.R. Tolkien", "Novel", "Fantasy", 4.8),
            new BookTitle(5, "One Piece", "Eiichiro Oda", "Manga", "Adventure", 4.9)
        };
    }
}
