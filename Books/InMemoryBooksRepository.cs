using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Alexandria.Books
{
    public class InMemoryBooksRepository : BooksRepository {
        private readonly IDictionary<long, Book> _books;
        private int _nextId = 0;

        public InMemoryBooksRepository() {
            _books = new ConcurrentDictionary<long, Book>();
            AddBook(new Book() { Id = 0, Title = "Mr. Gwyn", Authors = new string[] { "Alessandro Baricco" } });
            AddBook(new Book() { Id = 1, Title = "Castelli di Rabbia", Authors = new string[] { "Alessandro Baricco" } });
            AddBook(new Book() { Id = 2, Title = "Oceano mare", Authors = new string[] { "Alessandro Baricco" } });
            AddBook(new Book() { Id = 3, Title = "Refactoring", Authors = new string[] { "Martin Fowler" } });
        }

        private void AddBook(Book book)
        {
            _books.Add(_nextId, book);
            _nextId++;
        }

        public IList<Book> GetAll()
        {
            return _books.Values.ToList();
        }
    }
}
