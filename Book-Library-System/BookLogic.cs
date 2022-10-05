namespace BookLibrarySystem
{
    //higher level object
    public class BookLogic : IBookLogic
    {

        IBookDA bookDA;

        public BookLogic(IBookDA bookDA)
        {
            this.bookDA = bookDA;
        }

        public List<Book> GetBooks()
        {
            return bookDA.GetBooks();
        }


        public Book GetBookByTitle(string title)
        {
            return bookDA.GetBookByTitle(title);
        }
    }
}

