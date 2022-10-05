namespace BookLibrarySystem
{
    //UI (Infrastructure)
    class Program
    {

        static void Main(string[] args)
        {
            //a logic layer interface might have different implementing derived classes, and same for data layer interfaces
            //Pass to the logic layer class (BookLogic) the needed data class (BookDA)

            //Inversion of Control
            IBookLogic bookLogic = new BookLogic(new BookDA());

            foreach (var b in bookLogic.GetBooks())
            {
                Console.WriteLine("Book Title: " + b.Title + "\nBook Description: " + b.Description + "\n");
            }
        }
    }
}