namespace BookLibrarySystem
{
    public class Book
    {

        private string? title;
        private string? description;

        public Book(string? title, string? description)
        {
            this.title = title;
            this.description = description;
        }

        public string? Title
        {
            get { return title; }
            set { title = value; }

        }

        public string? Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
