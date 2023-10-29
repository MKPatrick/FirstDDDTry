using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAppBackend.DTO.Book.AddBook;
using TestAppBackend.Services;

namespace TestAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }


        [HttpPost(nameof(AddBook))]
        public async Task<IActionResult> AddBook([FromBody] AddBookRequest addBookRequest)
        {
            return Ok(await bookService.AddBook(addBookRequest));
        }

    }
}
