namespace BookLibrarySystem
{
    public interface IBookLogic
    {
        List<Book> GetBooks();
        Book GetBookByTitle(string title);
    }
}