using System;
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(String _file)
    {
        using (StreamWriter outputFile = new StreamWriter(_file))
        {
            foreach (Entry entrie in _entries)
            {
                outputFile.WriteLine(entrie._date + "," + entrie._promptText + "," + entrie._entryText);
            }
        }
    }

    public void LoadFromFile(String _file)
    {
        string[] entriesInFileToLoad = System.IO.File.ReadAllLines(_file);
        foreach (string entriesStr in entriesInFileToLoad)
        {
            string[] parts = entriesStr.Split(",");
            Entry entryLoad = new Entry();
            entryLoad._date = parts[0];
            entryLoad._promptText = parts[1];
            entryLoad._entryText = parts[2];
            _entries.Add(entryLoad);
        }
    }
    
}