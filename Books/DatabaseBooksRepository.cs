using System.Collections.Generic;
using System.Data.SqlClient;

namespace Alexandria.Books
{
    public class DatabaseBooksRepository : BooksRepository {
        public IList<Book> GetAll() {
            using (SqlConnection conn = new SqlConnection {
                ConnectionString =
                        "Data Source=localhost; Initial Catalog=Alexandria; Trusted_Connection=Yes;"
            }) {
                conn.Open();
                IList<Book> books = new List<Book>();
                using (SqlCommand command = new SqlCommand("select Id, Title from Book", conn)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            books.Add(new Book() { Id = reader.GetInt64(0), Title = reader.GetString(1)});
                        }
                    }
                }
                return books;
            }
        }
    }
}
