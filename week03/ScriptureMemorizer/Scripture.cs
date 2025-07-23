public class Scripture
{
    Reference _reference;
    List<Word> _word = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] words = text.Split(" ");
        foreach (string wordText in words)
        {
            Word word = new Word(wordText);
            _word.Add(word);
        }
    }
    public void HideRandomWord(int numberToHide)
    {
        Random random = new Random();

        int count = 0;
        while (count < numberToHide)
        {
            int index = random.Next(_word.Count);
            if (!_word[index].IsHidden())
            {
                _word[index].Hide();
                count++;
            }   
        }

    }
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _word)
        {
            text += word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + "\n" + text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}