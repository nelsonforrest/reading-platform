using Microsoft.AspNetCore.Mvc;
using ReadingPlatform.Web.Models;

namespace ReadingPlatform.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookTitlesController : ControllerBase
{
    [HttpGet("/BookTitles")]
    public IActionResult CatalogPage()
    {
        return RedirectToAction("Index", "Catalog");
    }

    [HttpGet]
    public ActionResult<IEnumerable<BookTitle>> Get()
    {
        return Ok(BookTitle.GetSampleBooks());
    }

    [HttpGet("{id:int}")]
    public ActionResult<BookTitle> GetById(int id)
    {
        var book = BookTitle.GetSampleBooks().FirstOrDefault(b => b.Id == id);
        return book is null ? NotFound() : Ok(book);
    }
}
