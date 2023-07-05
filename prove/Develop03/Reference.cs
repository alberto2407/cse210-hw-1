using System;

class Reference
{
    string book;
    int chapter, verse, endVerse;

    public Reference(string _book, int _chapter, int _verse)
    {
        book = _book;
        chapter = _chapter;
        verse = _verse;
    }

    public Reference(string _book, int _chapter, int _startVerse, int _endVerse)
    {
        book = _book;
        chapter = _chapter;
        verse = _startVerse;
        endVerse = _endVerse;
    } 

    public string GetDisplayText()
    {
        string referenceDisplay = "";

        if (endVerse !=0)
        {
            referenceDisplay = $"{book}{chapter}:{verse}-{endVerse}";
        }
        else 
        {
            referenceDisplay = $"{book}{chapter}:{verse}";
        }
        return referenceDisplay;

    }
}