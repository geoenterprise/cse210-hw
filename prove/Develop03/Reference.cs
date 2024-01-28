public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        // Display the reference as "Book Chapter:Verse-EndVerse"
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else //I think this line could be ommited.
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

    // Display the reference with hidden words
    public string GetDisplayTextWithHiddenWords(List<Word> words)
    {
        // Display the reference and the text with hidden words
        string displayText = $"{GetDisplayText()}\n";

        // Concatenate each word, showing or hiding based on its status
        foreach (Word word in words)
        {
            if (word.IsHidden())
            {
                displayText += " __________ ";
            }
            else
            {
                displayText += $"{word.GetText()} ";
            }
        }

        return displayText;
    }
}