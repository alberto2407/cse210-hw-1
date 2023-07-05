using System;
class Scripture
{
    Reference refence;
    List<Word> words;

    public Scripture(Reference _reference, string _text)
    {
        refence = _reference;
        words = new List<Word>();

        List<string> allWords = _text.Split(' ').ToList();
        foreach(string wordString in allWords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
        
    }

    public void HideRandomWords(int numberToHide)
    {
        

    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach(Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText == word.GetDisplayText() + "";
            } 
            else
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }
        return ($"{reference.GetDisplaytext()} {scriptureText})");
    }

    public bool IsCompletelyHidden()
    {
        return  true;
    }

    


}