using Microsoft.AspNetCore.Mvc;
using ReadingPlatform.Web.Models;

namespace ReadingPlatform.Web.Controllers;

public class ShelvesController : Controller
{
    public IActionResult Index()
    {
        var titles = BookTitle.GetSampleBooks();
        return View(titles);
    }
}
