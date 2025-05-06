using Microsoft.AspNetCore.Mvc
namespace LibraryAPI.Models
{
    public class Book
    {
        [FromRoute(Name = "id")]
        public int Id { get; set; }

        [FromQuery]
        public string Category { get; set; }

        [FromHeader(Name = "X-User-Id")]
        public string UserId { get; set; }

        [FromBody]
        public BookDetails Details { get; set; }
        
    }
}
