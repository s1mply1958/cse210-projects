using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename) //public void SaveToFile(List<Entry>)??
    {
        string file = "journal.txt";

        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}\n{entry._promptText}\n{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        //_entries.Clear();??
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }

    }


}
