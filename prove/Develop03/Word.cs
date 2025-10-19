public class Word
{
    private string _text;
    private bool _hiddenWords;

    public Word(string text)
    {
        _text = text;
        _hiddenWords = false;
    }

    public void Hide()
    {
        _hiddenWords = true;
    }

    public void Show()
    {
        _hiddenWords = false;
    }

    public string GetRenderedText()
    {
        if (_hiddenWords)
        {
            return "____";
        }

        else
        {
            return _text;
        }
    }

    public bool IsHidden()
    {
        return _hiddenWords;
    }
}