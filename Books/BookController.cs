using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Alexandria.Books {
    [Route("api/book")]
    public class BookController : Controller {
        private readonly BooksRepository _repo;

        public BookController(BooksRepository repo) {
            _repo = repo;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll() {
            IList<Book> books = _repo.GetAll();

            return new OkObjectResult(books);
        }
    }
}