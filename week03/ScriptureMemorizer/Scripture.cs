using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<int> randomNumberList = new List<int>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            Boolean randomNumberExist = false;
            while (!randomNumberExist)
            {
                int randomNumber = randomGenerator.Next(_words.Count());
                if (!randomNumberList.Contains(randomNumber))
                {
                    randomNumberList.Add(randomNumber);
                    randomNumberExist = true;
                }
            }
        }

        for (int i = 0; i < _words.Count(); i++)
        {
            foreach (var number in randomNumberList)
            {
                if (i == number)
                {
                    _words[i].Hide();
                }
            }
        }
    }

    public string GetDisplayText()
    {
        string wordsString = "";
        Console.Write(_reference.GetDisplayText());
         for (int i = 0; i < _words.Count(); i++)
        {
            wordsString += _words[i].GetDisplayText() + " ";
        }
        return wordsString;
    }

    public Boolean IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count(); i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
