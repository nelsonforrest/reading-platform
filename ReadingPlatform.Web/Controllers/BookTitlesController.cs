using Microsoft.AspNetCore.Mvc;
using ReadingPlatform.Web.Models;

namespace ReadingPlatform.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookTitlesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<BookTitle> Get()
        {
            return BookTitle.GetSampleBooks();
        }
    }
}