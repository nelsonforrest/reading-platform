using Microsoft.AspNetCore.Mvc;
using ReadingPlatform.Web.Models;

namespace ReadingPlatform.Web.Controllers;

public class CommunityController : Controller
{
    public IActionResult Index()
    {
        return View(BookTitle.GetSampleBooks().Take(3).ToList());
    }
}
