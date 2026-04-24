using Microsoft.AspNetCore.Mvc;
using ReadingPlatform.Web.Models;

namespace ReadingPlatform.Web.Controllers;

public class CatalogController : Controller
{
    public IActionResult Index(string? search, string? format)
    {
        var books = BookTitle.GetSampleBooks().AsEnumerable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            var query = search.Trim().ToLower();
            books = books.Where(b =>
                b.TitleName.ToLower().Contains(query) ||
                b.AuthorName.ToLower().Contains(query) ||
                b.Genre.ToLower().Contains(query));
        }

        if (!string.IsNullOrWhiteSpace(format))
        {
            books = books.Where(b => string.Equals(b.Format, format, StringComparison.OrdinalIgnoreCase));
        }

        ViewBag.Search = search;
        ViewBag.Format = format;
        ViewBag.Formats = BookTitle.GetSampleBooks()
            .Select(b => b.Format)
            .Distinct()
            .OrderBy(f => f)
            .ToList();

        return View(books.OrderByDescending(b => b.AverageRating).ToList());
    }

    public IActionResult Details(int id)
    {
        var book = BookTitle.GetSampleBooks().FirstOrDefault(b => b.Id == id);
        if (book is null)
        {
            return NotFound();
        }

        return View(book);
    }
}
