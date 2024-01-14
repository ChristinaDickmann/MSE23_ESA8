namespace Library
{
    public class Book
    {
        private string _title { get; }
        private readonly string _author;
        public bool IsAvailable { get; private set; }
        private int _year;
        private string _isbn;
        private string _verlag;

        public Book(string title, String author)
        {
            _title = title;
            _author = author;
            IsAvailable = true;
        }

        public void setAvailable(bool available)
        {
            IsAvailable = available;
        }

        public Book year(int year)
        {
            _year = year;
            return this;
        }

        public Book isbn(string isbn)
        {
            _isbn = isbn;
            return this;
        }

        public Book verlag(string verlag)
        {
            _verlag = verlag;
            return this;
        }

        public override String ToString()
        {
            return $"Title: {_title}, Author: {_author}, Year: {_year}, ISBN: {_isbn}, Verlag: {_verlag}";
        }
    }
}
