namespace Bible.API.Models
{
    public class Verse
    {
        public int Id { get; set; }
        public int BookNumber { get; set; }
        public int ChapterNumber { get; set; }
        public int VerseNumber { get; set; }
        public string Text { get; set; }

        public Verse(int id, int bookNumber, int chapterNumber, int verseNumber, string text)
        {
            Id = id;
            BookNumber = bookNumber;
            ChapterNumber = chapterNumber;
            VerseNumber = verseNumber;
            Text = text;
        }

        public string BookToString(int bookNumber)
        {
            if (bookNumber == 1)
            {
                return "Genesis";
            }
            if (bookNumber == 2)
            {
                return "Exodus";
            }
            if (bookNumber == 3)
            {
                return "Leviticus";
            }
            if (bookNumber == 4)
            {
                return "Numbers";
            }
            if (bookNumber == 5)
            {
                return "Deuteronomy";
            }
            if (bookNumber == 6)
            {
                return "Joshua";
            }
            if (bookNumber == 7)
            {
                return "Judges";
            }
            if (bookNumber == 8)
            {
                return "Ruth";
            }
            if (bookNumber == 9)
            {
                return "1 Samuel";
            }
            if (bookNumber == 10)
            {
                return "2 Samuel";
            }
            if (bookNumber == 11)
            {
                return "1 Kings";
            }
            if (bookNumber == 12)
            {
                return "2 Kings";
            }
            if (bookNumber == 13)
            {
                return "1 Chronicles";
            }
            if (bookNumber == 14)
            {
                return "2 Chronicles";
            }
            if (bookNumber == 15)
            {
                return "Ezra";
            }
            if (bookNumber == 16)
            {
                return "Nehemiah";
            }
            if (bookNumber == 17)
            {
                return "Esther";
            }
            if (bookNumber == 18)
            {
                return "Job";
            }
            if (bookNumber == 19)
            {
                return "Psalms";
            }
            if (bookNumber == 20)
            {
                return "Proverbs";
            }
            if (bookNumber == 21)
            {
                return "Ecclesiastes";
            }
            if (bookNumber == 22)
            {
                return "Song of Solomon";
            }
            if (bookNumber == 23)
            {
                return "Isaiah";
            }
            if (bookNumber == 24)
            {
                return "Jeremiah";
            }
            if (bookNumber == 25)
            {
                return "Lamentations";
            }
            if (bookNumber == 26)
            {
                return "Ezekiel";
            }
            if (bookNumber == 27)
            {
                return "Daniel";
            }
            if (bookNumber == 28)
            {
                return "Hosea";
            }
            if (bookNumber == 29)
            {
                return "Joel";
            }
            if (bookNumber == 30)
            {
                return "Amos";
            }
            if (bookNumber == 31)
            {
                return "Obadiah";
            }
            if (bookNumber == 32)
            {
                return "Jonah";
            }
            if (bookNumber == 33)
            {
                return "Micah";
            }
            if (bookNumber == 34)
            {
                return "Nahum";
            }
            if (bookNumber == 35)
            {
                return "Habakkuk";
            }
            if (bookNumber == 36)
            {
                return "Zephaniah";
            }
            if (bookNumber == 37)
            {
                return "Haggai";
            }
            if (bookNumber == 38)
            {
                return "Zechariah";
            }
            if (bookNumber == 39)
            {
                return "Malachi";
            }
            if (bookNumber == 40)
            {
                return "Matthew";
            }
            if (bookNumber == 41)
            {
                return "Mark";
            }
            if (bookNumber == 42)
            {
                return "Luke";
            }
            if (bookNumber == 43)
            {
                return "John";
            }
            if (bookNumber == 44)
            {
                return "Acts";
            }
            if (bookNumber == 45)
            {
                return "Romans";
            }
            if (bookNumber == 46)
            {
                return "1 Corinthians";
            }
            if (bookNumber == 47)
            {
                return "2 Corintheans";
            }
            if (bookNumber == 48)
            {
                return "Galatians";
            }
            if (bookNumber == 49)
            {
                return "Ephesians";
            }
            if (bookNumber == 50)
            {
                return "Philippians";
            }
            if (bookNumber == 51)
            {
                return "Colossians";
            }
            if (bookNumber == 52)
            {
                return "1 Thessalonians";
            }
            if (bookNumber == 53)
            {
                return "2 Thessalonians";
            }
            if (bookNumber == 54)
            {
                return "1 Timothy";
            }
            if (bookNumber == 55)
            {
                return "2 Timothy";
            }
            if (bookNumber == 56)
            {
                return "Titus";
            }
            if (bookNumber == 57)
            {
                return "Philemon";
            }
            if (bookNumber == 58)
            {
                return "Hebrews";
            }
            if (bookNumber == 59)
            {
                return "James";
            }
            if (bookNumber == 60)
            {
                return "1 Peter";
            }
            if (bookNumber == 61)
            {
                return "2 Peter";
            }
            if (bookNumber == 62)
            {
                return "1 John";
            }
            if (bookNumber == 63)
            {
                return "2 John";
            }
            if (bookNumber == 64)
            {
                return "3 John";
            }
            if (bookNumber == 65)
            {
                return "Jude";
            }
            else
            {
                return "Revelation";
            }
        }
    }
}
