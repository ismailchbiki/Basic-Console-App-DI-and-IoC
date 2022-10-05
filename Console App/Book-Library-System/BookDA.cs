namespace BookLibrarySystem
{
    public class BookDA : IBookDA
    {

        private List<Book> books = new List<Book>()
        {
            new Book("DI", "Dependency Injection Book"),
            new Book("SOLID", "Solid Principles Book"),
            new Book("DRY", "Don't repeat yourself Book")
        };


        public List<Book> GetBooks()
        {
            return books;
        }


        public Book GetBookByTitle(string? title)
        {
            // FirstOrDefault is a link query
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            return book;
        }
    }
}

