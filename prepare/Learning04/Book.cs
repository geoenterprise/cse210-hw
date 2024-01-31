


namespace library_demo
{
    public class Book
    {
        protected string _author = "";
        protected string _title = "";

        
        public string GetAuthor()
        {
            return _author;
        }
        public string SetAuthor(string author)
        {
            return _author;
        }

        public string GetTitle()
        {
            return _title;
        }
        public string SetTitle(string title)
        {
            return _title;
        }
        public string GetBookInfo()
        {
            return $"{_title} by {_author}";

        }
    }
}