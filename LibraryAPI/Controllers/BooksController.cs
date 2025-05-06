using LibraryAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpPost("{id}")]
        public IActionResult CreateBook(
            [FromRoute] int id,
            [FromQuery] string category,
            [FromHeader(Name = "X-User-Id")] string userId,
            [FromBody] BookDetails details)
        {
            // Your logic to store the data (e.g., in a database)
            // For demonstration, we'll just return the data in a response.
            var response = new
            {
                BookId = id,
                Category = category,
                UserId = userId,
                Title = details.Title,
                Author = details.Author,
                Year = details.Year
            };
            return Ok(response);
        }
    }
}
