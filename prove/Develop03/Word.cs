using System;

class Word
{
    string text;
    bool isHidden;

    public Word(string _text)
    {
        text = _text;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Show()
    {
        isHidden = false;
    }

    public bool GetisHidden()
    {
        return isHidden;
    }

    public string GetDisplayText()
    {
        return text;
    }
}