namespace Library
{
    public class LendingSystem
    {
        private readonly List<Book> _books = new List<Book>();

        public void addBook(Book book)
        {
            _books.Add(book);
        }

        public List<Book> getAvailableBooks()
        {
            var availableBooks = new List<Book>();

            foreach (Book book in _books)
            {
                if (book.IsAvailable)
                    availableBooks.Add(book);
            }

            return availableBooks;
        }
    }
}
