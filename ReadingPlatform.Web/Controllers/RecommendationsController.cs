using Microsoft.AspNetCore.Mvc;
using ReadingPlatform.Web.Models;

namespace ReadingPlatform.Web.Controllers;

public class RecommendationsController : Controller
{
    public IActionResult Index()
    {
        var picks = BookTitle.GetSampleBooks()
            .Where(b => b.AverageRating >= 4.7)
            .OrderByDescending(b => b.AverageRating)
            .Take(3)
            .ToList();

        return View(picks);
    }
}
