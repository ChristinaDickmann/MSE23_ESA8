namespace Library
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            LendingSystem lendingSystem = new LendingSystem();

            lendingSystem.addBook(new Book("Stolz und Vorurteil", "Jane Austen").year(1813).isbn("9783868206388").verlag("Nikol Verlagsges.mbH"));
            lendingSystem.addBook(new Book("Reise zum Mittelpunkt der Erde", "Jules Verne").isbn("9783649644699").verlag("Coppenrath F").year(1864));
            lendingSystem.addBook(new Book("Der alte Mann und das Meer", "Ernest Hemingway").year(1952));

            List<Book> books = lendingSystem.getAvailableBooks();

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}