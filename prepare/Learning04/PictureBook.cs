


namespace library_demo
{
    class PictureBook : Book
    {
        private string _illustrator = "";

        public string GetIllustrator()
        {
            return _illustrator;
        }

        public void SetIllustrator(string illustrator)
        {
            _illustrator = illustrator;
        }
        public string GetPictureBookInfo()
        {
            return $"{_title} by {_author} illustrated by {_illustrator}";
        }
    }
}