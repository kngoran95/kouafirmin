using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }


    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileFormat());        
            }
        }
    }


    public void LoadFromFile(string fileName)
    {

        if (File.Exists(fileName))
        {
            Console.WriteLine("File not found");
            return;
        }

        _entries.Clear();
        
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 5)
            {

                
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2],
                    _mood = parts[3],
                    _weather = parts[4],
                };
                

                _entries.Add(entry);
            }
        }
    }
}




