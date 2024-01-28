public class Scriptures
{
    private Reference _reference;
    private List<Word> words = new List<Word>();

    // Constructor for creating a scripture with a single verse
    public Scriptures(List<(string book, int chapter, int verse, string text)> scriptureList)
    {
        // Randomly choose a scripture from the list
        Random random = new Random();
        int randomIndex = random.Next(scriptureList.Count);
        var chosenScripture = scriptureList[randomIndex];

        // Initialize the reference and words based on the chosen scripture
        _reference = new Reference(chosenScripture.book, chosenScripture.chapter, chosenScripture.verse);
        words = CreateWordList(chosenScripture.text);
    }

    public Scriptures(List<(string book, int chapter, int startVerse, int endVerse, string text)> scriptureList)
    {
        // Randomly choose a scripture from the list
        Random random = new Random();
        int randomIndex = random.Next(scriptureList.Count);
        var chosenScripture = scriptureList[randomIndex];

        // Initialize the reference and words based on the chosen scripture
        _reference = new Reference(chosenScripture.book, chosenScripture.chapter, chosenScripture.startVerse, chosenScripture.endVerse);
        words = CreateWordList(chosenScripture.text);
    }

    // Helper method to create a list of words from the scripture text
    private List<Word> CreateWordList(string text)
    {
        List<Word> wordList = new List<Word>();

        // Split the text into words and create Word objects
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            wordList.Add(new Word(word));
        }

        return wordList;
    }

    public void HideRandomWords(int numberToHide)
    {
        // Get the indices of words that are not hidden
        List<int> availableIndices = Enumerable.Range(0, words.Count)
            .Where(i => !words[i].IsHidden())
            .ToList();

        // Shuffle the available indices to hide words randomly
        availableIndices = availableIndices.OrderBy(i => Guid.NewGuid()).ToList();

        // Hide the specified number of words
        for (int i = 0; i < Math.Min(numberToHide, availableIndices.Count); i++)
        {
            int indexToHide = availableIndices[i];
            words[indexToHide].Hide();
        }
    }

    public string GetDisplayText()
    {
        // Display the reference and the text of the scripture
        return $"{_reference.GetDisplayText()}\n\n{_reference.GetDisplayTextWithHiddenWords(words)}";
    }

    public bool IsCompletelyHidden()
    {
        // Check if all words in the scripture are hidden
        return words.All(word => word.IsHidden());
    }
}
