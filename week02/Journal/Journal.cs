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
    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving to file..."); // Exceeding requirements 

        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}\n{entry._promptText}\n{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Reading from file..."); // Exceeding requirements 

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines)
        {
            string date = lines[0];
            string promptText = lines[1];
            string entryText = lines[2];

            Entry entry = new Entry(date, promptText ,entryText);
            _entries.Add(entry);
            
        }

    }


}
