using LibraryAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]/[action]")]
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

        [HttpPost("{id}")]
        public IActionResult CreateABook(Book request)
        {
            // Logic to store the data in the database would go here.
            // For demonstration, we'll return the received data as a response.
            var response = new
            {
                BookId = request.Id,
                Category = request.Category,
                UserId = request.UserId,
                Title = request.Details.Title,
                Author = request.Details.Author,
                Year = request.Details.Year
            };

            return Ok(response);
        }
    }
}
