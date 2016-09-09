using System.Collections.Generic;

namespace Alexandria.Books
{
    public interface BooksRepository {
        IList<Book> GetAll();
    }
}
