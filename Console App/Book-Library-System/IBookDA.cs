namespace BookLibrarySystem
{
    public interface IBookDA
    {
        List<Book> GetBooks();
        Book GetBookByTitle(string? title);
    }
}