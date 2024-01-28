using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<(string book, int chapter, int verse, string text)> singleVerseList = new List<(string, int, int, string)>
        {
            // Here is the single verses scripture List
            ("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life"),
            ("Alma", 7, 12, "And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities"),
            ("Nephi", 2, 2, "Nevertheless, Jacob, my firstborn in the wilderness, thou knowest the greatness of God; and he shall consecrate thine afflictions for thy gain.")
        };

        List<(string book, int chapter, int startVerse, int endVerse, string text)> verseRangeList = new List<(string, int, int, int, string)>
        {
            // Here I placed the verse ranges when the scripture has more than one verse
            ("Matthew", 25, 34, 36, "34 Then shall the King say unto them on his right hand, Come, ye blessed of my Father, inherit the kingdom prepared for you from the foundation of the world: For I was an hungred, and ye gave me meat: I was thirsty, and ye gave me drink: I was a stranger, and ye took me in: Naked, and ye clothed me: I was sick, and ye visited me: I was in prison, and ye came unto me."),
            ("Doctrine and Convenant", 21, 4, 6, "Wherefore, meaning the church, thou shalt give heed unto all his words and commandments which he shall give unto you as he receiveth them, walking in all holiness before me; For his word ye shall receive, as if from mine own mouth, in all patience and faith. For by doing these things the gates of hell shall not prevail against you; yea, and the Lord God will disperse the powers of darkness from before you, and cause the heavens to shake for your good, and his name’s glory."),
        };

        // Combine both lists for the Scriptures instance, Learned the use of AddRange
        List<(string book, int chapter, int verse, string text)> combinedList = new List<(string, int, int, string)>();
        combinedList.AddRange(singleVerseList);
        combinedList.AddRange(verseRangeList.Select(v => (v.Item1, v.Item2, v.Item3, v.Item5)));


        // Create a new instance of the Scriptures class with a randomly chosen scripture
        Scriptures scriptures = new Scriptures(combinedList);

        // Main loop to interact with the user
        while (!scriptures.IsCompletelyHidden())
        {
            // Display the scripture
            Console.Clear();
            Console.WriteLine(scriptures.GetDisplayText());
            Console.WriteLine();

            // Hide a few random words before the next iteration    
            
            scriptures.HideRandomWords(3);

            // Ask for user input
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string userInput = Console.ReadLine().ToLower();

            // Check if the user wants to quit
            if (userInput == "quit")
                break;
        }
    }
}
