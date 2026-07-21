using System; 
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        String[] splitWords = text.Split(' ');
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
         int index = _random.Next(_words.Count);
            _words[index].Hide();   
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scripturetext = "";

        foreach (Word w in _words)
        {
            scripturetext += w.GetDisplayText() + " ";
        }
        return $"{referenceText}\n{scripturetext}";
    }

}