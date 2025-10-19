public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(' ');
        foreach (var word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        _reference.DisplayReference();

        foreach (Word word in _words)
        {
            Console.Write(word.GetRenderedText() + " ");
        }

        Console.WriteLine();
    }

    public void HideWords(int count)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}

