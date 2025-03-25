using System;
public class Fractions
{
    private int _topNumber;
    private int _bottonNumber;

    public Fractions()
    {
        _topNumber = 1;
        _bottonNumber = 1;
    }

    public Fractions(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottonNumber = 1;
    }

    public Fractions(int topNumber, int bottonNumber)
    {
        _topNumber = topNumber;
        _bottonNumber = bottonNumber;
    }

    public int GetTop() { return _topNumber; }
    public void SetTop(int top) { _topNumber = top; }
    public int GetBotton() { return _bottonNumber; }
    public void SetBotton(int botton) { _topNumber = botton; }

    public string GetFractionString()
    {
        string text = $"{_topNumber}/{_bottonNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottonNumber;
    }
}