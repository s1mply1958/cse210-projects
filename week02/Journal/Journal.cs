using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {
    
    }
    public void LoadFromFile(string file)
    {

    }


}
